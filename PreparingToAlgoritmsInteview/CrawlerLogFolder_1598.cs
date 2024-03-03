namespace PreparingToAlgoritmsInteview;

internal class CrawlerLogFolder_1598
{
    public CrawlerLogFolder_1598()
    {
        Console.WriteLine(MinOperations(new string[] { "d1/", "d2/", "../", "d21/", "./" })); 
        Console.WriteLine(MinOperations(new string[] { "d1/", "d2/", "./", "d3/", "../", "d31/" })); 
        Console.WriteLine(MinOperations(new string[] { "d1/", "../", "../", "../" })); 
        Console.WriteLine(MinOperations(new string[] { "./", "wz4/", "../", "mj2/", "../", "../", "ik0/", "il7/" })); 
    }

    public int MinOperations(string[] logs)
    {
        var depth = 0;

        foreach (var log in logs)
        {
            switch (log)
            {
                case "../":
                    depth = depth == 0 ? 0 : --depth;
                    continue;
                case "./":
                    continue;
                default:
                    depth++;
                    continue;
            }
        }

        return depth < 0 ? 0 : depth;
    }
}
