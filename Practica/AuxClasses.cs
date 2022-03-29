using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica
{
    internal class CustomException : NullReferenceException
    {
        public CustomException() { }
        public CustomException(string message) : base(message) { }
        public CustomException(string message, Exception innerException) : base(message, innerException) { }

    }
    public abstract class MyAbstractClass
    {
        public string key;
        public dynamic value;
    }

    public class Map<T> where T : MyAbstractClass
    {
        private T[] arr = new T[3];
        private string[] indexes = {"1", "2", "3"};

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public T this[string s]
        {
            get {
                if (indexes.Contains(s)) return arr[Array.IndexOf(indexes, s)];
                else throw new CustomException("No hay nada master");  
            }
        }
    }

    public class AbstrackDaughter : MyAbstractClass
    {
        public AbstrackDaughter(string key, dynamic value) 
        {
            this.key = key;
            this.value = value;
        }
    }

    public static class MyExtention
    {
        public static AbstrackDaughter GetFirstElement(this Map<AbstrackDaughter> map)//this es lo que lo vuelve extention method
        {
            return map[0];
        }

        public static Boolean CustomValidation(this String str)
        {
            string pattern = @"[A-Z]{1}[a-z]{3}[0-9]{4}";
            Regex regex = new(pattern);
            bool valida = regex.IsMatch(str);
            return valida;
        }
    }

}
