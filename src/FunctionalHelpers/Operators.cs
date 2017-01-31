using System;

namespace FunctionalHelpers
{
    public static class Operators
    {
        public static T2 PipeForward<T1, T2>(this T1 value, Func<T1, T2> func)
        {
            return func(value);
        }

        public static Func<T2, T3> PipeForward<T1, T2, T3>(this T1 value, Func<T1, T2, T3> func)
        {
            return func.Curry()(value);
        }

        public static Func<T2, Func<T3, T4>> PipeForward<T1, T2, T3, T4>(this T1 value, Func<T1, T2, T3, T4> func)
        {
            return func.Curry()(value);
        }

        public static Func<T2, Func<T3, Func<T4, T5>>> PipeForward<T1, T2, T3, T4, T5>(this T1 value, Func<T1, T2, T3, T4, T5> func)
        {
            return func.Curry()(value);
        }

        public static T2 PipeBackward<T1, T2>(this Func<T1, T2> func, T1 value)
        {
            return func(value);
        }

        public static Func<T2, T3> PipeBackward<T1, T2, T3>(this Func<T1, T2, T3> func, T1 value)
        {
            return func.Curry()(value);
        }

        public static Func<T2, Func<T3, T4>> PipeBackward<T1, T2, T3, T4>(this Func<T1, T2, T3, T4> func, T1 value)
        {
            return func.Curry()(value);
        }

        public static Func<T2, Func<T3, Func<T4, T5>>> PipeBackward<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5> func, T1 value)
        {
            return func.Curry()(value);
        }

        public static Func<T1, T3> ComposeForward<T1, T2, T3>(this Func<T1, T2> func1, Func<T2, T3> func2)
        {
            return v1 => func2(func1(v1));
        }

        public static Func<T1, Func<T3, T4>> ComposeForward<T1, T2, T3, T4>(this Func<T1, T2> func1, Func<T2, T3, T4> func2)
        {
            return v1 => func2.Curry()(func1(v1));
        }

        public static Func<T1, Func<T3, Func<T4, T5>>> ComposeForward<T1, T2, T3, T4, T5>(this Func<T1, T2> func1, Func<T2, T3, T4, T5> func2)
        {
            return v1 => func2.Curry()(func1(v1));
        }
    }
}