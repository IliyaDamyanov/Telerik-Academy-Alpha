using Academy.Models.Contracts;
using System.Collections.Generic;

namespace Academy.Core.Contracts
{
    public interface IEngine
    {
        void Start();

        IList<ISeason> Seasons { get;  }

        IList<IStudent> Students { get; }

        IList<ITrainer> Trainers { get; }
    }
}
