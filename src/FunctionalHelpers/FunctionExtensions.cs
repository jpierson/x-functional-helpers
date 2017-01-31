using System;
using System.Linq.Expressions;

namespace FunctionalHelpers
{
    public static class FunctionExtensions
    {
        public static Func<T1, T2> Curry<T1, T2>(Func<T1, T2> func) =>
            p1 => func(p1);

        public static Func<T1, Func<T2, T3>> Curry<T1, T2, T3>(this Func<T1, T2, T3> func) =>
            p1 => p2 => func(p1, p2);

        public static Func<T1, Func<T2, Func<T3, T4>>> Curry<T1, T2, T3, T4>(Func<T1, T2, T3, T4> func) =>
            p1 => p2 => p3 => func(p1, p2, p3);

        public static Func<T1, Func<T2, Func<T3, Func<T4, T5>>>> Curry<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5> func) =>
            p1 => p2 => p3 => p4 => func(p1, p2, p3, p4);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, T6>>>>> Curry<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6> func) =>
            p1 => p2 => p3 => p4 => p5 => func(p1, p2, p3, p4, p5);


        public static Func<T1, Func<T2, T3>> CurryExpression<T1, T2, T3>(Expression<Func<T1, T2, T3>> func) =>
            p1 => p2 => func.Compile().Invoke(p1, p2);



        public static Func<T1, T2, T3> ToFunc<T1, T2, T3>(this Func<T1, T2, T3> func) => func;

        public static Func<T1, T2> ToAction<T1, T2>(this Func<T1, T2> action) => action;

    }
}
