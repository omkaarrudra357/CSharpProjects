using FirstMVCapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVCapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DoLogin(String txtUser, String txtpwd)
        {
            ViewData["userValue"] = $"{txtUser}, {txtpwd}";
            return View();
        }

        public IActionResult SayHello(String name)
        {
            if(String.IsNullOrEmpty(name))
            {
                ViewData["V1"]="Name is Empty";
            }
            else
                ViewData["V1"]=name;
            return View();
        }
        public IActionResult Add(int x, int y)
        {
            int result = x+y;
            ViewData["result"] = result;
            return View();
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x*y;
            ViewData["result"] = result;
            return View("Add");
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x/y;
            ViewData["result"] = result;
            return View("Add");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddNewBook()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult SaveNewBook(Book pBook)
        {
            String fName = @"c:\temp\book.csv";
            string strBook = $"{pBook.BookID}, {pBook.Title}, {pBook.AuthorName}, {pBook.Cost}";
            using (StreamWriter sw = new StreamWriter(fName,true))
            {
                sw.WriteLine(strBook+Environment.NewLine);
            }
            return View(pBook);
        }

        public IActionResult ListAllBooks()
        {
            String fname = @"c:temp\book.csv";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fname))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    book = StringToBook(data, new Book());
                    list.Add(book);
                }
            }
            return View(list);
        }
        private Book StringToBook(string[] data, Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;
        }



//        private Author StringToAuthor(string[] dataA, Author author)
//        {
//            author.AuthID = int.Parse(dataA[0]);
//            author.AuthorName = dataA[1];
//            author.NoOfBooks = int.Parse(dataA[2]);
//            author.RoyaltyCompany = dataA[3];
//            return author;
//        }

//        public IActionResult CreateAuthor()
//        {
//            Author author = new Author();
//            return View(author);
//        }

//        public IActionResult SaveNewAuth(Author Auth1)
//        {
//            String fName = @"c:\temp\author.csv";
//            string strAuth = $"{Auth1.AuthID}, {Auth1.AuthorName}, {Auth1.RoyaltyCompany}, {Auth1.NoOfBooks}";
//            using (StreamWriter sw1 = new StreamWriter(fName, true))
//            {
//                sw1.WriteLine(strAuth+Environment.NewLine);
//            }
//            return View(Auth1);
//        }
//        public IActionResult AuthorList()
//        {
//            String fname = @"c:temp\author.csv";
//            List<Author> list = new List<Author>();
//            using (StreamReader sr = new StreamReader(fname))
//            {
//                string strAuth = $"{sr.ReadLine()}";
//                String[] data = strAuth.Split(',');
//                Author author = StringToAuthor(data, new Author());
//                list.Add(author);
//                while (!sr.EndOfStream)
//                {
//                    strAuth = $"{sr.ReadLine()}";
//                    data = strAuth.Split(',');
//                    author = StringToAuthor(data, new Author());
//                    list.Add(author);
//                }
//            }
//            return View(list);
//        }
    }
}