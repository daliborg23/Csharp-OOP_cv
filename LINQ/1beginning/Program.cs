using System.Threading.Channels;

namespace LINQbeginning;

class LINQforBeginners {
    public static void Main(string[] args) {
        List<int> numbers = new List<int>() { 45, 86, 59, 10, 3, 72, 99, 16, 87 };
        // s LINQ pouzivat vzdy var
        var sum = numbers.Sum();
        Console.WriteLine("Suma: " + sum);

        var min = numbers.Min();
        Console.WriteLine("Min: " + min);

        var max = numbers.Max();
        Console.WriteLine("Max: " + max);

        var ordered = numbers.OrderBy(x => x);
        Console.Write("Ordered: ");
        foreach (int num in ordered) 
        {
            Console.Write(num+", ");
        }
        Console.WriteLine();

        Console.Write("Ordered (desc.): ");
        numbers.OrderByDescending(num => num).ToList().ForEach(num => Console.Write(num + ", "));
        Console.WriteLine();

        var average = numbers.Average();
        Console.WriteLine("Average: " + average);

        var sumOfEven = numbers.Where(c => c % 2 == 0).Sum();
        Console.WriteLine("Sum even numbers: " + sumOfEven);

        Console.Write("Even numbers: ");
        List<int> evenNumbers = numbers.Where(num => num % 2 == 0).ToList();
        foreach (int num in evenNumbers) {
            Console.Write(num + ", ");
        }
        Console.WriteLine();

        List<string> slova = new List<string>() { "kompresor", "krtek", "vzácnost", "herečka", "kapsa", "mnich", 
            "sféra", "víla", "žurnalistika", "popelnice", "oděrka", "lekce", "bidlo", "kartička", "písmeno", 
            "kartografie", "tribuna", "dítě", "tele", "spona", "záhyb", "sedlo"
        };
        var minAlpha = slova.Min(); // Ascii
        Console.WriteLine("MinAlpha: " + minAlpha);

        var minLength = slova.Min(c => c.Length);
        Console.WriteLine("Nejkratsi delka slova: " + minLength);

        var startWithKa = slova.Where(w => w.StartsWith("ka")).ToList();
        Console.Write("Start with \"ka\": ");
        foreach (var word in startWithKa)
        {
            Console.Write(word + ", ");
        }
        Console.WriteLine();

    }
}