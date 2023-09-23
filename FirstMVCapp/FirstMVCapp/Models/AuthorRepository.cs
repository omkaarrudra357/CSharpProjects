namespace FirstMVCapp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary() 
        {
            String fName = @"c:\temp\Author.csv";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExists = System.IO.File.Exists(fName);
            if(isFileExists)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if(data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.Id, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(",");
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.Id, author);
                            }

                        }
                    }
                   
            return list;
        }

        private static Author StringToAuthor(String[] data, Author author) { }

        public static List<Author> GetAuthorList()
        {

        }
        public static Author FindAuthorByID(int id)
        {

        }
        public static void SaveToFile(Author pAuthor)
        {

        }
        public static void RemoveAuthor(int id)
        {

        }
        //public static void (int id) { }


    }
}
