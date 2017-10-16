using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverengineeredFizzBuzz
{
    class AnswerBuilder
    {
        protected IDictionary<int, string> AnswerMappings;

        public AnswerBuilder()
        {
            AnswerMappings = new Dictionary<int, string>();
            InitialiseAnswerMappings();
        }

        protected void InitialiseAnswerMappings()
        {
            AnswerMappings[3] = string.Intern("Fizz");
            AnswerMappings[5] = string.Intern("Buzz");
            AnswerMappings[7] = string.Intern("Bizz");
        }

        public Answer BuildAnswer(int value)
        {
            ICollection<string> answerMatchings = new List<string>();
            foreach (var key in AnswerMappings.Keys)
                if (IsAFactor(value, key))
                    answerMatchings.Add(AnswerMappings[key]);
            if (answerMatchings.Any())
                return new FizzBuzzAnswer(answerMatchings);
            return new Answer(value);           
        }

        private bool IsAFactor(int value, int potentialFactor)
        {
            return value % potentialFactor == 0;
        }

    }
}
