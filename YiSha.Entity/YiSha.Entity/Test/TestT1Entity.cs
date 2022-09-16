using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.Test
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2022-09-15 16:16
    /// 描 述：实体类
    /// </summary>
    [Table("Test_T1")]
    public class TestT1Entity : BaseExtensionEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool? Sex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int? Age { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool? IsEnale { get; set; }
    }
}
