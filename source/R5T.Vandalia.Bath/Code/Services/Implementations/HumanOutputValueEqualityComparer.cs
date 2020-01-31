using System;

using R5T.Bath;


namespace R5T.Vandalia.Bath
{
    /// <summary>
    /// Provides an abstract base-class for <see cref="IValueEqualityComparer{T}"/> implementations that want to use a <see cref="IHumanOutput"/> service.
    /// </summary>
    public abstract class HumanOutputValueEqualityComparer<T> : IValueEqualityComparer<T>
    {
        protected IHumanOutput HumanOutput { get; }


        public HumanOutputValueEqualityComparer(IHumanOutput humanOutput)
        {
            this.HumanOutput = humanOutput;
        }

        public abstract bool Equals(T x, T y);
    }
}
