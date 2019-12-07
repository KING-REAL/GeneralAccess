using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAccess.Framework.Resources
{
    public class IconResources
    {
        /// <summary>
        /// 图标标识
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 图标代码
        /// </summary>
        public string iconcode { get; set; }

        /// <summary>
        /// 图标大小
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 图标颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 自定义图标
        /// </summary>
        public string Custom { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }

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
        public Nullable<DateTime> createdtime { get; set; }

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
