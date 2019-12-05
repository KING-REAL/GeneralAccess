using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAccess.Entities.AuthRole
{
    /// <summary>
    /// 角色
    /// </summary>
    public class AuthRole
    {
        /// <summary>
        /// 角色标识
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 角色代码
        /// </summary>
        public string RoleCode { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 是否系统管理员
        /// </summary>
        public bool IsSuperAdministrator { get; set; }

        /// <summary>
        /// 是否内置角色
        /// </summary>
        public bool IsBuiltin { get; set; }

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
