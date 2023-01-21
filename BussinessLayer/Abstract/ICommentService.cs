using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(Comment comment);
        List<Comment> GetAllComments();
        Comment GetCommentById(int id);
    }
}
