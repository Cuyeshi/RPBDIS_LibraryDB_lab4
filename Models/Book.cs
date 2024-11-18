namespace RPBDIS_lab4.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; } // Навигационное свойство
    }

}
