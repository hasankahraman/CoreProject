using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EFWriterRepository : GenericRepository<Writer>, IWriterDAL
    {
        public bool Login(Writer writer)
        {
            using var context = new Context();
            var result = context.Writers.FirstOrDefault(x => x.Email == writer.Email && x.Password == writer.Password);

            if (result != null)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
