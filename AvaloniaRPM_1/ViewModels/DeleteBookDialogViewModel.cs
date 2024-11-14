using AvaloniaRPM_1.Models;
using ReactiveUI;

namespace AvaloniaRPM_1.ViewModels;

public class DeleteBookDialogViewModel : ReactiveObject
{
    public Book Book { get; set; }
        
    public DeleteBookDialogViewModel(Book book)
    {
        Book = book;
    }
}
