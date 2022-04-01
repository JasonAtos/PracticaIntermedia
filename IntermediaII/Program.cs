using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace IntermediaII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Punto 1
            var tupleList = new List<(int, int)>
            {
                (1,1),
                (2,2),
                (3,3),
            };

            var tupleList2 = new List<(string name, string kind, int replicas, bool run)>
            {
                ("yo", "motociclista", 100, true),
                ("alguien", "enlatado", 1000, false),
                ("copiloto", "ambos", 2, false),
            };

            tupleList.ForEach(element =>
            {
                Console.WriteLine(element);
            });

            tupleList2.ForEach(element =>
            {
                Console.WriteLine(element);
            });

            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");

            //Punto 2
            ClassA classA = new("soy un objeto de A", "como vez mijo");
            ClassB classB = new("soy un objecto de B");
            string cadenaYaConvertida = classA; //ya no se pone tostring porque ya hice la conversion en la clase
            ClassB objetoBConvertido = classA;
            //Basicamente es hacer
            //la conversion en la clase para no tener que estar
            //modificando cada uno de sus caracteristicas en donde se llaman
            ClassA objetoAConvertido = classB;
            Console.WriteLine(cadenaYaConvertida);
            Console.WriteLine(objetoBConvertido);
            Console.WriteLine(objetoAConvertido);
            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");

            //Punto 3
            List<MyStructTest> myStructList = new();
            List<MyClassTest> myClassList = new();

            Stopwatch stopwatch1 = Stopwatch.StartNew();
            for (int i = 0; i < 10000000; i++)//10 millones
            {
                myStructList.Add(new MyStructTest(i, i));//crear objetos
            }
            stopwatch1.Stop();

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            for (int i = 0; i < 10000000; i++)//10 millones
            {
                myClassList.Add(new MyClassTest(i, i));//crear objetos
            }
            stopwatch2.Stop();

            Console.WriteLine($"{stopwatch1.Elapsed}-->Time with structures");
            Console.WriteLine($"{stopwatch2.Elapsed}-->Time with classes");

            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");

            //Punto 4
            Queue<int> queue = new();
            Stopwatch stopwatchQueue = Stopwatch.StartNew();
            for (int i = 0; i < 10000000; i++)
            {
                queue.Enqueue(i);
            }
            var reverseQueue = CustomMethods.ReverseWithQueue(queue);
            stopwatchQueue.Stop();
            Console.WriteLine($"{stopwatchQueue.Elapsed}-->Queue");



            List<int> list = new ();
            Stopwatch stopwatchList = Stopwatch.StartNew();

            for (int i = 0; i < 10000000; i++)
            {
                list.Add(i);
            }
            var reverseList = CustomMethods.ReverseWithList(list);
            stopwatchList.Stop();
            Console.WriteLine($"{stopwatchList.Elapsed}-->List");



            Dictionary<int, int> dictionary = new ();
            Stopwatch stopwatchDictionary = Stopwatch.StartNew();
            for (int i = 0; i < 10000000; i++)
            {
                dictionary.Add(i, i);
            }
            var reverseDictionary = CustomMethods.ReverseWithDictionary(dictionary);
            stopwatchDictionary.Stop();
            Console.WriteLine($"{stopwatchDictionary.Elapsed}-->Dictionary");

            Console.WriteLine("========================================================");
            Console.WriteLine("========================================================");

            //Punto 5
            string word1 = "soy un loco";     
            string word2 = "Se es o no se es";//Palindromo
            string word3 = "Alguna otra palabra";     
            string word4 = "Se laminan animales";//Palindromo
            Console.WriteLine($"{word1}-->{Methods.CheckPalindrome(word1)}");
            Console.WriteLine($"{word2}-->{Methods.CheckPalindrome(word2)}");
            Console.WriteLine($"{word3}-->{Methods.CheckPalindrome(word3)}");
            Console.WriteLine($"{word4}-->{Methods.CheckPalindrome(word4)}");

        }        
    }
}
