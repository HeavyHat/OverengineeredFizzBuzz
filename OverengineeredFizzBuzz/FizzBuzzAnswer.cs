using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverengineeredFizzBuzz
{
    class FizzBuzzAnswer : Answer
    {
        private readonly IEnumerable<string> _internalAnswers;

        public FizzBuzzAnswer(IEnumerable<string> answers) : base(0)
        {
            _internalAnswers = answers;
        }

        public override string ToString()
        {
            return string.Join("", _internalAnswers);
        }
    }
}
