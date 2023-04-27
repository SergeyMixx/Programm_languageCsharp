Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine()); 
int index = 2;
while (index < n) {
    Console.Write ($"{index}");
    index = index + 2;
    if (index < n) {
        Console.Write (", ");
    }
}


