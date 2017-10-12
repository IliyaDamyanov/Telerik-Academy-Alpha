using System;
using Problem_1.School_classes.Interfaces;

namespace Problem_1.School_classes
{
    public class Disciplines : IName , ICommentable
    {
        private string name;
        private int numberOfLecures;
        private int numberOfExercises;
        private string comment;

        public Disciplines(string name, int numberOfLecures, int numberOfExercises,string comment=null)
        {
            this.Name = name;
            this.NumberOfLecures = numberOfLecures;
            this.NumberOfExercises = numberOfExercises;
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name must be at least 1 char.");
                }
                this.name = value;
            }
        }

        public int NumberOfLecures
        {
            get
            {
                return this.numberOfLecures;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("The number of lectures must be bigger than 0.");
                }
                this.numberOfLecures = value; 
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of exercises must be bigger than 0.");
                }
                this.numberOfExercises = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }
    }
}
