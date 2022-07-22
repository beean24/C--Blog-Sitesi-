using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Interaction // Etkileşim
    {
        public int Id { get; set; }
        public int BlogsId { get; set; }
        public bool Status { get; set; } // True ise : Like / false ise Dislike
        public string IpAddress { get; set; }
        public Blogs Blogs { get; set; } // Her bir etkileşim bir bloga ait olmak zorunda
    }
}
