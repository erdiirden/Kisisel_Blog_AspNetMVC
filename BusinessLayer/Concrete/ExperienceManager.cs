using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void TAdd(IExperienceService t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public void TDelete(IExperienceService t)
        {
            throw new NotImplementedException();
        }

        public Experience TGetByID(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }

        public void TUpdate(IExperienceService t)
        {
            throw new NotImplementedException();
        }

        IExperienceService IGenericService<IExperienceService>.TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<IExperienceService> IGenericService<IExperienceService>.TGetList()
        {
            throw new NotImplementedException();
        }
    }
}
