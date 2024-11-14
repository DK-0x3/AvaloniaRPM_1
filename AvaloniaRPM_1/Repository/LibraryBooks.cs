using System.Collections.ObjectModel;
using AvaloniaRPM_1.Models;

namespace AvaloniaRPM_1.Repository;

public static class LibraryBooks
{
    static LibraryBooks()
    {
        Books = new ObservableCollection<Book>();
    }

    // Статическая коллекция книг
    public static ObservableCollection<Book> Books { get; set; }
}