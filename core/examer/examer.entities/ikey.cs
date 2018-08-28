using System;
using System.Collections.Generic;
using System.Text;

namespace examer.entities
{
    public interface IKey<TKey> where TKey : IComparable<TKey>
    {
        TKey Key { get; set; }
    }
}
