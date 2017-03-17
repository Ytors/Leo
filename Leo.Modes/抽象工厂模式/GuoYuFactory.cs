using Leo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leo.Factory
{
    public class GuoYuFactory : XFactory
    {
        public override Movie CreateMovie()
        {
            return new GuoYuMovie() { Name = "功夫", Aactor = new List<string>() { "周星驰", "王圣依" } };
        }

        public override Music CreateMusic()
        {
            return new GuoYuMusic() { Title = "那个男人", Singer = "杨宗纬" };
        }
    }
}