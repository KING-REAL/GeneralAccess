using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAccess.Entities
{
    /// <summary>
    /// 用户
    /// </summary>
    public class AuthUser
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 默认名
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public int UserType { get; set; }

        /// <summary>
        /// 是否锁定
        /// </summary>
        public bool IsLocked { get; set; }

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
