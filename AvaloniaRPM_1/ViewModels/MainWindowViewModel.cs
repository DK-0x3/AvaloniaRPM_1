using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using AvaloniaRPM_1.Models;
using AvaloniaRPM_1.Repository;
using AvaloniaRPM_1.Views;
using ReactiveUI;

namespace AvaloniaRPM_1.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
       public ObservableCollection<Book> Books { get; set; }
       
       public MainWindowViewModel()
       {
           Books = LibraryBooks.Books;
           
           Books.Add(new Book() { ID="1", Title = "Книга 1", Author = "Автор 1", Genre = "Жанр 1", Year = "2000", CountPage = 100 });
           Books.Add(new Book() { ID="2", Title = "Книга 2", Author = "Автор 2", Genre = "Жанр 2", Year = "2002", CountPage = 200 });
           Books.Add(new Book() { ID="3", Title = "Книга 3", Author = "Автор 3", Genre = "Жанр 3", Year = "2300", CountPage = 300 });
           
       }
}