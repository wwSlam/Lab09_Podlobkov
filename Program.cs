int totalExercieses = 1;

for (int number = 8; number >= totalExercieses; number--)
{
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готова");



for (int room = 5; room <= 50; room += 5)
{
    System.Console.WriteLine($"Кабинет {room}");
}


int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        System.Console.WriteLine($"Неделя {week}, день {day}");
    }
    Console.WriteLine("_________________");
}


int total = 0;

for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        total += 1;
        continue;
    }
    System.Console.WriteLine($"Первый доступный билет: {ticket}");
    break;
}
System.Console.WriteLine($" билетов было пропущенно: {total}");



