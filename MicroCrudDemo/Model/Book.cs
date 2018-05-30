using System;
namespace MicroCrudDemo.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public DateTime ReadDate { get; set; } 
    }
}
