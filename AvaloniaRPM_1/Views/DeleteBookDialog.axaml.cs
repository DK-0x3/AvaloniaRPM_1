using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaRPM_1.Models;
using AvaloniaRPM_1.Repository;

namespace AvaloniaRPM_1.Views;

public partial class DeleteBookDialog : UserControl
{
    public Book Book { get; set; }
    public bool IsDeleteBookDialogOpen { get; set; }
    
    public DeleteBookDialog()
    {
        InitializeComponent();
    }
    
    public void OpenDeleteBookDialog(Book book)
    {
        Book = book;
        PopupDeleteBook.IsVisible = true;
        IsDeleteBookDialogOpen = true;
        InvalidateVisual();
    }

    private void OnCloseButtonClick(object sender, RoutedEventArgs e)
    {
        PopupDeleteBook.IsVisible = false;
        IsDeleteBookDialogOpen = false;
        InvalidateVisual();
    }

    private void ButtonOnClick_DeleteBook(object? sender, RoutedEventArgs e)
    {
        LibraryBooks.Books.Remove(Book);
        PopupDeleteBook.IsVisible = false;
        IsDeleteBookDialogOpen = false;
        InvalidateVisual();
    }
}