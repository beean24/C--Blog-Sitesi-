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
    public class InteractionService:Repository<Interaction>, IInteractionService
    {
        public InteractionService(BlogContext context): base(context)
        {

        }
    }
}
