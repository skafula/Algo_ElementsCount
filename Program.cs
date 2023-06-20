internal class Program
{
    private static Dictionary<int,int> NumberOfElements(int[] arr)
    {
        var statistic = new Dictionary<int,int>();
        foreach (var element in arr)
        {
            if (statistic.ContainsKey(element)) statistic[element]++;
            else statistic.Add(element, 1);
        }

        return statistic;
    }
    private static void Main(string[] args)
    {
        var arr =new int[] { 1, 2, 3, 2, 3, 3, 4, 4, 4, 4, 4, 4 };
        var stat = NumberOfElements(arr);

        foreach (var element in stat) 
        {
            Console.WriteLine($"Element: {element.Key}, Count: {element.Value}");
        }
    }
}