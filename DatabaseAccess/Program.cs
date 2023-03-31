using DatabaseAccess;

using (var context = new DatabaseContext())
{
    context.Database.EnsureCreated();
    context.Books.Add(new DatabaseAccess.Model.Book
    {
        Description = "Test",
        Title = "Test",
    });

    context.SaveChanges();

    var books = context.Books.ToList();
    foreach (var book in books)
    {
        Console.WriteLine($"{book.Title} by {book.Description}");
    }
}
