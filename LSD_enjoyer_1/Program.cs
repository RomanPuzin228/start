using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        void Nazvanie()
        {
            string variable_string = "Строчка";
            int variable_int = 52;
            double variable_double = 14.88;
            bool variable_bool = true;
            char variable_char = 'z';

            //Консольный вывод
            Console.WriteLine("Строчка - " + variable_string);
            Console.WriteLine("целочисленное - " + variable_int);
            Console.WriteLine("дробный - " + variable_double);
            Console.WriteLine("логическое - " + variable_bool);
            Console.WriteLine("символьное - " + variable_char);


            //сложение 2 переменных в консоли
            Console.WriteLine(variable_int + variable_double);

            //консольный ввод и конвертация
            Console.WriteLine("Ведите инт: ");
            int xint;
            xint = int.Parse(Console.ReadLine());
            Console.WriteLine(xint + " - ваше значение");

            Console.WriteLine("Ведите строчку: ");
            string xS;
            xS = Console.ReadLine();
            Console.WriteLine(xS + " - ваше значение");

            Console.WriteLine("Ведите дробь: ");
            double xD;
            xD = double.Parse(Console.ReadLine());
            Console.WriteLine(xD + " - ваше значение");

            Console.WriteLine("Ведите бул: ");
            bool xB;
            xB = bool.Parse(Console.ReadLine());
            Console.WriteLine(xB + " - ваше значение");

            Console.WriteLine("Ведите чар: ");
            char xC;
            xC = char.Parse(Console.ReadLine());
            Console.WriteLine(xC + " - ваше значение");
        }

        void Microzaim()
        {
            int zaim = 100000;
            while (true)
            {
                Console.WriteLine("Введите сколько получили: ");
                int skam = int.Parse(Console.ReadLine());
                skam = skam - zaim;
                zaim = zaim + skam;
                if (skam >= 2000)
                {
                    Console.WriteLine("Я богат я могу не продовать почку!!!!");
                }
                else if (skam > 0)
                {
                    Console.WriteLine("Денег нет но отдал микрозаймы возьму еще(куплю аркану на врку)");
                    skam = skam - 25000;
                }
                else
                {
                    Console.WriteLine("Денег нет, надо продать семью на микрозаймы(брал что бы купить аркану на пуджа)");
                }
                Console.WriteLine("Ваш баланс: " + skam);
            }
        }

        void masiv_chikl()
        {
            int i = 0;
            //думает потом делает
            while (i < 5)
            {
                Console.WriteLine(i + " ");
                i++;

            }
            i = 0;
            //делает потом думает
            do
            {
                i++;
                Console.WriteLine(i + " ");
            } while (i < 5);
            //думаем что должно быть,он думает потом делает
            for (i = 1; i < 11; i++)
            {
                int num52 = 2;
                Console.WriteLine("2 * " + i + " = " + num52 * i);
            }

            //виды массивов
            int[] num;
            int[] num1 = new int[10];
            int[] num2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] num3 = { 5, 4, 3, 2, 1 };
            //вид n-мер массивов
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            foreach (int a in num2)
            {
                Console.WriteLine(a);
            }
            for (int b = 0; b < num2.Length; b++)
            {
                Console.WriteLine(" В ячейке под номером " + b + " храниться значение - " + num2[b]);
            };
        }

        int Square(int x , int y)
        {
            int z = x + y;
            return x * y;
        }

        double Stepen(double x)
        {
            double result = x * x;
            return result;
        }
        int factor(int x)
        {
            int x1 = x;
            for (int i = 1; i != x1; i++)
            {
                x *= i;
            }
            return x;
        }
        Console.WriteLine(factor(5));

    }
}