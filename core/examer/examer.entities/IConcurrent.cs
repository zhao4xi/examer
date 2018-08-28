using System;
using System.Collections.Generic;
using System.Text;

namespace examer.entities
{
    public interface IConcurrent
    {
        int LastChanged { get; set; }
    }
}
