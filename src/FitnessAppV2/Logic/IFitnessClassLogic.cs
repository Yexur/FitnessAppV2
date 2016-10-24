using ApplicationModels.FitnessAppV2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessAppV2.Logic
{
    public interface IFitnessClassLogic
    {
        //FitnessClass Get(int id);
        Task<List<FitnessClassListItem>>GetList();
        //void Save(FitnessClass fitnessClass);
        //void Delete(int id);
    }
}
