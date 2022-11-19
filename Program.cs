// See https://aka.ms/new-console-template for more information

using System;

namespace Cronometro
{
 public class Program
    {
     public static void Main(string[] args)
        {
          Menu();

        }
       static void Menu()
            {
               Console.WriteLine("S = Segundo => 10s = 10 segundos");
               Console.WriteLine("M = minuto => 1m = 1 minuto");
               Console.WriteLine("0 = Sair");
               Console.WriteLine("Quanto tempo deseja contar?");

               string data = Console.ReadLine().ToLower();
              
               char type = char.Parse(data.Substring(data.Length - 1,1));
               int time = int.Parse(data.Substring(0, data.Length - 1));
               int multiplicar = 1;

                if(type == 'm')
             multiplicar =  60;
                if (time == 0)
                System.Environment.Exit(0);

                PreStart(time * multiplicar);
            

           static void PreStart(int time){

            Console.Clear();
             Console.WriteLine("preparar...");
             Thread.Sleep(1000);
             Console.WriteLine("apontar...");
             Thread.Sleep(1000);
             Console.WriteLine("já...");
             Thread.Sleep(2500);

             Start(time);
           }
           static void Start(int time){
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado");
            Thread.Sleep(2500);
            Menu();

           }

            }  
    }
}