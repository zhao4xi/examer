using System;
using System.Collections.Generic;
using System.Text;

namespace examer.entities.DTO
{
    public class UserEntity : BaseEntity<int>, IAudit
    {
        public string User_Code { get; set; }

        public string User_Name { get; set; }

        public DateTime Create_Date { get; set; }

        public DateTime? Update_Date { get; set; }
    }
}
