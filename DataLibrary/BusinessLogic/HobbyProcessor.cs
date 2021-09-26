using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class HobbyProcessor
    {
        public static int CreateHobby(string name)
        {
            HobbyModel data = new HobbyModel
            {
                Name = name,
            };


            string sql = @"INSERT INTO dbo.Hobby (Name)
SELECT @Name
WHERE NOT EXISTS (SELECT * FROM dbo.Hobby WHERE Name = @Name)";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static int DeleteHobby(int id)
        {
            string sql = string.Format("DELETE FROM dbo.Hobby WHERE Id={0};",id);

            return SqlDataAccess.DeleteData<HobbyModel>(sql);
        }
        public static HobbyModel GetHobby(string name)
        {
            string sql = string.Format("select Id, Name from dbo.Hobby WHERE Name={0};",name);
            var hobbies = SqlDataAccess.LoadData<HobbyModel>(sql);
            if (hobbies.Count == 0)
            {
                return null;
            }

            return hobbies.First();
        }
        public static List<HobbyModel> LoadHobby()
        {
            string sql = @"select Id, Name from dbo.Hobby;";

            return SqlDataAccess.LoadData<HobbyModel>(sql);
        }

    }
}
