using System;
using System.Linq;
using System.Collections.Generic;
using Problem_1.School_classes.Interfaces;

namespace Problem_1.School_classes
{
    public class Teacher : People
    {
        private readonly List<Disciplines> setOfDisciplines;

        public Teacher(string name , string comment = null, params Disciplines[] disciplines) : base(name, comment = null)
        {
            this.setOfDisciplines = disciplines.ToList();
        }

        public IEnumerable<Disciplines> SetOfDisciplines 
        {
            get
            {
                return this.setOfDisciplines;
            }
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.setOfDisciplines.Add(discipline);
        }

        public void RemoveDiscipline(Disciplines discipline)
        {
            this.setOfDisciplines.Remove(discipline);
        }
    }
}
