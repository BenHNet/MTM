using MTM.Models.Interfaces;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace MTM.Models.Models
{
    public class MTMEntityBase : IMTMEntity
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public string AsJson() { return JsonConvert.SerializeObject(this); }
    }
}
