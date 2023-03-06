//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 //значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("Задача 43");
int m = 4;
string[] name = new string[] {"b1", "k1", "b2", "k2"};
double[] a = new double[4];
for (int i=0; i<m; i++) {
    Console.Write("Ведите число {0}: ", name[i]);
    double number = Convert.ToDouble(Console.ReadLine());
    a[i] = number;
}
double x = (a[2]-a[0])/(a[1]-a[3]);
double y = a[3]*x + a[2];
bool isFirst = true;
Console.Write("[");
for (int i=0; i<m; i++) {
    string prefix = isFirst ? "" : ", ";
    if (isFirst) {
        isFirst = false;
    }
    Console.Write($"{prefix}{name[i]} = {a[i]}");
}
Console.WriteLine("] -> ({0}; {1})", x, y);
