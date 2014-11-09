using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 20; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("Podaj liczbę naturalną");
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Miała być liczba naturalna...");
                }
                for (int i = 1; i <n+1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("O");
                    }
                   
                   Console.WriteLine();
               }
           
            }
            catch
            {
                Console.Write("Podałeś niepoprawny znak");
            }
            
            Console.WriteLine();
            Console.WriteLine("Podaj szerokość");
            string sz=Console.ReadLine();
            Console.WriteLine("Podaj wysokość");
            string wy = Console.ReadLine();

            try {
                int sze = int.Parse(sz);
                int wys = int.Parse(wy);
                if (sze < 0 | wys < 0) { Console.WriteLine("Już nie chce mi się pisać, niech będzie cokolwiek"); }
                else{
                    for (int i = 0; i < wys; i++){
                        for (int j = 0; j < sze; j++){
                            if (i == 0 | i == wys - 1){
                                Console.Write("X");}
                            else {
                                if (j == 0 | j == sze - 1){
                                    Console.Write("X");}
                                else{
                                    Console.Write(" ");}
                            }
                        }
                        Console.WriteLine();
                    }
                }
                }
            catch { 
                 Console.WriteLine("To nie jest dobry pomysł...");
            }

            Console.WriteLine();
            Console.WriteLine("Podaj wielkość literki A");
            try
            {
                int wiel = int.Parse(Console.ReadLine());
                if (wiel < 5) { Console.WriteLine("Podano za małą wysokość"); }
                else
                {
                    int s = 2 * (wiel - 1);
                    int pol=(int)Math.Ceiling((double)s/2);
                    int pw=(int)Math.Ceiling((double)wiel/2);
                    for (int i = 0; i < wiel; i++)
                    {
                        for (int j = 0; j < pol-i; j++) {
                            Console.Write(" "); }


                        for (int j = pol-i; j < pol+i+1; j++)
                        {
                            if (i == pw)
                            {
                                Console.Write("A");   
                            }
                            else
                            {
                                if (j == pol - i | j == pol + i) { Console.Write("A"); }
                                else { Console.Write(" "); }
                            } 
                        }
                        Console.WriteLine();
                    }   
                }
                }
            catch
            {
                Console.WriteLine("To nie jest dobry pomysł...");
            }

            Console.WriteLine();
            Console.WriteLine("Podaj wysokość literki L");
            string wyl = Console.ReadLine();
            Console.WriteLine("Podaj szerokość literki L");
            string sl = Console.ReadLine();
            Console.WriteLine("Podaj grubość literki L");
            string gl = Console.ReadLine();
            try
            {
                int szl = int.Parse(sl);
                int wysl = int.Parse(wyl);
                int grl = int.Parse(gl);
                if(szl>wysl){Console.Write("To nie tetris!");}
                else if(grl > wysl | grl > szl) { Console.Write("Takie mutanty nie istnieją...Za dużo picia");}
                else { 
                for (int i = 0; i < wysl-grl; i++){
                    for (int j = 0; j < grl; j++) { Console.Write("L"); }
                    Console.WriteLine();
                }

                for (int i = wysl - grl; i < wysl; i++)
                {
                    for (int j = 0; j < szl; j++) { Console.Write("L"); }
                    Console.WriteLine();
                }
                }
            }
            catch
            {
                Console.WriteLine("To nie jest dobry pomysł...");
            }
                Console.ReadKey();


        }
    }
}
