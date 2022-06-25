namespace AdventOfCode._2021
{
    internal static class Day2
    {
        public static int GetSolutionPart1()
        {
            var input = InputService.GetInput(2021, 2).Split("\r\n");

            var forwards = input.Where(x => x.Contains("forward")).Sum(x => int.Parse(x.Substring(8, 1)));
            var ups = input.Where(x => x.Contains("up")).Sum(x => int.Parse(x.Substring(3, 1)));
            var downs = input.Where(x => x.Contains("down")).Sum(x => int.Parse(x.Substring(5, 1)));

            return forwards * (downs - ups);
        }

        public static int GetSolutionPart2()
        {
            var inputs = InputService.GetInput(2021, 2).Split("\r\n");
            var forwards = inputs.Where(x => x.Contains("forward")).Sum(x => int.Parse(x.Substring(8, 1)));

            var aim = 0;
            var depth = 0;

            foreach (var input in inputs)
            {
                if (input.Contains("forward"))
                {
                    var forward = int.Parse(input.Substring(8, 1));
                    depth += aim * forward;
                }

                if (input.Contains("up"))
                {
                    aim -= int.Parse(input.Substring(3, 1));
                }

                if (input.Contains("down"))
                {
                    aim += int.Parse(input.Substring(5, 1));
                }
            }

            return forwards * depth;
        }
    }
}
