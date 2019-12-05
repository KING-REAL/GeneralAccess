using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAccess.Entities.AuthUserRoleMapping
{
    /// <summary>
    /// 用户角色关联
    /// </summary>
    public class AuthUserRoleMapping
    {
        /// <summary>
        /// 标识
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public int AuthUserID { get; set; }

        /// <summary>
        /// 角色标识
        /// </summary>
        public int AuthRoleID { get; set; }

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
