using System;

namespace DictionaryGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> City = new MyDictionary<int, string>();

            City.Add(34, "İstanbul");
            City.Add(35, "İzmir");
            City.Add(1, "Adana");
            City.Add(24, "Erzincan");
            City.Add(6, "Ankara");

            City.List();
        }
    }
}
