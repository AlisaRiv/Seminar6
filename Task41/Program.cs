//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Задача 41");
int m = 5;
int[] a = new int[m];
int counter = 0;
for (int i=0; i<m; i++) {
    Console.Write("Ведите число {0} из {1}: ", i+1, m);
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) {
        counter++;
    }
    a[i] = number;
}
bool isFirst = true;
Console.Write("[");
for (int i=0; i<m; i++) {
    string prefix = isFirst ? "" : ", ";
    if (isFirst) {
        isFirst = false;
    }
    Console.Write($"{prefix}{a[i]}");
}
Console.WriteLine("] -> {0}", counter);
