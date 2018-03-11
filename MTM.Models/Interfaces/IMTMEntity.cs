using System;
using System.Collections.Generic;
using System.Text;

namespace MTM.Models.Interfaces
{
    public interface IMTMEntity
    {
        Guid Id { get; set; }
        bool Active { get; set; }
        Guid ModifiedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        DateTime CreatedDate { get; set; }
        string AsJson();
    }
}
