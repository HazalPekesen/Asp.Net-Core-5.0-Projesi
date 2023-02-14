using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);

        //void CommentyDelete(Comment category);

        //void CommentUpdate(Comment category);
        List<Comment> GetList(int id);  //ben ekledim.
        List<Comment> GetCommentWithBlog();  //ben ekledim.

        //Comment GetById(int id);
    }
}
