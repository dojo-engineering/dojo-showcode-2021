using System;
using System.Collections.Generic;
using Dojo.ShowCode.Logger;

namespace Dojo.ShowCode.SequenceGenerator
{
    public class FibonacciGenerator
    {
        private readonly IList<ILogger> _loggers;

        public FibonacciGenerator(IList<ILogger> loggers)
        {
            _loggers = loggers;
        }

        public int GetNumber(int index)
        {
            foreach (var logger in _loggers)
            {
                logger.Log(index);
            }

            if (index < 0)
            {
                throw new NotSupportedException();
            }

            if (index < 2)
            {
                return index;
            }

            return GetNumber(index - 1) + GetNumber(index - 2);
        }
    }
}
