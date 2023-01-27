Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "женя")
{
    Console.WriteLine("Вау! Это же ЖЕНЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
