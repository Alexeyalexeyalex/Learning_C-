Console.Write("Введите ваше имя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ураааа ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}