using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstBlog
{
   public class Category:Entity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
       
        public virtual List<Article> Articles { get; set; }
    }
}
