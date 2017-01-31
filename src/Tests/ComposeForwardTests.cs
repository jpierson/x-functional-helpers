using FunctionalHelpers;
using System;
using Xunit;

using Transform = System.Func<double, double>;

public class ComposeForwardTests
{
    [Theory]
    [ClassData(typeof(FahrenheitCelsiusSampleData))]

    public void ComposeForwardShouldResultInFirstFunctionsResultFedToTheSecond(double fahrenheit, double celsius)
    {
        var minusThirtyTwo = new Transform(d => d - 32d);
        var timesfiveNinths = new Transform(d => d * (5d / 9d));

        var fahrenheitToCelsius = minusThirtyTwo.ComposeForward(timesfiveNinths);

        var actual = fahrenheitToCelsius(fahrenheit);
        
        Assert.Equal(celsius, actual, 2);
    }
}
