using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            HandleException(() =>
            {
                myDictionary.Add(5, "selam");               
                myDictionary.Add(1, "merhaba");              
                myDictionary.Add(8, "hello");
                //Hata durumu
                myDictionary.Add(1, "hi");

            });


            foreach (var value in myDictionary.Values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(myDictionary.Count);

            Console.WriteLine(myDictionary.GetValueByKey(8));
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }
    }
}
