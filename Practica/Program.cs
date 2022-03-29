using System;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Punto 1
                int num = new Random().Next(0, 1000);
                string text = num > 500 ? "Greater than 500" : "Less than";
                Console.WriteLine(text);

                //Punto 2
                string? myString = null;
                //myString == null ? throw new CustomException("") : Console.WriteLine("Valid value");
                if (myString != null) throw new CustomException("cayo en mi exception perosnalizada master!!!");
                else Console.WriteLine("Valor valido");


                //Punto 3
                var anonymousObj = new
                {
                    Name = string.Empty,
                    Age = 0
                };
                Console.WriteLine(anonymousObj);

                dynamic dynamicObj = 1;
                Console.WriteLine(dynamicObj);
                dynamicObj = "soy una cadena";
                Console.WriteLine(dynamicObj);
                dynamicObj = new
                {
                    day = 29,
                    month = "March",
                    year = DateTime.Now.Year
                };
                Console.WriteLine(dynamicObj);

                //Punto 4
                Map<AbstrackDaughter> map = new();
                map[0] = new AbstrackDaughter("1", "puedo ser lo que sea porque soy dynamic");
                map[1] = new AbstrackDaughter("2", 900);
                map[2] = new AbstrackDaughter("3", DateTime.Now);

                    //Se demuestra que el index por indice entero funciona correctamente
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Key:{map[i].key}, Value:{map[i].value}");
                }

                    //Acceso al arreglo mediante cadena dentro del rango
                Console.WriteLine($"Key:{map["2"]}, Value:{map["2"].value}");

                    //Acceso al arreglo mediante cadena fuera de rango y cae en excepcion personalizada
                //descomentar
               // Console.WriteLine(map["10"]);
                                
                //Punto 5
                Console.WriteLine($"Extention Method first value: {map.GetFirstElement().value}");

                //Punto 6
                string[] texts = { "hola", "Hola", "Hola123", "Holas1234", "Hola1234"};
 
                for(int i = 0; i<texts.Length; i++)
                {
                    Console.WriteLine($"{texts[i]} --> {texts[i].CustomValidation()}");
                }

            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex);
            }



        }        
    }
}
