// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");



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