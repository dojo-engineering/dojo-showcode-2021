using Dojo.ShowCode.Logger;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using Dojo.ShowCode.SequenceGenerator;
using Xunit;

namespace Dojo.ShowCode.Test
{
    public class FibonacciTests
    {
        private readonly FibonacciGenerator _target;
        private readonly List<ILogger> _loggers;

        public FibonacciTests()
        {
            var fileLogger = Substitute.For<ILogger>();
            var databaseLogger = Substitute.For<ILogger>();

            _loggers = new List<ILogger>
            {
                fileLogger,
                databaseLogger

            };

            _target = new FibonacciGenerator(_loggers);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void GetNumber_GivenIndexZeroAndOne_ReturnsIndex(int index)
        {
            // act
            var actualResult = _target.GetNumber(index);

            // assert
            actualResult.Should().Be(index);
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(5, 5)]
        public void GetNumber_GivenAnyIndexMoreThanOne_ReturnsExpectedResult(int index, int result)
        {
            // act
            var actualResult = _target.GetNumber(index);

            // assert
            actualResult.Should().Be(result);
        }

        [Fact]
        public void GetNumber_GivenNegativeIndex_ThrowsException()
        {
            // act
            Action action = () => _target.GetNumber(-2);

            // assert
            action.Should().Throw<NotSupportedException>();
        }

        [Fact]
        public void GetNumber_GivenAnyIndex_LogsToAllLoggers()
        {
            // act
            _target.GetNumber(2);

            // assert
            foreach (var logger in _loggers)
            {
                logger.Received().Log(2);
            }
        }
    }
}
