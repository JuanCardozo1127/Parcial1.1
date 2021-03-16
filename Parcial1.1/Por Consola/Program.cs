using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String ejemplo = "12 2568 368 120";
            char[] delimitador = { ' ' };
            string[] trozos = ejemplo.Split(delimitador);
            int i;
            for (i=0; i< trozos.Length; i++)
            {
                Console.WriteLine("Fragmento {0} = {1}", (i + 1), trozos[i]);
            }
           int temporal = Int16.Parse(trozos[0]);
           int temporal1 = Int16.Parse(trozos[1]);
           int temporal2 = Int16.Parse(trozos[2]);
           int temporal3 = Int16.Parse(trozos[3]);

           int suma = temporal + temporal1 + temporal2 + temporal3;
            Console.WriteLine(suma);
            Console.ReadKey();


        }
    }
}
