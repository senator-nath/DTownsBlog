﻿using System.ComponentModel.DataAnnotations;

namespace DTownsBlog.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<BlogPost> BlogPost { get; set; }
    }
}
