List<int> list = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };

int Kalontarin = list.Max();
System.Console.WriteLine($"Adadi Kalontarin: { Kalontarin} ");


System.Console.WriteLine("_________________________________________");


list.Sort();
System.Console.Write("Raqamho bo tartibi afzoish: ");
foreach (var item in list)
{
    System.Console.Write(item + " ");
}

System.Console.WriteLine("\n_________________________________________");


for (int i = 0; i < list.Count; i++)
{
    if (list[i] < 0)
    {
        list[i] = 0;
    }
}

System.Console.Write("\nRaqamhoi manfi == 0 : ");
foreach (var num in list)
{
    System.Console.Write(num + " ");
}
