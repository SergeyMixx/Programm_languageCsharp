Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine()); 

if (polindr (num) == true) Console.WriteLine("да");
else Console.WriteLine("нет");

bool polindr (int number)
{
int numberFirstTwo = number / 1000;
int numberLastTwo = number % 10 * 10 + number / 10 % 10;

if (numberFirstTwo == numberLastTwo) return true;

else return false;
}