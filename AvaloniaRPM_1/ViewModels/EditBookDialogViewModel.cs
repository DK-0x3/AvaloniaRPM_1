using System;
using System.Reactive;
using AvaloniaRPM_1.Models;
using ReactiveUI;

namespace AvaloniaRPM_1.ViewModels;

public class EditBookDialogViewModel : ReactiveObject
{
    public Book Book { get; set; }
        
    public EditBookDialogViewModel(Book book)
    {
        Book = book;
    }
}