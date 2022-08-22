using System;
using System.Text.RegularExpressions;
using System.IO;
namespace Home10
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMyBook.Finder("Захар Беркут");
        }
    }
}
public static class FindMyBook
{
    public static void Finder(string bookOrAuthor)
    {
        string[] phoneBook = { "Іван Франко 'Фарбований лис'", "Іван Франко 'Захар Беркут'", "Орвест Орвелл '1984'", "Орвест Орвелл 'Ферма тварин'", "Олександр Довженко 'Зачарована Десна'" };
        string ss;
        ss = bookOrAuthor;
        try
        {
            Regex regex = new Regex(ss);
            int hMatcher;

            for (int i = 0; i < phoneBook.Length; i++)
            {
                string s = phoneBook[i];



                MatchCollection matches = regex.Matches(s);
                hMatcher = matches.Count;
                if (matches.Count != 0)
                {

                    Console.WriteLine(phoneBook[i]);

                }
                if (hMatcher < 1 && i == phoneBook.Length)
                {
                    Console.WriteLine("Нікого не знайдено");
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Введiть коректнi даннi, без '+'");
            Console.WriteLine(ex.Message);
        }
    }

}
