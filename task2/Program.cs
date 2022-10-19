Console.Clear();
Console.WriteLine("Программа сравнения, является ли одно число квадратом другого"); 
Console.WriteLine("Введите первое число которое нужно возвести в квадрат:"); 
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число которое является предпологаемым квадратом первого числа:"); 
int b = Convert.ToInt32(Console.ReadLine());

if (a*a == b) {
Console.WriteLine("Второе число является квадратом первого!"); 
} else {
Console.WriteLine("Второе число НЕ является квадратом первого!"); 
}