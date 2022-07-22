using Business.Abstract;
using DataAccess.Concrete;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentService:Repository<Comments>, ICommentService
    {
        public CommentService(BlogContext context):base (context)
        {

        }
    }
}
