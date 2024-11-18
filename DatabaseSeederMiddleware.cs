using RPBDIS_lab4.Models;

public class DatabaseSeederMiddleware
{
    private readonly RequestDelegate _next;

    public DatabaseSeederMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, LibraryDbContext dbContext)
    {
        if (!dbContext.Books.Any())
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Тестовый жанр 1" },
                new Genre { Name = "Тестовый жанр 2" },
                new Genre { Name = "Тестовый жанр 3" }
            };
            dbContext.Genres.AddRange(genres);
            await dbContext.SaveChangesAsync();

            var books = new List<Book>
            {
                new Book { Title = "Тестовая книга 1", GenreId = 1 },
                new Book { Title = "Тестовая книга 2", GenreId = 1 }
            };
            dbContext.Books.AddRange(books);
            await dbContext.SaveChangesAsync();

            var loanedBooks = new List<LoanedBook>
            {
                new LoanedBook { BookId = 1, LoanDate = new DateOnly(2024,11,15) },
                new LoanedBook { BookId = 1, LoanDate = new DateOnly(2024,11,15), ReturnDate = new DateOnly(2024,11,18) }
            };
            dbContext.LoanedBooks.AddRange(loanedBooks);
            await dbContext.SaveChangesAsync();
        }

        await _next(context);
    }
}
