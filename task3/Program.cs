Console.Clear();
Console.WriteLine("Программа определения диапозон величин четвертей координат."); 
Console.WriteLine("Введите номер четверти(от 1 до 4):"); 
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1) {
Console.WriteLine("Вы выбрали первую четверть");
Console.WriteLine("Максимальное значение X от 0 до бесконечности.");
Console.WriteLine("Максимальное значение Y от 0 до бесконечности.");
} else if (a == 2) {
Console.WriteLine("Вы выбрали вторую четверть");
Console.WriteLine("Максимальное значение X от 0 до минус бесконечность.");
Console.WriteLine("Максимальное значение Y от 0 до бесконечности.");
} else if (a == 3) {
Console.WriteLine("Вы выбрали третью четверть");
Console.WriteLine("Максимальное значение X от 0 до минус бесконечность.");
Console.WriteLine("Максимальное значение Y от 0 до минус бесконечность.");
} else if (a == 4) {
Console.WriteLine("Вы выбрали четвертую четверть");
Console.WriteLine("Максимальное значение X от 0 до бесконечности.");
Console.WriteLine("Максимальное значение Y от 0 до минус бесконечность."); 
} else {
Console.WriteLine("Ошибка выбора четверти. Пожалуйста, повторите попытку.");
}

