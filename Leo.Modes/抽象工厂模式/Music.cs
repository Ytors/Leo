using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leo.Model
{
    public abstract class Music
    {
        public string Title { get; set; }
        public string Singer { get; set; }
        public abstract string Play();
    }
}