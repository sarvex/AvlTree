using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace AvlTree
{
    public class AvlTree<T> : IEnumerable<T>
        where T : IComparable
    {
        public AvlNode<T> Head { get; }

        public void Add(T value);
        public bool Remove(T value);

        public bool Contains(T value);
        public void Clear();

        public int Count { get; }

        public void PreOrderTraversal(Action<T> action);
        public void PostOrderTraversal(Action<T> action);
        public void InOrderTraversal(Action<T> action);

        public IEnumerator<T> GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerator.GetEnumerator();
    }
}