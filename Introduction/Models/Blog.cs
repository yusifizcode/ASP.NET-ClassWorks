using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introduction.Models
{
    public class Blog
    {

        public Blog(int id,string name,string content,string image)
        {
            this.Id = id;
            this.Name = name;
            this.Content = content;
            this.Image = image;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
    }
}
