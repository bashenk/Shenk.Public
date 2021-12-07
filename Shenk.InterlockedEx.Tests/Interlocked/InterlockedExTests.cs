using NUnit.Framework;

using Shenk.Interlocked;

using FluentAssertions;

namespace Shenk.Tests.Interlocked {

    [TestFixture]
    [Timeout(3000)]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class InterlockedExTests {
        [SetUp]
        public void Setup() {}

        [Test]
        public void Add_Short_ValueIsAdded() {
            var argument1 = (short)888;
            const int initialValue = 888;
            const int additionalValue = 111;

            InterlockedEx.Add(ref argument1, additionalValue).Should().Be(initialValue + additionalValue);
        }

        [Test]
        public void Add_UShort_ValueIsAdded() {
            var argument1 = (ushort)888U;
            const int initialValue = 888;
            const int additionalValue = 111;

            InterlockedEx.Add(ref argument1, additionalValue).Should().Be(initialValue + additionalValue);
        }

        [Test]
        public void Add_UInt_ValueIsAdded() {
            var argument1 = 888U;
            const int initialValue = 888;
            const int additionalValue = 111;

            InterlockedEx.Add(ref argument1, additionalValue).Should().Be(initialValue + additionalValue);
        }

        [Test]
        public void Add_ULong_ValueIsAdded() {
            var argument1 = 888UL;
            const int initialValue = 888;
            const int additionalValue = 111;

            InterlockedEx.Add(ref argument1, additionalValue).Should().Be(initialValue + additionalValue);
        }

        [Test]
        public void CompareExchange_Short_ShouldEqualOriginalValue() {
            var argument1 = (short) 888;
            const int comparand = 888;
            const int newValue = 999;

            InterlockedEx.CompareExchange(ref argument1, newValue, comparand).Should().Be(comparand);
        }

        [Test]
        public void CompareExchange_UShort_ShouldEqualOriginalValue() {
            var argument1 = (ushort) 888;
            const int comparand = 888;
            const int newValue = 999;

            InterlockedEx.CompareExchange(ref argument1, newValue, comparand).Should().Be(comparand);
        }

        [Test]
        public void CompareExchange_UInt_ShouldEqualOriginalValue() {
            var argument1 = 888U;
            const int comparand = 888;
            const int newValue = 999;

            InterlockedEx.CompareExchange(ref argument1, newValue, comparand).Should().Be(comparand);
        }

        [Test]
        public void CompareExchange_ULong_ShouldEqualOriginalValue() {
            var argument1 = 888UL;
            const int comparand = 888;
            const int newValue = 999;

            InterlockedEx.CompareExchange(ref argument1, newValue, comparand).Should().Be(comparand);
        }

        [Test]
        public void Decrement_UInt_ValueIsDecremented() {
            var argument1 = 888U;
            const int initialValue = 888;

            InterlockedEx.Decrement(ref argument1).Should().Be(initialValue - 1);
        }

        [Test]
        public void Decrement_Short_ValueIsDecremented() {
            var argument1 = (short)888;
            const int initialValue = 888;

            InterlockedEx.Decrement(ref argument1).Should().Be(initialValue - 1);
        }

        [Test]
        public void Decrement_UShort_ValueIsDecremented() {
            var argument1 = (ushort)888U;
            const int initialValue = 888;

            InterlockedEx.Decrement(ref argument1).Should().Be(initialValue - 1);
        }

        [Test]
        public void Decrement_ULong_ValueIsDecremented() {
            var argument1 = 888UL;
            const int initialValue = 888;

            InterlockedEx.Decrement(ref argument1).Should().Be(initialValue - 1);
        }

        [Test]
        public void Exchange_Short_ShouldEqualOriginalValue() {
            var argument1 = (short) 888;
            const int originalValue = 888;
            const int newValue = 999;

            InterlockedEx.Exchange(ref argument1, newValue).Should().Be(originalValue);
        }

        [Test]
        public void Exchange_UShort_ShouldEqualOriginalValue() {
            var argument1 = (ushort) 888;
            const int originalValue = 888;
            const int newValue = 999;

            InterlockedEx.Exchange(ref argument1, newValue).Should().Be(originalValue);
        }

        [Test]
        public void Exchange_UInt_ShouldEqualOriginalValue() {
            var argument1 = 888U;
            const int originalValue = 888;
            const int newValue = 999;

            InterlockedEx.Exchange(ref argument1, newValue).Should().Be(originalValue);
        }

        [Test]
        public void Exchange_ULong_ShouldEqualOriginalValue() {
            var argument1 = 888UL;
            const int originalValue = 888;
            const int newValue = 999;

            InterlockedEx.Exchange(ref argument1, newValue).Should().Be(originalValue);
        }

        [Test]
        public void Increment_Short_ValueIsIncremented() {
            var argument1 = (short)888;
            const int initialValue = 888;

            InterlockedEx.Increment(ref argument1).Should().Be(initialValue + 1);
        }

        [Test]
        public void Increment_UShort_ValueIsIncremented() {
            var argument1 = (ushort)888U;
            const int initialValue = 888;

            InterlockedEx.Increment(ref argument1).Should().Be(initialValue + 1);
        }

        [Test]
        public void Increment_UInt_ValueIsIncremented() {
            var argument1 = 888U;
            const int initialValue = 888;

            InterlockedEx.Increment(ref argument1).Should().Be(initialValue + 1);
        }

        [Test]
        public void Increment_ULong_ValueIsIncremented() {
            var argument1 = 888UL;
            const int initialValue = 888;

            InterlockedEx.Increment(ref argument1).Should().Be(initialValue + 1);
        }

        [Test]
        public void Read_Short_ValueIsAsExpected() {
            var argument1 = (short)888;
            const int initialValue = 888;

            InterlockedEx.Read(ref argument1).Should().Be(initialValue);
        }

        [Test]
        public void Read_UShort_ValueIsAsExpected() {
            var argument1 = (ushort)888U;
            const int initialValue = 888;

            InterlockedEx.Read(ref argument1).Should().Be(initialValue);
        }

        [Test]
        public void Read_Int_ValueIsAsExpected() {
            var argument1 = 888;
            const int initialValue = 888;

            InterlockedEx.Read(ref argument1).Should().Be(initialValue);
        }

        [Test]
        public void Read_UInt_ValueIsAsExpected() {
            var argument1 = 888U;
            const int initialValue = 888;

            InterlockedEx.Read(ref argument1).Should().Be(initialValue);
        }

        [Test]
        public void Read_ULong_ValueIsAsExpected() {
            var argument1 = 888UL;
            const int initialValue = 888;

            InterlockedEx.Read(ref argument1).Should().Be(initialValue);
        }

    }
}
