using System;
using System.Reactive;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaRPM_1.Models;
using AvaloniaRPM_1.ViewModels;
using ReactiveUI;

namespace AvaloniaRPM_1.Views
{
    public partial class BookInfoControl : UserControl
    {
        public event EventHandler<Book>? EditBookRequested;
        public event EventHandler<Book>? DeleteBookRequested;
        
        public BookInfoControl()
        {
            InitializeComponent();
            DataContext = this;
        }
        
        private void ButtonOnClick_EditBook(object? sender, RoutedEventArgs e)
        {
            if (DataContext is Book book2)
            {
                EditBookRequested?.Invoke(this, book2);
            }
        }

        private void ButtonOnClick_DeleteBook(object? sender, RoutedEventArgs e)
        {
            if (DataContext is Book book2)
            {
                DeleteBookRequested?.Invoke(this, book2);
            }
        }
    }
}