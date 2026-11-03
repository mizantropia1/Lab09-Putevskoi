Console.WriteLine();
Console.WriteLine("Шаг 1. Исходный код.");
int totalExercises = 8;

for (int number = 1; number <= totalExercises; number++) {
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");



Console.WriteLine();
Console.WriteLine("Шаг 1. В обратном порядке.");
int totalExercises2 = 8;

for (int number2 = totalExercises2; number2 >= 1; number2--) {
    Console.WriteLine($"Упражнение {number2}");
}

Console.WriteLine("Домашнее задание готово");



Console.WriteLine();
Console.WriteLine("Шаг 2. Исходный код.");
for (int room = 2; room <= 20; room += 2) {
    Console.WriteLine($"Кабинет {room}");
}



Console.WriteLine();
Console.WriteLine("Шаг 2. Кратные пяти, от 5 до 50.");
for (int room = 5; room <= 50; room += 5) {
    Console.WriteLine($"Кабинет {room}");
}



Console.WriteLine();
Console.WriteLine("Шаг 3. Исходный код.");
int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++) {
    for (int day = 1; day <= 5; day++) {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
}



Console.WriteLine();
Console.WriteLine("Шаг 3. Дополнительная строка-разделитель.");
int totalWeeks2 = 3;

for (int week2 = 1; week2 <= totalWeeks2; week2++) {
    for (int day2 = 1; day2 <= 5; day2++) {
        Console.WriteLine($"Неделя {week2}, день {day2}");
    }

    Console.WriteLine("^_^");
}



Console.WriteLine();
Console.WriteLine("Шаг 4. Исходный код.");
for (int ticket = 1; ticket <= 30; ticket++) {
    if (ticket == 4 || ticket == 12 || ticket == 19) {
        continue;
    }

    Console.WriteLine($"Первый доступный билет: {ticket}");
    break;
}



Console.WriteLine();
Console.WriteLine("Шаг 4. Счётчик пропущенных билетов.");
int skipped2 = 0;

for (int ticket2 = 1; ticket2 <= 30; ticket2++) {
    if (ticket2 == 1 || ticket2 == 2 || ticket2 == 3) {
        skipped2++;
        continue;
    }

    Console.WriteLine($"Первый доступный билет: {ticket2}, пропущено билетов: {skipped2}");
    break;
}



Console.WriteLine();
Console.WriteLine("Шаг 5. Исходный код.");
for (; ; ) {
    Console.Write("Введите код группы (для выхода — «выход»): ");
    string groupCode = Console.ReadLine();

    if (groupCode == "выход") {
        break;
    }

    Console.WriteLine($"Записан код группы: {groupCode}");
}

Console.WriteLine("Работа с журналом завершена");



Console.WriteLine();
Console.WriteLine("Задача А.");
int N = 15;

for (int i1 = 1; i1 <= N; i1 += 2) {
    Console.WriteLine(i1);
}



Console.WriteLine();
Console.WriteLine("Задача Б.");
for (int i2 = 100; i2 >= 0; i2 -= 10) {
    Console.WriteLine(i2);
}



Console.WriteLine();
Console.WriteLine("Индивидуальный вариант.");
Console.Write("Введите свою фамилию: "); 
string surname = Console.ReadLine()!.Trim(); 
if (string.IsNullOrEmpty(surname)) { 
Console.WriteLine("Фамилия не введена. Завершение работы."); 
return; 
} 
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
var assigned = Enumerable.Range(1, 10) 
.OrderBy(_ => rnd.Next()) 
.Take(2) 
.OrderBy(x => x) 
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 



Console.WriteLine();
Console.WriteLine("Вариант 5.");
for (int i3 = 1; i3 <= 100; i3++) {
    if (i3 % 3 == 0 && i3 % 5 == 0) {
        Console.WriteLine($"Первое число, кратное 3 и 5: {i3}");
        break;
    }
}



Console.WriteLine();
Console.WriteLine("Вариант 6.");
for (int i4 = 1; i4 <= 30; i4++) {
    if (i4 % 4 == 0) {
        continue;
    }

    Console.WriteLine(i4);
}



