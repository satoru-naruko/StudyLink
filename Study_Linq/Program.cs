using System;
using System.Linq;

namespace Study_Linq
{
    class MainClass
    {
        private static readonly string split_str = "---------------------------------";
        static void Main(string[] args)
        {

            var books = new BookRepository().GetBook();

            try
            {
                // 抽出
                var cheapBooks = books.Where(b => b.Price < 30).OrderBy(b => b.Tiele).Select(b => b.Tiele);
                foreach (var item in cheapBooks)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(split_str);

                // 抽出/加工
                var list = books.Select(b => b.Tiele + "_naruko");
                foreach (var appendstr in list)
                {
                    Console.WriteLine(appendstr);
                }
                Console.WriteLine(split_str);

                // 検索
                var book = books.SingleOrDefault(b => b.Tiele == "aasfaaa");
                Console.WriteLine(book.Tiele + " is only");
                Console.WriteLine(split_str);

                // 値段10以上の合計
                var prices = books.Where(b => b.Price > 10).Sum(b => b.Price);
                Console.WriteLine(prices);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
