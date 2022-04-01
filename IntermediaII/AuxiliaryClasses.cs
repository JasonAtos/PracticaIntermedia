using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediaII
{
    //Clases para punto 2
    public class ClassA
    {
        public string propertyA;
        public string propertyAA;

        public static implicit operator string(ClassA obj)
        {
            return $"{obj.propertyA} {obj.propertyAA}";
        }

        public static implicit operator ClassB(ClassA obj)
        {
            ClassB classB = new (obj.propertyA);
            return classB;
        }
        
        public ClassA(string _propertyA, string _propertyAA) //constructor
        {
            this.propertyA = _propertyA;
            this.propertyAA = _propertyAA;
        }
    }

    public class ClassB
    {
        public string propertyB;

        public static implicit operator ClassA(ClassB obj)
        {
            ClassA classA = new(obj.propertyB, "se creo en B");
            return classA;
        }

        public ClassB(string _propertyB) //constructor
        {
            this.propertyB = _propertyB;
        }

    }

    //Clases para punto 3
    public struct MyStructTest
    {
        public double X;
        public double Y;
        public MyStructTest(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class MyClassTest
    {
        public double X;
        public double Y;
        public MyClassTest(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    //Clases para punto 4
    public static class CustomMethods
    {
        public static Queue<int> ReverseWithQueue(Queue<int> queue)
        {
            return new Queue<int>(queue.Reverse());
        }

        public static List<int> ReverseWithList(List<int> list)
        {
            list.Reverse();
            return list;
        }

        public static Dictionary<int, int> ReverseWithDictionary(Dictionary<int, int> dictionary)
        {
            return new Dictionary<int, int>(dictionary.Reverse());
        }

    }

    //Clases para punto 5
    public static class Methods
    {
        public static bool CheckPalindrome(string word)
        {
            Stack<char> stackWord = new ();
            string wordWES = word.ToLower().Trim().Replace(" ", ""); //WES = Without Empty Spaces

            foreach (var letter in wordWES)
            {
                stackWord.Push(letter);
            }

            string reverseWord = "";
            
            foreach(var letter in stackWord)
            {
                reverseWord += letter;
            }

            if(wordWES == reverseWord)
                return true;

            return false;
        }
    }
}
