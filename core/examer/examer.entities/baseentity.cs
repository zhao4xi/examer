using System;
using System.Collections.Generic;
using System.Text;

namespace examer.entities
{
    public abstract class Baseentity<Tkey> : Ikey<Tkey> where Tkey : IComparable<Tkey>
    {
        public Tkey key { get; set; }
    }
}
