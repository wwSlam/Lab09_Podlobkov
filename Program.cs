// int totalExercieses = 1;

// for (int number = 8; number >= totalExercieses; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готова");



// for (int room = 5; room <= 50; room += 5)
// {
//     System.Console.WriteLine($"Кабинет {room}");
// }


// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     for (int day = 1; day <= 5; day++)
//     {
//         System.Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("_________________");
// }


// int total = 0;

// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         total += 1;
//         continue;
//     }
//     System.Console.WriteLine($"Первый доступный билет: {ticket}");
//     break;
// }
// System.Console.WriteLine($" билетов было пропущенно: {total}");


// for (; ; ) {
//     Console.Write("Введите код группы (для выхода — «выход»): ");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "выход") {
//         break;
//     }

//     Console.WriteLine($"Записан код группы: {groupCode}");
// }

// Console.WriteLine("Работа с журналом завершена");


// Console.WriteLine("Задание А");
// Console.Write("Введите число: ");   // задание A
// int svw = int.Parse(Console.ReadLine());

// for (int chislo = 1; chislo <= svw; chislo += 2)
// {
//     System.Console.WriteLine(chislo);
// }


// Console.WriteLine("Задание Б");
// for (int i = 100; i >= 0; i -= 10) 
// {
//     System.Console.WriteLine(i);
// }


// Console.WriteLine();
// Console.WriteLine("Задание В");

// Console.Write("Введите число: ");
// int chisloo = int.Parse(Console.ReadLine());

// for (int i = 1; i <= 9; i++)
// {
//     System.Console.WriteLine($"{chisloo} * {i} = {chisloo * i}"); 
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


Console.WriteLine();
System.Console.WriteLine("Задание 7");

Console.Write("Введите первое число: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());


for (int i = 1; i <= 5; i++)
{
    System.Console.WriteLine($"{num} + {i} = {num + i}");
    for (int d = 1; d <= 5; d++)
    {
        System.Console.WriteLine($"{num2} + {d} = {num2 + d}");
    }
}
System.Console.WriteLine($"{num} + {num2} = {num + num2}");


Console.WriteLine();
Console.WriteLine("Задание 9");

Console.Write("Введите число: ");
int chislo = int.Parse(Console.ReadLine());
int total = 0;

for (int i = 1; i <= chislo; i++)
{
    if (i % 5 == 0)
    {
        continue;
    }
    else
    {
        total += i;
    }
}
System.Console.WriteLine(total);


