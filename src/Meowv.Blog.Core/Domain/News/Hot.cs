﻿using System;
using System.Collections.Generic;

namespace Meowv.Blog.Domain.News
{
    public class Hot : EntityBase
    {
        /// <summary>
        /// <see cref="KnownSources"/>
        /// </summary>
        public string Source { get; set; }

        public List<Data> Datas { get; set; } = new List<Data>();

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public static class KnownSources
        {
            public const string cnblogs = "博客园";

            public const string v2ex = "V2EX";

            public const string segmentfault = "思否";

            public static Dictionary<string, string> Dictionary { get; set; } = new Dictionary<string, string>
            {
                { cnblogs, "https://www.cnblogs.com" },
                { v2ex, "https://www.v2ex.com/?tab=hot" },
                { segmentfault, "https://segmentfault.com/hottest" }
            };
        }
    }

    public class Data
    {
        public string Title { get; set; }

        public string Url { get; set; }
    }
}