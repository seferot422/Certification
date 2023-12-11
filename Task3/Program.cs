class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 5, 0, 10, 4 };
        Print(a, 0);
    }

    static void Print(int[] array, int index)
    {
        try
        {
            int element = array[index];
            Print(array, index + 1);
            Console.WriteLine(element);
        }
        catch (IndexOutOfRangeException ignored) { }
    }
}
