using System;
using System.Collections.Generic;

namespace System.Collections.Invariant
{
    public struct InvariantArray<T> : IList<T>, IReadOnlyList<T>, IEquatable<InvariantArray<T>>, IList
    {
        private readonly Wrapper<T>[] items;

        public InvariantArray(int length)
        {
            this.items = new Wrapper<T>[length];
        }

        public override bool Equals(object obj) =>
            obj is InvariantArray<T> && Equals((InvariantArray<T>)obj);

        public bool Equals(InvariantArray<T> other) =>
            this.items == other.items;

        public override int GetHashCode() =>
            this.items == null ? 0 : items.GetHashCode();
    }
}
