namespace Library.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = "A new book";
        public string Authors { get; set; } = "abc";
        public string Publisher { get; set; } = "Kim Đồng";
        public int Year { get; set; } = DateTime.Now.Year;
        public string Description { get; set; } = "zzzzzzzz";

    }
}
