// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");

labExamString();


void labExamString()
{
    string customerName = "Ms. Barros";

    string currentProduct = "Magic Yield";
    int currentShares = 2975000;
    decimal currentReturn = 0.1275m;
    decimal currentProfit = 55000000.0m;

    string newProduct = "Glorious Future";
    decimal newReturn = 0.13125m;
    decimal newProfit = 63000000.0m;

    // Your logic here


    /**
     * 
     * Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00  
     */
    string[] str = new string[4];
    str[0] = $"Dear {customerName},";
    str[1] = $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.";
    str[2] = $"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.";
    str[3] = $"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be ¤{newProfit:N2}.";
    Console.WriteLine(string.Join('\n',str));
    Console.WriteLine("Here's a quick comparison:\n");
    string comparisonMessage = createLine("Magic Yield", currentReturn, currentProfit) + "\n"
        + createLine("Glorious Future", newReturn, newProfit);
    // Your logic here


    Console.WriteLine(comparisonMessage);
}
string createLine(string str,decimal c_return,decimal c_profit)
{
    return $"{str.PadRight(20)}{string.Format("{0:P2}",c_return).PadRight(10)}{string.Format("{0:N2}",c_profit).PadRight(20)}";
}


void labString()
{
    string first = "Hello";
    string second = "World";
    string result = string.Format("{0} {1}", first, second);

    Console.WriteLine(result);
    Console.WriteLine($"{first} {second} ----");
    decimal price = 123.45m;
    int discount = 50;
    Console.WriteLine($"{price:C} (Save {discount:C}) ----");
    decimal measurement = 123456.78912m;
    Console.WriteLine($"Measurement: {measurement:N4} units");


    decimal tax = .36785m;
    Console.WriteLine($"Tax rate: {tax:P2}");
    string input = "Pad this";
    Console.WriteLine(input.PadLeft(9, '.'));
}


void labReverseStr()
{
    string pangram = "The quick brown fox jumps over the lazy dog";
    char[] result = new char[pangram.Length + 1];
    var arr = pangram.Split(' ');
    int i = 0;
    foreach (var word in arr)
    {

        var w = word.ToCharArray();
        Array.Reverse(w);
        for (int j = 0; j < w.Length; j++)
        {
            result[i] = w[j];
            i++;
        }
        result[i] = ' ';
        i++;

    }
    Array.Resize(ref result, result.Length - 1);
    Console.WriteLine(new string(result));
}
void testStringArray()
{
    var str = "abcd1234";
    var arr = str.ToCharArray();
    printArray(arr);
    Array.Reverse(arr);
    string out_str = new string(arr);
    Console.WriteLine(out_str);
    printArray(arr);
    Console.WriteLine(out_str);
    string result = string.Join(",", arr);
    Console.WriteLine(result);
    string[] items = result.Split(',');
}
void TestResize()
{
    string[] pallets = { "B14", "A11", "B12", "A13" };
    printArray(pallets);
    Array.Resize(ref pallets, 6);
    printArray(pallets);
}

void printArray<T>(T[] arr)
{
    Console.WriteLine("#############################");
    foreach (var pallet in arr)
    {
        Console.WriteLine($"-- {pallet}");
    }
}

void TryParse()
{
    string[] values = { "12.3", "45", "ABC", "11", "DEF" };
    int sum = 0;
    string message = "";
    foreach (var value in values)
    {
        if (int.TryParse(value, out int number))
        {
            sum += number;
        }
        else
        {
            message += value + " ";
        }
    }
    Console.WriteLine($"Message: {message}");
    Console.WriteLine($"Total: {sum}");

}