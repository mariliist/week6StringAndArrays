int[] numbers = new int[10];
Random rnd = new Random();

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1, numbers.Length + 1);
}

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");