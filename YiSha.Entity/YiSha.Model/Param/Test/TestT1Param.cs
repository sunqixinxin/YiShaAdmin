using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.Test
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2022-09-15 16:16
    /// 描 述：实体查询类
    /// </summary>
    public class TestT1ListParam
    {
        public string Name { get; set; }
        public int Sex { get; set; }
        public int AgeStart { get; set; }
        public int AgeEnd { get; set; }
        public int IsEnable { get; set; }
    }
}
