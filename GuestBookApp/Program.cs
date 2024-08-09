//Спросить пользователя его фамилию и количество людей
//Определить количество людей на празднике
//Вывести список госте и  полное их количество

using System.Collections;
using System.Threading.Channels;

internal class Program
{
  private static void Main(string[] args)
  {
    Dictionary<string, uint> setOfGuest = BookGuest();

    uint total = GetTotal(setOfGuest);

    Console.WriteLine($"\nВсего на празднике гостей: {total}");

    PrintGuestList(setOfGuest);

    return;
  }

  public static void PrintGuestList(Dictionary<string, uint> listOfGuest) {
    Console.WriteLine("Список гостей: ");
    foreach (var item in listOfGuest)
    {
      Console.WriteLine($"{item.Key} - {item.Value}");
    }
  }
  public static uint GetTotal(Dictionary<string, uint> setOfGuest) {

    uint total = 0;
    foreach (var item in setOfGuest)
    {
      total += item.Value;
    }
    return total;
  }
  public static Dictionary<string, uint> BookGuest() {
    Console.WriteLine("      Guest Book");
    Console.WriteLine("-------------------------");
    char c;
    string? lastName = string.Empty;
    uint count;
    Dictionary<string, uint> setOfGuest = new Dictionary<string, uint>();

    do
    {
      Console.WriteLine("Введите фамилию: ");
      lastName = Console.ReadLine();
      Console.WriteLine("Введите количество людей: ");
      count = Convert.ToUInt16(Console.ReadLine());
      if (lastName != null)
      {
        setOfGuest.Add(lastName, count);
      }
      Console.WriteLine("Для выхода нажмите 'q' или другую клавишу для продолжения ввода");
    } while ((c = Console.ReadKey().KeyChar) != 'q');

    return setOfGuest;
  }
}