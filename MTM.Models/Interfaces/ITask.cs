using System;
using System.Collections.Generic;
using System.Text;

namespace MTM.Models.Interfaces
{
    public interface ITask
    {
        string Title { get; set; }

        IPet Pet { get; set; }
    }
}
