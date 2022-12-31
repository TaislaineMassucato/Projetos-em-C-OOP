using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPost.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }

        public Comment(string texto)
        {
            Text= texto;
        }
    }
}
