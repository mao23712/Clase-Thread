using System;
using System.Threading;

public class Hilo
{
    private string mensaje;
    private Thread hilo;

    public Hilo(string mensaje)
    {
        this.mensaje = mensaje;
        hilo = new Thread(new ThreadStart(this.Run));
    }

    public void Start()
    {
        hilo.Start();
    }

    public void Join()
    {
        hilo.Join();
    }

    public void Run()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(mensaje);
            Thread.Sleep(1000);
        }
    }
}