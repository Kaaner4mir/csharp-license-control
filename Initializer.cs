using System.Text;

class Initializer
{
    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "🛂 License Control";
		try
		{
            Console.Write("Enter your minimum age: ");
            short minAge = Convert.ToInt16(Console.ReadLine());

            Console.Write("Please enter your age in the format day.month.year: ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (age < minAge)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n❌ You are not of legal age.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n✅ You are of legal age.");
                Console.Clear();
            }
        }
		catch (FormatException ex)
		{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n⚠️ An error occured: {ex.Message}");
            Console.ResetColor();
		}
            


    }
}