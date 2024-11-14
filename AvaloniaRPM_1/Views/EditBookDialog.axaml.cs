using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaRPM_1.Models;
using AvaloniaRPM_1.Repository;

namespace AvaloniaRPM_1.Views;

public partial class EditBookDialog : UserControl
{
    private Book _book { get; set; }

    public bool IsEditBookDialogOpen { get; set; }

    public EditBookDialog()
    {
        InitializeComponent();
        DataContext = this;
    }

    public void OpenEditBookDialog(Book book)
    {
        _book = book;
        PopupEditBook.IsVisible = true;
        IsEditBookDialogOpen = true;
        InvalidateVisual();
    }

    private void OnCloseButtonClick(object sender, RoutedEventArgs e)
    {
        PopupEditBook.IsVisible = false;
        IsEditBookDialogOpen = false;
        InvalidateVisual();
    }

    private void ButtonOnClick_SaveBook(object? sender, RoutedEventArgs e)
    {
          var bookSave = _book;
          var index = LibraryBooks.Books.IndexOf(bookSave);
          
          if (index != -1)
          {
              if (MainWindow.Instance is null)
              {
                  return;
              }
              
              if (TitleBookEdit.Text == null)
              {
                  MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите название книги!"});
                  return;
              }
              bookSave.Title = TitleBookEdit.Text;
              
              if (AuthorBookEdit.Text == null)
              {
                  MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите автора книги!"});
                  return;
              }
              bookSave.Author = AuthorBookEdit.Text;
              
              if (GenreBookEdit.Text == null)
              {
                  MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите жанр книги!"});
                  return;
              }
              bookSave.Genre = GenreBookEdit.Text;
              
              if (YearBookEdit.Text == null)
              {
                  MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите год книги!"});
                  return;
              }
              bookSave.Year = YearBookEdit.Text;
              
              if (CountPageBookEdit.Text == null)
              {
                  MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите кол-во страниц книги!"});
                  return;
              }
              
              if (int.TryParse(CountPageBookEdit.Text.ToString(), out int countPage))
              {
                  bookSave.CountPage = countPage;
              }
              else
              {
                  MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите кол-во страниц книги ЧИСЛОМ!"});
                  return; 
              }
                      
              bookSave.CountPage = Convert.ToInt32(CountPageBookEdit.Text);
          
              LibraryBooks.Books[index] = bookSave;
          
              PopupEditBook.IsVisible = false;
              IsEditBookDialogOpen = false;
              InvalidateVisual();
          }
    }
}