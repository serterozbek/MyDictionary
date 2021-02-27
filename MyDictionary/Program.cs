using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> musteriler = new MyDictionary<int, string>();
            musteriler.Add(105, "Serter Özbek");
            musteriler.Add(205, "Osman Gümüş");
            musteriler.Add(15, "Yunus Demirel");
            musteriler.Add(58, "Okan Dursun");
 
        }
    }
}
