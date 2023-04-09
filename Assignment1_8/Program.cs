static bool check(string stroka)
{
    if (stroka.Length == 0)
    {
        return false; 
    }
    else if (stroka.Length == 1)
    {
        return Char.IsDigit(stroka[0]); 
    }
    else
    {
        return Char.IsDigit(stroka[0]) && check(stroka.Substring(1));
    }
}

string stroka = Console.ReadLine();
bool result = check(stroka);

if (result == true)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}