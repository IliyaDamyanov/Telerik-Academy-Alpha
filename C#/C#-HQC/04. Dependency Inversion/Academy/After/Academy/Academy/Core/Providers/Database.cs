using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;

namespace Academy.Core.Providers
{
    public class Database : IDatabase
    {
        private readonly IList<ISeason> seasons;
        private readonly IList<IStudent> students;
        private readonly IList<ITrainer> trainers;

        public Database()
        {
            this.seasons = new List<ISeason>();
            this.students = new List<IStudent>();
            this.trainers = new List<ITrainer>();
        }

        public IList<ISeason> Seasons
        {
            get
            {
                return this.seasons;
            }
        }

        public IList<IStudent> Students
        {
            get
            {
                return this.students;
            }
        }

        public IList<ITrainer> Trainers
        {
            get
            {
                return this.trainers;
            }
        }
    }
}
