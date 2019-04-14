using System.Collections.Generic;

namespace Study_Linq
{
    public class Book
    {
        public string Tiele{ get; set; }
        public int Price{ get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBook()
        {
            return new List<Book>
            {
                new Book(){Tiele = "aasfaaa", Price=3 },
                new Book(){Tiele = "aacZcsfaaa", Price=30 },
                new Book(){Tiele = "sadfaaa", Price=311 },
                new Book(){Tiele = "aafaa", Price=13 },
                new Book(){Tiele = "asasafasfdffaaaaaa", Price=53 },

            };
        }

    }
}
