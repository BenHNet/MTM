using System;
using System.Collections.Generic;
using System.Text;

namespace MTM.Models.Interfaces
{
    public interface IPet
    {
        string PetName { get; set; }
        string PetProfile { get; set; }
        string PhotoUrl { get; set; }
        List<ITask> Tasks { get; set; }
    }
}
