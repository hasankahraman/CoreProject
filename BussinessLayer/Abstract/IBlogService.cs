using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetAllWithCategory();
		List<Blog> GetAllByWriter(int id);
        List<Blog> GetAll(int id);
	}
}
