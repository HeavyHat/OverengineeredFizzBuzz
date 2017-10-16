using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverengineeredFizzBuzz
{
    class Answer
    {
        private readonly int _internalValue;

        public Answer(int value)
        {
            _internalValue = value;
        }

        public override string ToString()
        {
            return _internalValue.ToString();
        }
    }
}
