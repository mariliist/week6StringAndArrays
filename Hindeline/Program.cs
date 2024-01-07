//string[] colors = { "red", "green", "blue", "pink", "yellow" };

//for (int i = colors.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine($"{i}. {colors[i]}");
//}

string hello = "Hello, world!";
int counter = 0;

for (int i = 0; i < hello.Length; i++)
{
    if (hello[i] == 'l')
    {
        counter++;
    }
}
Console.WriteLine($"There are {counter} l's in the string \"{hello}\"");