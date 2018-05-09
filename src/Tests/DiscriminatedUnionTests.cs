using System;
using Xunit;

using FunctionalHelpers;

namespace Tests
{
    public class ComposeForwardTests
    {


        [Fact]
        public void DiscriminatedUnionWithTwoNamedCasesShouldMatchFirstCaseAndHaveAssociatedValueWhenItInhabitsThatValue()
        {
            var count = 1;
            var fish = new Fish.RedFish(count);
        
            var wasRedFishWithSpecifiedCount = fish.Match(
                case1: redFish => redFish.Count == count,
                case2: blueFish => false);
            
            Assert.True(wasRedFishWithSpecifiedCount);
        }

        [Fact]
        public void DiscriminatedUnionWithTwoNamedCasesShouldMatchSecondCaseAndHaveAssociatedValueWhenItInhabitsThatValue()
        {
            var count = 1;
            var fish = new Fish.BlueFish(count);
        
            var (isBlueFish, hasSpecifiedCount) = fish.Match(
                case1: redFish => (false, false),
                case2: blueFish => (true, blueFish.Count == count));
            
            Assert.True(isBlueFish);
            Assert.True(hasSpecifiedCount);
        }
    }

    public abstract class Fish : DiscriminatedUnion<Fish.RedFish, Fish.BlueFish>
    {
        public Fish()
        {
            // TODO: runtime check to ensure that the outer class is Fish to prevent external overloads
            var type = this.GetType();
            if (!type.IsNested ||
                type.DeclaringType != typeof(Fish))
                throw new InvalidOperationException($"{nameof(Fish)} should not be inherited from other than by nested case types.");
        }

        public class RedFish : Fish
        {
            public RedFish(int count)
            {
                Count = count;
            }

            public int Count { get; }
        }

        public class BlueFish : Fish
        {
            public BlueFish(int count)
            {
                Count = count;
            }

            public int Count { get; }
        }

        public override TResult Match<TResult>(
            Func<RedFish, TResult> case1, 
            Func<BlueFish, TResult> case2)
        {
            if (this is RedFish)
                return case1(this as RedFish);
            else if (this is BlueFish)
                return case2(this as BlueFish);

            throw new InvalidOperationException();
        }
    }
}