using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDAL
    {
        List<Comment> GetAll();
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
        Comment GetById(int id);
    }
}
