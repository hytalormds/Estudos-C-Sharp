class Program
{
    public static void Main()
    {
        HashSet<int> numbers = new HashSet<int>();
        InputNumbers(numbers);
        ContarNumeros(numbers);
    }
    public static void InputNumbers(HashSet<int> numbers)
    {
        while (true)
        {
            Console.WriteLine("Digite os números: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0) {
                break;
            }
            numbers.Add(number);
        }
    }
    public static void ContarNumeros(HashSet<int> numbers)
    {
        int total = numbers.Count();
        Console.WriteLine($"O total de números no conjunto é: {total}");
    }
}