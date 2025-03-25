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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonailDal _testimonialDal;

        public TestimonialManager(ITestimonailDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonail t)
        {
            _testimonialDal.Insert(t);
        }

        public void TDelete(Testimonail t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonail TGetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonail> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TUpdate(Testimonail t)
        {
            _testimonialDal.Update(t);
        }
    }
}
