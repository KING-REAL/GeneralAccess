using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAccess.Entities
{
    /// <summary>
    /// 角色权限关联
    /// </summary>
    public class AuthRolePermissionMapping
    {
        /// <summary>
        /// 标识
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 角色标识
        /// </summary>
        public int AuthRoleID { get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        public AuthRole AuthRole { get; set; }

        /// <summary>
        /// 权限标识
        /// </summary>
        public int AuthPermissionID { get; set; }

        public AuthPermission AuthPermission { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public Nullable<DateTime> CreatedOn { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDeleted { get; set; }
    }
}
