using Leo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leo.Factory
{
    public abstract class XFactory
    {
        public abstract Music CreateMusic();
        public abstract Movie CreateMovie();
    }
}