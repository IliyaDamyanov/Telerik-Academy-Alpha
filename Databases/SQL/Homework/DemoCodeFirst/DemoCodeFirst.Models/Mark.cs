using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models
{
    public class Mark
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Score { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
