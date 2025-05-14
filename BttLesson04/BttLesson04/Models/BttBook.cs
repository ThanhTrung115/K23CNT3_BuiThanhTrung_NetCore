namespace BttLesson04.Models
{
    public class BttBook
    {
        public string BttId { get; set; }
        public string BttTitle { get; set; }
        public string BttDescription { get; set; }
        public string BttImage { get; set; }
        public float BttPrice { get; set; }
        public int BttPage { get; set; }
        
        //danh sách các cuốn sách
        public List<BttBook> GetBttBookList()
        {
            List<BttBook> bttBooks = new List<BttBook>
            {
                new BttBook
                {
                    BttId = "B001",
                    BttTitle = "C# Programming Basics",
                    BttDescription = "An introduction to C# programming for beginners.",
                    BttImage = "images/book-1.jpg",
                    BttPrice = 12.99f,
                    BttPage = 200
                },
                new BttBook
                {
                    BttId = "B002",
                    BttTitle = "Mastering ASP.NET Core",
                    BttDescription = "A comprehensive guide to building web applications with ASP.NET Core.",
                    BttImage = "images/book-2.jpg",
                    BttPrice = 24.50f,
                    BttPage = 350
                },
                new BttBook
                {
                    BttId = "B003",
                    BttTitle = "LINQ in Action",
                    BttDescription = "Learn how to use LINQ to query data in .NET.",
                    BttImage = "images/book-3.jpg",
                    BttPrice = 18.75f,
                    BttPage = 280
                },
                new BttBook
                {
                    BttId = "B004",
                    BttTitle = "Entity Framework Core",
                    BttDescription = "Working with databases using Entity Framework Core.",
                    BttImage = "images/book-4.jpg",
                    BttPrice = 20.00f,
                    BttPage = 320
                },
                new BttBook
                {
                    BttId = "B005",
                    BttTitle = "Design Patterns in C#",
                    BttDescription = "Explore common design patterns used in C# development.",
                    BttImage = "images/book-5.jpg",
                    BttPrice = 22.99f,
                    BttPage = 400
                }
            };
            return bttBooks;
        }
        public BttBook GetBttBookById(string id)
        {
            BttBook bttBook = this.GetBttBookList().FirstOrDefault(b => b.BttId == id);
            return bttBook;
        }
    }
}
