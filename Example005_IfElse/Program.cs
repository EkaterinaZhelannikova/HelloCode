Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "юра")
{
    Console.WriteLine("Ура, это же ЮРА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}