using System;
using System.Collections.Generic;
using System.Text;

namespace examer.entities
{

    public interface IAudit
    {
        DateTime Create_Date { get; set; }

        DateTime? Update_Date { get; set; }
    }
}
