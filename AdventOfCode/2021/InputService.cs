namespace AdventOfCode._2021
{
    internal static class InputService
    {
        public static string GetInput(int year, int day)
        {
            return File.ReadAllText($@"{Directory.GetCurrentDirectory()}\{year}\Input\Day{day}.txt");
        }
    }
}
