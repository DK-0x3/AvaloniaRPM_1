using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaRPM_1.Models;
using AvaloniaRPM_1.ViewModels;

namespace AvaloniaRPM_1.Views;

public partial class MainWindow : Window
{
    public static MainWindow? Instance { get; private set; }
    
    public MainWindow()
    {
        InitializeComponent();
        Instance = this;
    }
    
    private void OnEditBookRequested(object? sender, Book book)
    {
        EditBookDialog.DataContext = new EditBookDialogViewModel(book);
        EditBookDialog.OpenEditBookDialog(book);
    }

    private void OnDeleteBookRequested(object? sender, Book book)
    {
        DeleteBookDialog.DataContext = new DeleteBookDialogViewModel(book);
        DeleteBookDialog.OpenDeleteBookDialog(book);
    }

    private void ButtonOnClick_AddBook(object? sender, RoutedEventArgs e)
    {
        AddBookDialog.OpenAddBookDialog();
    }
    
    public void ShowErrorDialog(ErrorApplication errorApplication)
    {
        ErrorDialog.OpenPopup(errorApplication);
    }
}