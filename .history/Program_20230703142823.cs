using System;
using System.Globalization;
using programas;

namespace Calculo
{
    class Program 
    { 
        static void Main (string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("entra com as medias do triangulo X");
            x.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            
            System.Console.WriteLine("entre com as medidas do triangulo Y ");
            y.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            y.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            y.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  

            double p= (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt (p *(p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p- y.A) * (p - y.B) * (p - y.C));

            if (areaX > areaY){

                System.Console.WriteLine("Maior area triangulo X");
            }
            else{
                System.Console.WriteLine("maior area trinagulo Y");
            }




        }

    }
    

}