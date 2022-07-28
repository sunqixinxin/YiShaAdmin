﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.SystemManage
{
    /// <summary>
    /// 菜单权限表
    /// </summary>
    [Table("SysMenuAuthorize")]
    public class MenuAuthorizeEntity : BaseCreateEntity
    {
        /// <summary>
        /// 菜单Id
        /// </summary>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? MenuId { get; set; }

        /// <summary>
        /// 授权Id(角色Id或者用户Id)
        /// </summary>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? AuthorizeId { get; set; }

        /// <summary>
        /// 授权类型(1角色 2用户)
        /// </summary>
        public int? AuthorizeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [NotMapped]
        public string? AuthorizeIds { get; set; }
    }
}