using System;

namespace FunctionalHelpers
{
    public abstract class DiscriminatedUnion<T1>
    {
        public abstract TResult Match<TResult>(
            Func<T1, TResult> case1);    
    }

    public abstract class DiscriminatedUnion<T1, T2>
    {
        public abstract TResult Match<TResult>(
            Func<T1, TResult> case1,
            Func<T2, TResult> case2);    
    }

    public abstract class DiscriminatedUnion<T1, T2, T3>
    {
        public abstract TResult Match<TResult>(
            Func<T1, TResult> case1,
            Func<T2, TResult> case2,
            Func<T3, TResult> case3);    
    }

    
    public abstract class DiscriminatedUnion<T1, T2, T3, T4>
    {
        public abstract TResult Match<TResult>(
            Func<T1, TResult> case1,
            Func<T2, TResult> case2,
            Func<T3, TResult> case3,
            Func<T4, TResult> case4);    
    }

    
    public abstract class DiscriminatedUnion<T1, T2, T3, T4, T5>
    {
        public abstract TResult Match<TResult>(
            Func<T1, TResult> case1,
            Func<T2, TResult> case2,
            Func<T3, TResult> case3,
            Func<T4, TResult> case4,
            Func<T5, TResult> case5);    
    }

    public abstract class DiscriminatedUnion<T1, T2, T3, T4, T5, T6>
    {
        public abstract TResult Match<TResult>(
            Func<T1, TResult> case1,
            Func<T2, TResult> case2,
            Func<T3, TResult> case3,
            Func<T4, TResult> case4,
            Func<T5, TResult> case5,
            Func<T6, TResult> case6);    
    }
}