using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstBlog
{
    public class Article : Entity
    {
        public Article()
        {
            ModifiedDate = DateTime.Now;
        }
        public DateTime ModifiedDate { get; set; }
        public int ArticleId { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }

        public int CategoryId { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual Category Categories {get;set;}
    }
}
