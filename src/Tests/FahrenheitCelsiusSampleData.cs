using System;
using System.Collections;
using System.Collections.Generic;

internal class FahrenheitCelsiusSampleData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { -459.67d, -273.15d };
        yield return new object[] { -50, -45.56d };
        yield return new object[] { -40, -40.00d };
        yield return new object[] { -30, -34.44d };
        yield return new object[] { -20, -28.89d };
        yield return new object[] { -10, -23.33d };
        yield return new object[] { 0, -17.78d };
        yield return new object[] { 10, -12.22d };
        yield return new object[] { 20, -6.67d };
        yield return new object[] { 30, -1.11d };
        yield return new object[] { 40, 4.44d };
        yield return new object[] { 50, 10.00d };
        yield return new object[] { 60, 15.56d };
        yield return new object[] { 70, 21.11d };
        yield return new object[] { 80, 26.67d };
        yield return new object[] { 90, 32.22d };
        yield return new object[] { 100, 37.78d };
        yield return new object[] { 110, 43.33d };
        yield return new object[] { 120, 48.89d };
        yield return new object[] { 130, 54.44d };
        yield return new object[] { 140, 60.00d };
        yield return new object[] { 150, 65.56d };
        yield return new object[] { 160, 71.11d };
        yield return new object[] { 170, 76.67d };
        yield return new object[] { 180, 82.22d };
        yield return new object[] { 190, 87.78d };
        yield return new object[] { 200, 93.33d };
        yield return new object[] { 300, 148.89d };
        yield return new object[] { 400, 204.44d };
        yield return new object[] { 500, 260.00d };
        yield return new object[] { 600, 315.56d };
        yield return new object[] { 700, 371.11d };
        yield return new object[] { 800, 426.67d };
        yield return new object[] { 900, 482.22d };
        yield return new object[] { 1000, 537.78d };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}