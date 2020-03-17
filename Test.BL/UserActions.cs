using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.EL;
using Test.EL.Models;

namespace Test.BL
{
    public class UserActions 
    {
        public Object  UserList()
        {
            using (var db = new AbhijeetDbEntities())
            {
                var data = db.Users.ToList();
                return data;
            }
            
        }

        public void AddUser(User obj)
        {
            using (var db = new AbhijeetDbEntities())
            { 
                db.Users.Add(obj);
                db.SaveChanges();
            }
        }

        
    }
}
