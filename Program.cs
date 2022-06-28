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
                var parte = ((Console.ReadLine().ToUpper)());
                if (Horario24(parte) && Verifica(horas, minutos, segundos))
                {
                    horas = horas + 12;
                    Console.WriteLine($"Se muestra el Horario {horas}:{minutos}:{segundos} {parte}");
                }
                else
                {
                    if (Verifica(horas, minutos, segundos) && Horario24(parte))
                    {
                        Console.WriteLine($"Se muestra el Horario {horas}:{minutos}:{segundos} {parte}");
                    }
                    else
                    {
                        Console.WriteLine("Los valores Ingresados no son validos");
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
            if ((horas > 0) && (horas <= 12) && (minutos > 0) && (minutos <= 60) && (segundos > 0) && (segundos <= 60))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
