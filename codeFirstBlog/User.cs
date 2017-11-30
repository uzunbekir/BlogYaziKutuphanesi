using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstBlog
{
  public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        //Mapping
        public virtual List<Comment> Comments { get; set; }
    }
}
