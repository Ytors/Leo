using Leo.Factory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Leo.Api.Controllers
{
    public class DefaultController : ApiController
    {
        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public int GetRandom()
        {
            return new Random().Next();
        }

        #region 抽象工厂示例

        public string GuoYu()
        {
            var factory = new GuoYuFactory();
            var music = factory.CreateMusic();
            var movie = factory.CreateMovie();

            return "{ " + $"Music:{JsonConvert.SerializeObject(music)},Movie:{JsonConvert.SerializeObject(movie)}" + " }";
        }

        public string YueYu()
        {
            var factory = new YueYuFactory();
            var music = factory.CreateMusic();
            var movie = factory.CreateMovie();

            return "{ " + $"Music:{JsonConvert.SerializeObject(music)},Movie:{JsonConvert.SerializeObject(movie)}" + " }";
        }

        #endregion


    }
}
