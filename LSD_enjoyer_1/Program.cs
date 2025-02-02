
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
    xint = Int32.Parse(Console.ReadLine());
    Console.WriteLine(xint + " - ваше значение");

    Console.WriteLine("Ведите строчку: ");
    string xS;
    xS = Console.ReadLine();
    Console.WriteLine(xS + " - ваше значение");

    Console.WriteLine("Ведите дробь: ");
    double xD;
    xD = Double.Parse(Console.ReadLine());
    Console.WriteLine(xD + " - ваше значение");

    Console.WriteLine("Ведите бул: ");
    bool xB;
    xB = Boolean.Parse(Console.ReadLine());
    Console.WriteLine(xB + " - ваше значение");

    Console.WriteLine("Ведите чар: ");
    char xC;
    xC = Char.Parse(Console.ReadLine());
    Console.WriteLine(xC + " - ваше значение");

    //блаблабла 1488 статья 228
}

void microzaim_babok()
{
int zaim = 100000;
while (true)
{
    Console.WriteLine("Введите сколько получили: ");
    int skam = Int32.Parse(Console.ReadLine());
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
    Console.WriteLine("Ваш баланс: "+ skam);
}
}

