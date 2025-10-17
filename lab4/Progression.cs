using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class Progression
    {
        public interface IProgression
        {
            int Sum { get; }
            int NthTerm { get; }
            void Calculate();
        }

        public abstract class ProgressionBase : IProgression
        {
            protected int firstTerm;
            protected int n;

            public int Sum { get; protected set; }
            public int NthTerm { get; protected set; }

            public ProgressionBase(int firstTerm, int n)
            {
                this.firstTerm = firstTerm;
                this.n = n;
            }

            public abstract void Calculate();
        }

        public class Child1 : ProgressionBase, IComparable<Child1>
        {
            public int Difference { get; private set; }

            public Child1(int firstTerm, int difference, int n) : base(firstTerm, n)
            {
                this.Difference = difference;
                Calculate();
            }

            public override void Calculate()
            {
                NthTerm = firstTerm + (n - 1) * Difference;
                Sum = (2 * firstTerm + (n - 1) * Difference) * n / 2;
            }

            public override string ToString()
            {
                return $"Перший член={firstTerm} різниця={Difference} n={n} член= {NthTerm}\tсума n членів = {Sum}";
            }

            public int CompareTo(Child1 other)
            {
                if (other == null) return 1;
                return this.Difference.CompareTo(other.Difference);
            }
        }

        public class Child2 : ProgressionBase, IComparable<Child2>
        {
            public int Denominator { get; private set; }

            public Child2(int firstTerm, int denominator, int n) : base(firstTerm, n)
            {
                this.Denominator = (denominator == 1) ? 2 : denominator;
                Calculate();
            }

            public override void Calculate()
            {
                NthTerm = (int)(firstTerm * Math.Pow(Denominator, n - 1));
                Sum = (int)(firstTerm * (Math.Pow(Denominator, n) - 1) / (Denominator - 1));
            }

            public override string ToString()
            {
                return $"Перший член={firstTerm} знаменник={Denominator} n={n} член= {NthTerm}\tсума n членів = {Sum}";
            }

            public int CompareTo(Child2 other)
            {
                if (other == null) return 1;
                return this.Sum.CompareTo(other.Sum);
            }
        }
    }
}
