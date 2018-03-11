using MTM.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MTM.Models.Models
{
    public class Pet : MTMEntityBase, IMTMEntity, IPet
    {
        [Display(Name = "Pet Name")]
        public string PetName { get; set; }

        [Display(Name = "Pet Profile")]
        public string PetProfile { get; set; }

        [Display(Name = "Photo Url")]
        public string PhotoUrl { get; set; }

        private List<ITask> _tasks = new List<ITask>();
        public List<ITask> Tasks
        {
            get
            {
                return _tasks;
            }
            
            set
            {
                _tasks = value;
            }
        }
    }
}
