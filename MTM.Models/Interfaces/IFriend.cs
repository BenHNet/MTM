using System;
using System.Collections.Generic;
using System.Text;

namespace MTM.Models.Interfaces
{
    public interface IFriend
    {
        string UserName { get; set; }
        string Profile { get; set; }
        string PhotoUrl { get; set; }
        List<IPet> Pets { get; set; }
    }
}
