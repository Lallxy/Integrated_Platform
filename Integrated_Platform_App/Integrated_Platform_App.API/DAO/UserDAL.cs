
using Integrated_Platform_App.API.DAO.DateBaseConnect;
using Integrated_Platform_App.API.DAO.Interface;
using Integrated_Platform_App.Common.Models;
using Integrated_Platform_App.DAL;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Platform_App.DAL
{
    class UserDAL:IUserDAL
    {
        private readonly App_DbContext context;

        public UserDAL(App_DbContext context)
        {
            this.context = context;
        }

        public async Task<ForResult> AddAsync(User model)
        {
            try
            {
                await context.AddAsync<User>(model);
                if (context.SaveChanges() > 0)
                {
                    return new ForResult(true, model);
                }
                else
                {
                    return new ForResult("用户添加失败");
                }
            }
            catch (Exception ex)
            {
                return new ForResult(ex.ToString());
               
            }
           
        }

        public async Task<ForResult> DeleteAsync(int id)
        {
            try
            {
                var user = await context.User.Where(u => u.Id == id).FirstOrDefaultAsync();
                if (user != null)
                {
                    context.User.Remove(user);
                    context.SaveChanges();
                    if (context.SaveChanges() > 0)
                    {
                        return new ForResult(true, "删除成功");
                    }
                    return new ForResult("删除不成功");
                }
                return new ForResult("未查找到数据");
            }
            catch (Exception ex)
            {

                return new ForResult(ex.ToString());
            }
            
        }

        public async Task<ForResult> GetSingleAsync(int id)
        {
            try
            {
                var user = await context.User.Where(u => u.Id == id).FirstOrDefaultAsync();
                if (user != null)
                {
                    return new ForResult(true, user);
                }
                return new ForResult("未查找到数据");
            }
            catch (Exception ex)
            {
                return new ForResult(ex.ToString());
            }
        }

        public async Task<ForResult> UpdateAsync(User model)
        {
            try
            {
                var user = await context.User.Where(u => u.Id ==model.Id).FirstOrDefaultAsync();
                user.Password = model.Password;
                user.CreatTime = System.DateTime.Now;

                if (context.SaveChanges() > 0)
                {
                    return new ForResult(true, model);
                }
                return new ForResult("更新不成功");
            }
            catch (Exception ex)
            {

                return new ForResult(ex.ToString());
            }
        }
    }
}
