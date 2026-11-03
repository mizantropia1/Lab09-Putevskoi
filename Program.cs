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
