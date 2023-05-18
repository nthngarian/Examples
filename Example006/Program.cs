Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "юля")
{
    Console.WriteLine("Ура, это же ЮЛЯ!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}