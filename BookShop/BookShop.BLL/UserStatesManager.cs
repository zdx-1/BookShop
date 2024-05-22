﻿
using BookShop.DAL;

namespace BookShop.BLL
{
    public static class UserStatesManager
    {
        #region  显示用户状态颜色转换前的读取状态编号的方法

        /// <summary>
        /// 显示用户状态颜色转换前的读取状态编号的方法
        /// </summary>
        /// <param name="userStatesName">状态名</param>
        /// <returns></returns>
        public static int GetUserStatesByName(string name)
        {
            return UserStatesService.GetUserStatesByName(name);
        }

        #endregion
    }
}
