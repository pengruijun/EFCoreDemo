namespace ConsoleApp;

public static class Iterator
{
    public static IEnumerator<int> GetSampleNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield break;
        yield return 4;
        yield return 5;
    }
    
    public static async IAsyncEnumerable<int> GetSampleNumbersAsync()
    {
        yield return 1;
        await Task.Delay(500);
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
    }
}