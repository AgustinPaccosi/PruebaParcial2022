using System;

namespace PruebaParcial2022
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("En este programa ingresando Horas, Minutos y Segundo se acoplara y se dara el horario correcto");
                Console.WriteLine("Se le pide que ingrese numeros enteros, ingrese horas entre 0 y 12");
                var horas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los minutos");
                var minutos = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los Segundos");
                var segundos = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese si corresponden a (PM) o (AM) ");
                var parte = (Console.ReadLine().ToUpper());
                if (Horario24(parte) && Verifica(horas, minutos, segundos))
                {
                    Console.WriteLine($"Se muestra el Horario formato 12: {Verificanum(horas,minutos,segundos)}  {parte}");
                    horas = horas + 12;
                    //Console.WriteLine($"Se muestra el Horario formato 24: {horas}:{minutos}:{segundos} {parte}");
                    Console.WriteLine($"El horario Formato 24 es tambien: {Verificanum(horas,minutos,segundos)}.  ");
                }
                else
                {
                    if (Verifica(horas, minutos, segundos))
                    {
                        Console.WriteLine($"Se muestra el Horario formato 12: {Verificanum(horas,minutos,segundos)} {parte}");
                        Console.WriteLine($"Se muestra el Horario formato 24: {Verificanum(horas,minutos,segundos)}. ");
                    }
                    else
                    {
                        Console.WriteLine("Los valores Ingresados no son validosssss");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Los valores Ingresados O no son Enteros O no son Numeros");
            }

        }
        private static bool Horario24(string parte)
        {
            if (parte == "PM")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool Verifica(int horas, int minutos, int segundos)
        {
            if ((horas >= 0) && (horas <= 12) && (minutos >= 0) && (minutos < 60) && (segundos >= 0) && (segundos < 60))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static string Verificanum(int horas, int minutos, int segundos)
        {
            //if (horas<10 || minutos<10 || segundos<10)
            //{
                var msj = horas.ToString().PadLeft(2, '0')+":"+ minutos.ToString().PadLeft(2, '0') +":"+ segundos.ToString().PadLeft(2, '0');
                return msj;
            //}

        }

    }
}
