using FunctionalHelpers;
using System;
using Xunit;

public class PipeForwardTests
{
    [Theory]
    [ClassData(typeof(FahrenheitCelsiusSampleData))]
    public void PipeForwardShouldForwardFirstArgumentToTheFirstParameterOfTheFunctionSpecifiedAsTheSecond(
        double fahrenheit, 
        double celsius)
    {
        var actual = fahrenheit
            .PipeForward(d => d - 32d)
            .PipeForward(d => d * (5d / 9d));
        
        Assert.Equal(celsius, actual, 2);
    }
}
