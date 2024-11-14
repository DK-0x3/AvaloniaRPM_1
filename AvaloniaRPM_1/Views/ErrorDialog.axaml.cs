using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaRPM_1.Models;

namespace AvaloniaRPM_1.Views;

public partial class ErrorDialog : UserControl
{
    private ErrorApplication _errorApplication { get; set; }
    public bool IsErrorDialogOpen { get; set; }
    
    public ErrorDialog()
    {
        InitializeComponent();
        DataContext = this;
    }
    
    public void OpenPopup(ErrorApplication errorApplication)
    {
        _errorApplication = errorApplication;
        ErrorTitleText.Text = errorApplication.Title;
        ErrorMessageText.Text = errorApplication.Message;
        
        PopupError.IsVisible = true;
        IsErrorDialogOpen = true;
        InvalidateVisual();
    }
    
    private void OnCloseButtonClick(object sender, RoutedEventArgs e)
    {
        PopupError.IsVisible = false;
        IsErrorDialogOpen = false;
        InvalidateVisual();
    }
}