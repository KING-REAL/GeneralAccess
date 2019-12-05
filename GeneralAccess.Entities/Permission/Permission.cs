using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAccess.Entities.Permission
{
    /// <summary>
    /// 权限
    /// </summary>
    public class Permission
    {
        /// <summary>
        /// 标识
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 权限代码
        /// </summary>
        public string PermissionCode { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        public string PermissionName { get; set; }

        /// <summary>
        /// 菜单标识
        /// </summary>
        public int AuthMenuID { get; set; }

        /// <summary>
        /// 动作代码
        /// </summary>
        public string ActionCode { get; set; }

        /// <summary>
        /// 图标标识
        /// </summary>
        public int AuthIconID { get; set; }

        /// <summary>
        /// 权限类型
        /// </summary>
        public int PermissionType { get; set; }

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
