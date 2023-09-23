namespace LibraryA
{
    public class Book
    {
        public string Title = string.Empty;
        public string Author = string.Empty;
        public string Genre = string.Empty;
        public DateTime DateOfPublished;
        public int BookPrice;
        public int TotalPages;
        public void OpenBook()
        {
            Console.WriteLine("Book is Open");
        }

        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"Page No.: {pageNo} Bookmarked");
        }

        public int GetCurrentPage() 
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }
    }
}