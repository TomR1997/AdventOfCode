namespace AdventOfCode._2021
{
    internal static class Day1
    {
        public static int GetSolutionPart1()
        {
            var input = InputService.GetInput(2021, 1);
            var numbers = Array.ConvertAll(input.Split("\r\n"), x => int.Parse(x));

            var answer = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i + 1) < numbers.Length && numbers[i + 1] > numbers[i])
                {
                    answer++;
                }
            }

            return answer;
        }

        public static int GetSolutionPart2()
        {
            var input = InputService.GetInput(2021, 1);
            var numbers = Array.ConvertAll(input.Split("\r\n"), x => int.Parse(x));

            var answer = 0;
            var last = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((i + 2) < numbers.Length)
                {
                    var current = numbers[i] + numbers[i + 1] + numbers[i + 2];

                    if (current > last)
                    {
                        answer++;
                    }

                    last = current;
                }
            }

            return answer;
        }
    }
}
