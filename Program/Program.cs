Console.WriteLine("Введите через пробел любые элементы массива");
string s = Console.ReadLine();
string[] line = s.Split(' ');
string[] array = new string[line.Length];

void ThreeCharElements(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = line[i];
        if (array[i].Length <= 3)
            Console.Write($"{array[i]} ");
    }
}
ThreeCharElements(array);