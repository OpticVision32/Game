Console.WriteLine("Введите имя первого игрока: ");
string name1 = Console.ReadLine() ?? "";
Console.WriteLine("Введите второго игрока: ");
string name2 = Console.ReadLine() ?? "";

int Gamer = new Random().Next(0, 2);
int GameLenght = 9;
int GameStep = 0;

if (Gamer == 0)
{
    Console.WriteLine($"Ходит {name1} ");
}
else
{
    Console.WriteLine($"Ходит {name2} ");
}

void PrintArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < array.Length)
    {
        Console.Write($"{array[index]}    ");
        index++;
    }
}

int[] arrayOne = new int[3];
int[] arrayTwo = new int[3];
int[] arrayThree = new int[3];

void PrintGameField()
{
    PrintArray(arrayOne);
    Console.WriteLine(" ");
    PrintArray(arrayTwo);
    Console.WriteLine(" ");
    PrintArray(arrayThree);
    Console.WriteLine(" ");
}

    void StepGamer(int step)
{
        if (Gamer == 1)
        {
        if (step == 1 && arrayOne[0] == 0)
        {
            arrayOne[0] = 2;
            GameStep++;
            Gamer--;
        }
        else if (step == 2 && arrayOne[1] == 0)
        {
            arrayOne[1] = 2;
            GameStep++;
            Gamer--;
        }
        else if (step == 3 && arrayOne[2] == 0)
        {
            arrayOne[2] = 2;
            GameStep++;
            Gamer--;
        }
        else if (step == 4 && arrayTwo[0] == 0)
        {
            arrayTwo[0] = 2;
            GameStep++;
            Gamer--;
        }
        else if (step == 5 && arrayTwo[1] == 0)
        {
            arrayTwo[1] = 2;
            GameStep++;
            Gamer--;
        }
        else if (step == 6 && arrayTwo[2] == 0)
        {
            arrayTwo[2] = 2;
            GameStep++;
            Gamer--;
        }
        else if (step == 7 && arrayThree[0] == 0)
        {
            arrayThree[0] = 2;
            GameStep++;
            Gamer--;
        }
        else if (step == 8 && arrayThree[1] == 0)
        {
            arrayThree[1] = 2;
            GameStep++;
            Gamer--;
        }
        else if (step == 9 && arrayThree[2] == 0)
        {
            arrayThree[2] = 2;
            GameStep++;
            Gamer--;
        }
        else
        {
            Console.WriteLine("Вы ввели неверное число");
        }
    }
    else if (step == 1 && arrayOne[0] == 0)
        {
            arrayOne[0] = 1;
            GameStep++;
            Gamer++;
        }
        else if (step == 2 && arrayOne[1] == 0)
        {
            arrayOne[1] = 1;
            GameStep++;
            Gamer++;
        }
        else if (step == 3 && arrayOne[2] == 0)
        {
            arrayOne[2] = 1;
            GameStep++;
            Gamer++;
        }
        else if (step == 4 && arrayTwo[0] == 0)
        {
            arrayTwo[0] = 1;
            GameStep++;
            Gamer++;
        }
        else if (step == 5 && arrayTwo[1] == 0)
        {
            arrayTwo[1] = 1;
            GameStep++;
            Gamer++;
        }
        else if (step == 6 && arrayTwo[2] == 0)
        {
            arrayTwo[2] = 1;
            GameStep++;
            Gamer++;
        }
        else if (step == 7 && arrayThree[0] == 0)
        {
            arrayThree[0] = 1;
            GameStep++;
            Gamer++;
        }
        else if (step == 8 && arrayThree[1] == 0)
        {
            arrayThree[1] = 1;
            GameStep++;
            Gamer++;
        }
        else if (step == 9 && arrayThree[2] == 0)
        {
            arrayThree[2] = 1;
            GameStep++;
            Gamer++;
        }
        else
        {
            Console.WriteLine("Вы ввели неверное число");

        }
    {

    }
}

PrintGameField();

