using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFDatabaseFirstAproach
{
    class PartialClasses
    {
        [MetadataType(typeof(EmployeeMetadata))]
        public partial class Employee
        {
            internal class EmployeeMetadata
            {
                [Required]
                public string MiddleName { get; set; }
            }
        }
    }
}
