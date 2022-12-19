using System;
using System.Linq;

namespace OOOPovaryonok.Classes
{
    public class Roles
    {
        private int? _roleID;
        private string _nameRole;
        
        public int RoleID { get { return (int)_roleID; } }
        public string RoleName { get { return _nameRole; } }

        public Roles()
        {

        }

        public Roles(string login, string secret)
        {
            GetRole(login, secret);
        }

        public void Deconstruct(out int userID, out string userRole)
        {
            userID = (int)_roleID;
            userRole = _nameRole;
        }

        public void GetRole(string login, string secret)
        {
            try
            {
                var temp = SQLDatabaseHelper.DatabaseContext.User.
                    Where(x => x.UserLogin == login && x.UserPassword == secret).FirstOrDefault().UserRole;

                _roleID = temp;
                
                _nameRole = SQLDatabaseHelper.DatabaseContext.Role.
                    Where(x => x.RoleID == _roleID).FirstOrDefault().RoleName;

            }
            catch (Exception)
            {
                _roleID = -1;
                _nameRole = "Гость";        
            }
        }
        

        public void Guest()
        {
            this._roleID = -1;
            this._nameRole = "Гость";
        }
    }
}
