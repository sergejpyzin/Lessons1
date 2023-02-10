Console.Write ("Введите имя пользователя: ");
string userName = Console.ReadLine ();

if (userName.ToLower () == "маша") //userName.ToLower () - перевод всех символов переменной userName в нижний регистр;
{
    Console.WriteLine ("ВАУ С НАМИ МАША!");
} 
else
{
    Console.Write ("Привет ");
    Console.WriteLine (userName);
}