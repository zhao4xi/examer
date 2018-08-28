using System;
using System.Collections.Generic;
using System.Text;

namespace examer.entities
{
    public class BaseEntity<TKey> : IKey<TKey> where TKey : IComparable<TKey>
    {
        public TKey Key { get; set; }
    }
}
