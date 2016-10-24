using FitnessAppV2.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ApplicationModels.FitnessAppV2.Models
{
    public class Location : EntityBase
    {
        private ICollection<FitnessClass> _fitnessClass;

        [DataMember]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<FitnessClass> FitnessClass
        {
            get { return _fitnessClass ?? (new Collection<FitnessClass>()); }
            set { _fitnessClass = value; }
        }
    }
}
