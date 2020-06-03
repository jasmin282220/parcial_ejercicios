using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace ejercicios_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //programa dias de las semanas
            int dia;
            Console.WriteLine("ingrese un numero para saber el dia de semana");
            dia = Convert.ToInt32(Console.ReadLine());
            if (dia >0 && dia <=7)

            {
         
                
                if (dia == 1)
                    Console.WriteLine("lunes");
                if (dia == 2)
                    Console.WriteLine("martes");
                if (dia == 3)
                    Console.WriteLine("miercoles");
                if (dia == 4)
                    Console.WriteLine("jueves");
                if (dia == 5)
                    Console.WriteLine("viernes");
                if (dia == 6)
                    Console.WriteLine("sabado");
                if (dia == 7)
                    Console.WriteLine("domingo");
                sabado & domingo = Console.WriteLine("son fines de semana");
               
               
            }
            else
            {
                Console.WriteLine("Error la semana solo tiene 7 dias");
               

            }

        }
    }
}

