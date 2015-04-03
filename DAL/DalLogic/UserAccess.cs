using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;

namespace DAL
{
    public class UserAccess
    {
        public List<UserDTO> GetAllUsers()
        {
            var users = new List<UserDTO>();

            using (var dbCon = new ModelContext())
            {
                dbCon.UserDetails.ToList().ForEach(
                    usr => {
                        var userObj = new UserDTO();
                        MappingHelper.mapUserTblToDto(userObj, usr);
                        users.Add(userObj);
                    });
            }

            return users;
        }

        public UserDTO GetUserByUserNameOrEmailOrPSA(string paramValue)
        {
            var userObj = new UserDTO();

            using (var dbCon = new ModelContext())
            {
                UserDetailTbl userTbl = dbCon.UserDetails.FirstOrDefault(
                    usr => usr.UserName == paramValue ||
                        usr.PSA == paramValue || usr.Email == paramValue);

                if (userTbl != null)
                {
                    MappingHelper.mapUserTblToDto(userObj, userTbl);
                }
            }

            return userObj;
        }

        public void CreateUser(UserDTO user)
        {
            UserDetailTbl userTbl = new UserDetailTbl();

            MappingHelper.mapUserDtoToTbl(user, userTbl);

            using(var dbCon = new ModelContext())
            {
                dbCon.UserDetails.Add(userTbl);
                dbCon.SaveChanges();
            }
        }
    }
}
