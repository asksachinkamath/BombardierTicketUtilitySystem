using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public static class MappingHelper
    {
        public static void mapUserDtoToTbl(UserDTO userDto, UserDetailTbl userTbl)
        {
            userTbl.DateCreated = userDto.DateCreated;
            userTbl.Email = userDto.Email;
            userTbl.PassWord = userDto.PassWord;
            userTbl.PSA = userDto.PSA;
            userTbl.Role = userDto.Role;
            userTbl.UserName = userDto.UserName;
        }

        public static void mapUserTblToDto(UserDTO userDto, UserDetailTbl userTbl)
        {
            userDto.DateCreated = userTbl.DateCreated;
            userDto.Email = userTbl.Email;
            userDto.Id = userTbl.Id;
            userDto.PassWord = userTbl.PassWord;
            userDto.PSA = userTbl.PSA;
            userDto.Role = userTbl.Role;
            userDto.UserName = userTbl.UserName;
        }

        public static void mapCategoryDtoToTbl(CategoryDTO catDto, CategoryTbl catTbl)
        {
            catTbl.Id = catDto.Id;
            catTbl.CategoryName = catDto.CategoryName;

            if (catTbl.Applications != null)
            {
                catDto.Applications.ForEach(
                    app =>
                    {
                        var appTbl = new ApplicationTbl();
                        appTbl.ApplicationName = app.ApplicationName;
                        appTbl.Id = app.Id;
                        appTbl.CategoryId = app.CategoryId;
                        catTbl.Applications.Add(appTbl);
                    });
            }
        }

        public static void mapCategoryTblToDto(CategoryDTO catDto, CategoryTbl catTbl)
        {
            catDto.Id = catTbl.Id;
            catDto.CategoryName = catTbl.CategoryName;

            if (catTbl.Applications != null)
            {
                catTbl.Applications.ForEach(
                    app =>
                    {
                        var appDto = new ApplicationDTO();
                        appDto.ApplicationName = app.ApplicationName;
                        appDto.Id = app.Id;
                        appDto.CategoryId = app.CategoryId;
                        catDto.Applications.Add(appDto);
                    });
            }
        }

        public static void mapApplicationDtoToTbl(ApplicationDTO appDto, ApplicationTbl appTbl)
        {
            appTbl.ApplicationName = appDto.ApplicationName;
            appTbl.Id = appDto.Id;
            appTbl.CategoryId = appDto.CategoryId;

            appTbl.Category = new CategoryTbl();
            appTbl.Category.CategoryName = appDto.Category.CategoryName;
            appTbl.Category.Id = appDto.Category.Id;
        }

        public static void mapApplicationTblToDto(ApplicationDTO appDto, ApplicationTbl appTbl)
        {
            appDto.ApplicationName = appTbl.ApplicationName;
            appDto.Id = appTbl.Id;
            appDto.CategoryId = appTbl.CategoryId;

            appDto.Category = new CategoryDTO();
            appDto.Category.CategoryName = appTbl.Category.CategoryName;
            appDto.Category.Id = appTbl.Category.Id;
        }
    }
}
