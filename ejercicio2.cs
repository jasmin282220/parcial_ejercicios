using System;

namespace ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            double precioProducto, efec, tar, pag;

            Console.WriteLine("ingrese el precio del producto a pagar");
            precioProducto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Diga que forma usted quiere pagar:");
            Console.WriteLine("Efectivo marque 1");
            Console.WriteLine("Tarjeta marque 2");
            pag = Convert.ToDouble(Console.ReadLine());

            if (pag == 1)
            {
                Console.WriteLine("Usted ha elegido el  pago en efectivo:");
                Console.WriteLine("ingrese el monto");
                efec = Convert.ToDouble(Console.ReadLine());
                if (efec > 0)
                {
                    Console.WriteLine("El monto ingresado es positivo");
                }
                else { Console.WriteLine("El monto ingresado es negativo"); }
            }
            else if (pag == 2)
            {

                Console.WriteLine("Usted ha elegido el pago por tarjeta:");
                Console.WriteLine("Digite el numero de la tarjeta");
                tar = Convert.ToDouble(Console.ReadLine());


                if ((tar >= 100000000000) && (tar <= 199999999999))
                {
                    ;
                    Console.WriteLine("");


                }
                else
                {
                    Console.WriteLine("Faltan dígitos o digitó de más");
                }
                if (tar > 0)
                {

                    Console.WriteLine("El pago es positivo");
                }
                else { Console.WriteLine("El pago es negativo"); }
            }
            else { Console.WriteLine("Error la opción que usted ingresó, no se encuentra disponible."); }

            Console.ReadKey();

        }
    }
}


