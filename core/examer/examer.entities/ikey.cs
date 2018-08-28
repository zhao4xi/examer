using System;
using System.Collections.Generic;
using System.Text;

namespace examer.entities
{
    public interface Ikey<Tkey> where Tkey : IComparable<Tkey>

    {
        Tkey key { get; set; }
    }
}
