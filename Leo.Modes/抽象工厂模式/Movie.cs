using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leo.Model
{
    public abstract class Movie
    {
        public string Name { get; set; }
        public IList<string> Aactor { get; set; }
        public abstract string Show();
    }
}