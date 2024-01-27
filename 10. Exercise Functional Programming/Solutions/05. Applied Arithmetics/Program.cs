double[] numbers = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

string command = Console.ReadLine()!;
while (command != "end")
{
    Func<double[], double[]> function = null!;
    switch (command)
    {
        case "add":
            function = array =>
            {
                for (int i = 0; i < array.Length; i++) array[i]++;
                return array;
            };
            break;
        case "subtract":
            function = array =>
            {
                for (int i = 0; i < array.Length; i++) array[i]--;
                return array;
            };
            break;
        case "multiply":
            function = array =>
            {
                for (int i = 0; i < array.Length; i++) array[i] *= 2;
                return array;
            };
            break;
        case "print":
            Console.WriteLine(string.Join(' ', numbers));
            break;
    }

    if (function != null) numbers = function(numbers);
    command = Console.ReadLine()!;
}