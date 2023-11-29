using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Module2Lesson8tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie nr 1
            //Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
            //Console.WriteLine("Zadanie nr 1\n");
            //Console.WriteLine("Ponizej program wyswietli ilosc liczb pierwszych w zakresie 0-100:");
            //int a = 0;
            //while (a < 101)
            {

            }

            //Zadanie nr 2
            //Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
            Console.WriteLine("\nZadanie nr 2\n");
            Console.WriteLine("Program wyswietli wszystkie liczby parzyste w zakresie 0-1000:");
            int a2 = 0;
            do
            {
                if (a2 == 0)
                {
                    a2++;
                }
                else if ((a2 % 2) == 0)
                {
                    Console.Write($" {a2}");
                    a2++;
                }
                else
                {
                    a2++;
                }
            }
            while (a2 < 1001);

                //Zadanie nr 3
                //Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
                Console.WriteLine("\nZadanie nr 3\n");
            Console.WriteLine("Podaj ilosc wartosci ciag Fibonacciego ktore chcesz wyswietlic:");
            string userInput3 = Console.ReadLine();
            int x3;
            int ax3 = 0;
            int.TryParse(userInput3, out x3);
            int a3 = 1;
            int b3 = 1;

            while (a3 < x3)
            {
                int c3 = b3 + a3;
                Console.WriteLine($"{b3}");
                Console.WriteLine($"{a3}");
                Console.WriteLine($"{c3}");
                b3 = a3 + c3;
                a3 = c3 + b3;
            }

            //Zadanie nr 4
            //Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            Console.WriteLine("\nZadanie nr 4\n");
            Console.WriteLine("Podaj liczbe calkowita do ktorej zbudujemy piramide:");
            int userInput4 = int.Parse(Console.ReadLine());
            int loop4 = userInput4 + 1;
            int a4 = 1;
            int b4 = 0;
            int c4 = 0;

            do
            {
                if (b4 == c4)
                {
                    b4 = b4 - b4;
                    Console.WriteLine($"{a4} ");
                    a4++;
                    c4++;
                }
                else
                {
                    Console.Write($"{a4} ");
                    a4++;
                    b4++;
                }
            }
            while (a4 < loop4);



            //Zadanie nr 5
            //Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            //Zadanie nr 6
            //Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + ½ +1 / 3 + ¼ itd.

            //Zadanie nr 7
            //Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
            //    *
            //   ***
            //  *****
            // *******
            //*********
            // *******
            //  *****
            //   ***
            //    *

            //Zadanie nr 8
            //Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.
            //Np.Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba

            //Zadanie nr 9
            //Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

            //Zadanie nr 10
            //Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.



        } 
  
    }

 }


