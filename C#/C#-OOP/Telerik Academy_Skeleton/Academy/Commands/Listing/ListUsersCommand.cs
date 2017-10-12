using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using Academy.Models.Contracts;
using System.Collections.Generic;

namespace Academy.Commands.Listing
{
    public class ListUsersCommand : ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;
        private IList<IStudent> students;
        private IList<ITrainer> trainers;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
            this.students = engine.Students;
            this.trainers = engine.Trainers;
        }

        private string OverridingStudentsListAndTrainersList(IList<IStudent> students , IList<ITrainer> trainers)
        {
            string studentsString = string.Empty;
            for (int i = 0; i < students.Count; i++)
            {
                if (i==students.Count-1)
                {
                    studentsString += string.Format("{0}", students[i]);
                    break;
                }
                studentsString += string.Format("{0}\n", students[i]);
            }
            string trainersString = string.Empty;
            for (int i = 0; i < trainers.Count; i++)
            {
                if (i==trainers.Count-1)
                {
                    trainersString += string.Format("{0}", trainers[i]);
                    break;
                }
                trainersString += string.Format("{0}\n", trainers[i]);
            }
            return string.Format(@"{0}
{1}", trainersString, studentsString);
        }

        public string Execute(IList<string> parameters)
        {
            return OverridingStudentsListAndTrainersList(this.students, this.trainers);
        }
    }
}
