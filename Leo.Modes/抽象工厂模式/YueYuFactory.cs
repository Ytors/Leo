using Leo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leo.Factory
{
    public class YueYuFactory : XFactory
    {
        public override Movie CreateMovie()
        {
            return new YueYuMovie() { Name = "无间道", Aactor = new List<string>() { "刘德华", "梁朝伟" } };
        }

        public override Music CreateMusic()
        {
            return new YueYuMusic() { Title = "偏偏喜欢你", Singer = "陈百强" };
        }
    }
}