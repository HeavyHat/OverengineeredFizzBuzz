using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OverengineeredFizzBuzz
{
    class Program
    {
        public const int MAXIMUM_NUMBER = 100;

        private static Tuple<int, int> GetBounds(string[] args)
        {
            if(args.Length == 2)
            {
                return new Tuple<int, int>(int.Parse(args[0]), int.Parse(args[1]));
            }
            Console.WriteLine("From: ");
            var from = int.Parse(Console.ReadLine());
            Console.WriteLine("To: ");
            var to = int.Parse(Console.ReadLine());
            return new Tuple<int, int>(from, to);
        }

        static void Main(string[] args)
        {
            var bounds = GetBounds(args);
            var from = bounds.Item1;
            var to = bounds.Item2;
            var builder = new AnswerBuilder();
            var answers = new List<Answer>();
            for(; from <= to; from++)
            {
                answers.Add(builder.BuildAnswer(from));
            }
            answers.ForEach(x => Console.WriteLine(x));
            var countOfNumericAnswers = answers.Count(x => Regex.IsMatch(x.ToString(), "[0-9]+"));
            Console.WriteLine($"Number of Integer answers: {countOfNumericAnswers}");
            var groupedLists = answers
                .Where(x => !Regex.IsMatch(x.ToString(), "[0-9]+"))
                .GroupBy(x => x.ToString());
            foreach(var group in groupedLists)
            {
                Console.WriteLine($"Number of {group.First().ToString()} answers: {group.Count()}");
            }
            Console.Read();
        }
    }
}
