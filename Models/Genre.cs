namespace RPBDIS_lab4.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }

}
