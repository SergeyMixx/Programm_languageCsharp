Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string coordinates = Coordinates (quarter);

string result = coordinates == null 
    ?  "Некорректный номер"
    : $"Указанная четверть соответствует координатам -> {coordinates}";
Console.WriteLine (result);

string Coordinates (int q)
{
    if (q == 1) return "x > 0, y > 0";
    if (q == 2) return "x < 0, y > 0";
    if (q == 3) return "x < 0, y < 0";  
    if (q == 4) return "x > 0, y < 0";
    return null;  
}