using FunctionalHelpers;
using System;
using Xunit;

namespace Tests
{
    public class Curry
    {
        [Fact]
        public void StaticMethodWith2ParametersCanBeCurried()
        {
            var curriedMethod = FunctionExtensions
                .Curry<int, string, object>(MethodWithTwoParameters);

            var result = curriedMethod(5)("five");

            Assert.Equal(Tuple.Create(5, "five"), result);
        }

        [Fact]
        public void FuncWith2ParametersCanBeCurried()
        {
            var curriedFunc = FuncWithTwoParameters.Curry();

            var result = curriedFunc(5)("five");

            Assert.Equal(Tuple.Create(5, "five"), result);
        }

        [Fact]
        public void LambdaWith2ParametersCanBeCurried()
        {
            var curriedLambda = FunctionExtensions.Curry((int v1, string v2) => Tuple.Create(v1, v2));

            var result = curriedLambda(5)("five");

            Assert.Equal(Tuple.Create(5, "five"), result);
        }

        [Fact]
        public void DelegateWith2ParametersCanBeCurried()
        {
            var curriedDelegate = FunctionExtensions
                .Curry<int, string, object>(DelegateWithTwoParamaters.Invoke);

            var result = curriedDelegate(5)("five");

            Assert.Equal(Tuple.Create(5, "five"), result);
        }

        public static object MethodWithTwoParameters(int value1, string value2)
        {
            return Tuple.Create(value1, value2);
        }

        public static readonly Func<int, string, object> FuncWithTwoParameters = 
            (i, s) => Tuple.Create(i, s);

        public delegate object int_string_object(int value1, string value2);
        public static readonly int_string_object DelegateWithTwoParamaters =
            (i, s) => Tuple.Create(i, s);


        public class TestClass<T1, T2>
        {

        }

        public static class TestClassExtensions
        {
            public static object HighOrderTest<T1, T2>(TestClass<T1, T2> value)
            {
                return value;
            }
        }
    }
}
