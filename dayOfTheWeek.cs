Console.WriteLine("Введите номер дня недели");
weekDay:
int dayNumber = Convert.ToInt32(Console.ReadLine());
switch(dayNumber)
{
    case 1:
    Console.WriteLine("Не выходной");
    break;

    case 2:
    Console.WriteLine("Не выходной");
    break;
    
    case 3:
    Console.WriteLine("Не выходной");
    break;

    case 4:
    Console.WriteLine("Не выходной");
    break;

    case 5:
    Console.WriteLine("Не выходной");
    break;

    case 6:
    Console.WriteLine("Выходной!");
    break;

    case 7:
    Console.WriteLine("Выходной!");
    break;

    default:
    Console.WriteLine("Введено некорректное число. Введите другое число");
    goto weekDay;
}