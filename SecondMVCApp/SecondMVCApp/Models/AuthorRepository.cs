using SecondMVCApp.Models;
using System.Text;

namespace MVCAuthor.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            String fName = @"C:\temp\author.txt";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFilExists = System.IO.File.Exists(fName);
            if (isFilExists)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;



                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.Id, author);
                        while (!sr.EndOfStream) ;
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(',');
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.Id, author);
                            }
                        }
                    }
                }
            }
            return list;
        }
        private static Author StringToAuthor(String[] data, Author author)
        {



            author.Id = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.NoOfBooks = int.Parse(data[2]);
            author.RoyaltyCompany = data[3];
            //author.DOB = DateTime.Parse(data[4]);
            return author;



        }
        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (list!=null)
            {
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;
        }
        public static void SaveToFile(Author pauthor)
        {
            String fName = @"c:\temp\author.txt";
            string strAuthor = $"{pauthor.Id}, {pauthor.AuthorName}, {pauthor.RoyaltyCompany}, {pauthor.NoOfBooks} ";
            using (StreamWriter sw = new StreamWriter(fName, true)) { sw.WriteLine(strAuthor); }
        }

        public static void UpdateToFile(Author pauthor)
        {
            String fName = @"c:\temp\author.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            { 
                foreach (Author author in list.Values)
                {
                    if(author.Id != pauthor.Id)
                        strAuthor = $"{author.Id}, {author.AuthorName}, {author.RoyaltyCompany}, {author.NoOfBooks} ";
                    else
                        strAuthor = $"{pauthor.Id}, {pauthor.AuthorName}, {pauthor.RoyaltyCompany}, {pauthor.NoOfBooks} ";
                    sw.WriteLine(strAuthor);
                }
                
            }
        }
        public static void RemoveAuthor(int id)
        {
            String fName = @"c:\temp\author.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder strAuthor = new StringBuilder(list.Count+100);
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.Id != author.Id)
                        strAuthor.Append($"{author.Id}, {author.AuthorName}, {author.RoyaltyCompany}, {author.NoOfBooks}");
                   
                    File.WriteAllText(fName, strAuthor.ToString());
                }

            }
        }
        public static void SaveAllAuthorToFile(Dictionary<int, Author> AuthorList)
        {
        }
    }
}