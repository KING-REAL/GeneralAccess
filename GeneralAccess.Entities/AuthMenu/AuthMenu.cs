using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAccess.Entities
{
    /// <summary>
    /// 菜单
    /// </summary>
    public class AuthMenu
    {
        /// <summary>
        /// 菜单标识
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 菜单别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 父级菜单标识
        /// </summary>
        public Nullable<int> ParentID { get; set; }

        /// <summary>
        /// 父级菜单名称
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// 菜单层级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDeleted { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public Nullable<DateTime> CreatedOn { get; set; }

        /// <summary>
        /// 创建人标识
        /// </summary>
        public Nullable<int> CreatedByUserID { get; set; }                              

        /// <summary>
        /// 创建人登录名
        /// </summary>
        public string CreatedByLoginName { get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        public Nullable<DateTime> ModifiedOn { get; set; }

        /// <summary>
        /// 最近修改人标识
        /// </summary>
        public Nullable<int> ModifiedByUserID { get; set; }

        /// <summary>
        /// 最近修改人登录名
        /// </summary>
        public string ModifiedByLoginName { get; set; }
    }
}
