Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number < 100) {
    Console.WriteLine("третьей цифры нет");
}

else {
    while (number > 999) {
    number = number / 10;    
    }
    Console.WriteLine($"-> {number % 10}");
}