while (GameStep < GameLenght)
{
    if (Gamer == 0)
    {
        Console.WriteLine($"{name1} Введите число от 1 до 9, введенное число соответствует клетке поля: ");

        int step = Convert.ToInt32(Console.ReadLine());
        StepGamer(step);
        PrintGameField();
        if ((arrayOne[0] == 1 && arrayOne[1] == 1 && arrayOne[2] == 1) || (arrayTwo[0] == 1 && arrayTwo[1] == 1 && arrayTwo[2] == 1) || (arrayThree[0] == 1 && arrayThree[1] == 1 && arrayThree[2] == 1) || (arrayOne[0] == 2 && arrayOne[1] == 2 && arrayOne[2] == 2) || (arrayTwo[0] == 2 && arrayTwo[2] == 1 && arrayTwo[2] == 2) || (arrayThree[0] == 2 && arrayThree[1] == 2 && arrayThree[2] == 2) || (arrayOne[0] == 1 && arrayTwo[1] == 1 && arrayThree[2] == 1) || (arrayOne[2] == 1 && arrayTwo[1] == 1 && arrayThree[0] == 1) || (arrayOne[0] == 2 && arrayTwo[1] == 2 && arrayThree[2] == 2) || (arrayOne[2] == 2 && arrayTwo[1] == 2 && arrayThree[0] == 2) || (arrayOne[0] == 1 && arrayTwo[0] == 1 && arrayThree[0] == 1) || (arrayOne[1] == 1 && arrayTwo[1] == 1 && arrayThree[1] == 1) || (arrayOne[2] == 1 && arrayTwo[2] == 1 && arrayThree[2] == 1) || (arrayOne[0] == 2 && arrayTwo[0] == 2 && arrayThree[0] == 2) || (arrayOne[1] == 2 && arrayTwo[1] == 2 && arrayThree[1] == 2) || (arrayOne[2] == 2 && arrayTwo[2] == 2 && arrayThree[2] == 2))
        {
            System.Console.WriteLine($"{name1} Вы победили!");
            break;
        }
    }
    else
    {
        Console.WriteLine($"{name2} Введите число от 1 до 9, введенное число соответствует клетке поля: ");
        int step = Convert.ToInt32(Console.ReadLine());
        StepGamer(step);
        PrintGameField();if ((arrayOne[0] == 1 && arrayOne[1] == 1 && arrayOne[2] == 1) || (arrayTwo[0] ==  1 && arrayTwo[1] == 1 && arrayTwo[2] == 1) || (arrayThree[0] == 1 && arrayThree[1] == 1 && arrayThree[2] == 1) || (arrayOne[0] == 2 && arrayOne[1] == 2 && arrayOne[2] == 2) || (arrayTwo[0] == 2 && arrayTwo[2] == 1 && arrayTwo[2] == 2) || (arrayThree[0] == 2 && arrayThree[1] == 2 && arrayThree[2] == 2) || (arrayOne[0] == 1 && arrayTwo[1] == 1 && arrayThree[2] == 1) || (arrayOne[2] == 1 && arrayTwo[1] == 1 && arrayThree[0] == 1) || (arrayOne[0] == 2 && arrayTwo[1] == 2 && arrayThree[2] == 2) || (arrayOne[2] == 2 && arrayTwo[1] == 2 && arrayThree[0] == 2) || (arrayOne[0] == 1 && arrayTwo[0] == 1 && arrayThree[0] == 1) || (arrayOne[1] == 1 && arrayTwo[1] == 1 && arrayThree[1] == 1) || (arrayOne[2] == 1 && arrayTwo[2] == 1 && arrayThree[2] == 1) || (arrayOne[0] == 2 && arrayTwo[0] == 2 && arrayThree[0] == 2) || (arrayOne[1] == 2 && arrayTwo[1] == 2 && arrayThree[1] == 2) || (arrayOne[2] == 2 && arrayTwo[2] == 2 && arrayThree[2] == 2))
        {
            System.Console.WriteLine($"{name2} Вы победили!");
            break;
        }
        
    }
}




