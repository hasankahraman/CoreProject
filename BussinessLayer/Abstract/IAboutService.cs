using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IAboutService
    {
        void AddAbout(About about);
        void UpdateAbout(About about);
        void DeleteAbout(About about);
        List<About> GetAllAbouts();
        About GetAboutById(int id);
    }
}
