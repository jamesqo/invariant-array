using System;
using System.Collections.Generic;

namespace System.Collections.Invariant
{
    public struct Wrapper<T> : IEquatable<Wrapper<T>>
    {
        public T Value;

        public Wrapper(T value)
        {
            this.Value = value;
        }

        public override bool Equals(object obj) =>
            obj is Wrapper<T> && Equals((Wrapper<T>)obj);

        public bool Equals(Wrapper<T> other) =>
            EqualityComparer<T>.Default.Equals(this.Value, other.Value);

        public override int GetHashCode() =>
            EqualityComparer<T>.Default.GetHashCode(this.Value);
    }
}
