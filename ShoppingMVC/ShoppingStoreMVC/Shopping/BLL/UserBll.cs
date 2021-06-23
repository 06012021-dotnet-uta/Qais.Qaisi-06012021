using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RLL;
using Shopping.Models;

namespace BLL
{
    public class UserBll : IUserBll
    {
        private readonly RStore _context;
        public UserBll(RStore context)
        {
            this._context = context;
        }
        public async Task<bool> SaveNewUser(User Tuser)
        {

            await _context.Users.AddAsync(Tuser);

            try
            {

                await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine($"There Was a problem upday=ting {ex.InnerException}");

                return false;

            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"There Was a problem upday=ting {ex.InnerException}");

                return false;
                //throw new Exception("Exeption Thrown");
            }


            return true;
        }

    }
}
