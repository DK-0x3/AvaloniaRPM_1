using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaRPM_1.Models;
using AvaloniaRPM_1.Repository;

namespace AvaloniaRPM_1.Views;

public partial class AddBookDialog : UserControl
{
    public AddBookDialog()
    {
        InitializeComponent();
    }
    
    public bool IsDialogAddBookOpen { get; set; }
    
    public void OpenAddBookDialog()
    {
        PopupAddBook.IsVisible = true;
        IsDialogAddBookOpen = true;
        InvalidateVisual();
    }

    private void OnCloseButtonClick(object sender, RoutedEventArgs e)
    {
        PopupAddBook.IsVisible = false;
        IsDialogAddBookOpen = false;
        InvalidateVisual();
    }

    private void ButtonOnClick_AddBook(object? sender, RoutedEventArgs e)
    {
        Book bookSave = new Book();

        if (MainWindow.Instance is null)
        {
            return;
        }
        
        if (TitleBookAdd.Text == null)
        {
            MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите название книги!"});
            return;
        }
        bookSave.Title = TitleBookAdd.Text;
        
        if (AuthorBookAdd.Text == null)
        {
            MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите автора книги!"});
            return;
        }
        bookSave.Author = AuthorBookAdd.Text;
        
        if (GenreBookAdd.Text == null)
        {
            MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите жанр книги!"});
            return;
        }
        bookSave.Genre = GenreBookAdd.Text;
        
        if (YearBookAdd.Text == null)
        {
            MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите год книги!"});
            return;
        }
        bookSave.Year = YearBookAdd.Text;
        
        if (CountPageBookAdd.Text == null)
        {
            MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите кол-во страниц книги!"});
            return;
        }

        if (int.TryParse(CountPageBookAdd.Text.ToString(), out int countPage))
        {
            bookSave.CountPage = countPage;
        }
        else
        {
            MainWindow.Instance.ShowErrorDialog(new ErrorApplication() {Title = "Ошибка создания книги", Message = "Введите кол-во страниц книги ЧИСЛОМ!"});
            return; 
        }
        
        LibraryBooks.Books.Add(bookSave);
        
        PopupAddBook.IsVisible = false;
        IsDialogAddBookOpen = false;
        InvalidateVisual();
    }
}