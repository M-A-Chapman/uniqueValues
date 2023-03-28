namespace uniqueValues;
class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();
        while (true)
        {
            Console.WriteLine("Enter a number or type Quit: ");
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else if (!numbers.Contains(Convert.ToInt32(input)))
                {
                    numbers.Add(Convert.ToInt32(input));
                }
            };
        };
        Console.WriteLine("Unique Numbers:");
        numbers.ForEach(Console.WriteLine);
    }
}
