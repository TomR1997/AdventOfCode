using var httpClient = new HttpClient()
{
    BaseAddress = new Uri("https://adventofcode.com/2021/day")
};

await httpClient.GetAsync()

Console.WriteLine("Hello, World!");
