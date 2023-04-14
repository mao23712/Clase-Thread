using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Hilo hilo1 = new Hilo("Soy el hilo 1");
        Hilo hilo2 = new Hilo("Soy el hilo 2");
        Hilo hilo3 = new Hilo("Soy el hilo 3");

        hilo1.Start();
        hilo2.Start();
        hilo3.Start();

        hilo1.Join();
        hilo2.Join();
        hilo3.Join();

        Console.WriteLine("Todos los hilos han terminado");
        Console.ReadKey();
    }
}





