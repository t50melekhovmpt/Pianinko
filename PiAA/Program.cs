using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] first_octavka1 = { 178, 190, 210, 222, 230, 245, 258, 267, 280, 291, 293,324 };
                int[] second_octav = { 360, 380, 400, 420, 450, 470, 500, 525, 540, 560, 579, 640 };
                int[] third_octav = { 699, 730, 760, 792, 817, 835, 849, 869, 880, 900, 950, 1072 };
                int zn = 1000;
                Console.WriteLine("Выбирай Октаву\n");
                ConsoleKeyInfo Ef= Console.ReadKey();
                if (Ef.Key == ConsoleKey.F1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Тыкай\n");
                        Ef = Console.ReadKey();
                        if (Ef.Key == ConsoleKey.C)
                        {
                            Console.Beep(zn, first_octavka1[0]);
                        }
                        if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt)&&Ef.Key == ConsoleKey.C)
                        {
                            Console.Beep(zn, first_octavka1[1]);
                        }
                        if (Ef.Key == ConsoleKey.D)
                        {
                            Console.Beep(zn, first_octavka1[2]);
                        }
                        if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.E)
                        {
                            Console.Beep(zn, first_octavka1[3]);
                        }
                        if (Ef.Key == ConsoleKey.E)
                        {
                            Console.Beep(zn, first_octavka1[4]);
                        }
                        if (Ef.Key == ConsoleKey.F)
                        {
                            Console.Beep(zn, first_octavka1[5]);
                        }
                        if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.F)
                        {
                            Console.Beep(zn, first_octavka1[6]);
                        }
                        if (Ef.Key == ConsoleKey.G)
                        {
                            Console.Beep(zn, first_octavka1[7]);
                        }
                        if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.G)
                        {
                            Console.Beep(zn, first_octavka1[8]);
                        }
                        if (Ef.Key == ConsoleKey.A)
                        {
                            Console.Beep(zn, first_octavka1[9]);
                        }
                        if (Ef.Key == ConsoleKey.B)
                        {
                            Console.Beep(zn, first_octavka1[10]);
                        }
                        if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.B)
                        {
                            Console.Beep(zn, first_octavka1[11]);
                        }
                        Console.Clear();
                        if (Ef.Key == ConsoleKey.F2)
                        {
                            break;
                        }
                        if (Ef.Key == ConsoleKey.F3)
                        {
                            break;
                        }
                        if (Ef.Key == ConsoleKey.L)
                        {
                            Console.WriteLine("Закрыть промзведение нот из первой октавы\n");
                            break;
                        }
                    } while(Ef.Key != ConsoleKey.F1 && Ef.Key != ConsoleKey.F2 && Ef.Key != ConsoleKey.F3 && Ef.Key != ConsoleKey.Escape);
                 
                    
                }
                if (Ef.Key == ConsoleKey.F2)
                {
                    Console.Beep(zn, second_octav[0]);
                }
                if (Ef.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Всё, концерт окончен");
                    Console.ReadLine();
                    break;
                }
            }
           /* ConsoleKeyInfo persh;
            Console.WriteLine("Введи октаву пж пж\n");
            persh = Console.ReadKey();
            //ConsoleKeyInfo gav;
            //gav.Perecluchatel(persh);
            var anInstanceofProgramm = new Program();
            anInstanceofProgramm.Perecluchatel(persh);*/

        }
        /*public int[] Octavs(int [] first_octav)
        {
            int[] first_octavka1 = {178, 190 , 210, 222, 230, 245, 258, 267,280,291,293};
            int[] second_octav = {360, 380, 400,420 , 450, 470,500, 525, 540, 560, 579};
            int[] third_octav = {699, 730, 760, 792, 817,835,849,869,880,900,950};
            return first_octav;
            return second_octav;
            return third_octav;
        }
        public ConsoleKeyInfo Perecluchatel(ConsoleKeyInfo Ef)
        {
            do
            {
                int[] firAct.Octavs();
                Octavs(firAct);
                int zn = 1000; 
                Console.WriteLine("Тыкни F1/F2/F3\n");
                ConsoleKeyInfo Fray= Console.ReadKey();
                if (Fray.Key == ConsoleKey.F1)
                {
                    Console.Beep(zn, Octavs(first_octav[0]));
                }
                //Console.WriteLine(Ef.ToString());

            }while(true);

        }*/
    }
}
