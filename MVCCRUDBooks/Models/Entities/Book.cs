namespace MVCCRUDBooks.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Autor { get; set; }
        public DateTime FechaEdicion { get; set; }
        public string Editora { get; set; }
    }

}
