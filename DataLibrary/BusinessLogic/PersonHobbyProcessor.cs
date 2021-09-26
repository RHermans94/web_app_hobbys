using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class PersonHobbyProcessor
    {
        public static int AddHobbyToPerson(int personId, int hobbyId)
        {
            PersonHobbyModel data = new PersonHobbyModel
            {
                PersonId = personId,
                HobbyId = hobbyId
            };


            string sql = @"insert into dbo.PersonHobbies (PersonId, HobbyId) values (@PersonId, @HobbyId);";


            return SqlDataAccess.SaveData(sql, data);
        }
        public static int RemoveHobbyFromPerson(int personId, int hobbyId)
        {
            string sql = string.Format("DELETE FROM dbo.PersonHobbies WHERE personId={0} AND hobbyId={1};", personId, hobbyId);

            return SqlDataAccess.DeleteData<HobbyModel>(sql);

        }
        public static List<PersonHobbyModel> LoadPersonHobbies()
        {
            string sql = @"select Id, PersonId, HobbyId from dbo.PersonHobbies;";

            return SqlDataAccess.LoadData<PersonHobbyModel>(sql);
        }

        public static List<HobbyModel> LoadHobbiesFromPerson(int personId)
        {
            string sql = string.Format("SELECT Id, Name from dbo.Hobby WHERE Id IN (SELECT HobbyId FROM dbo.PersonHobbies WHERE PersonId = {0})", personId);

            //sql = string.Format("SELECT PersonId, HobbyId FROM dbo.PersonHobbies WHERE PersonId = {0}", personId);
            

            return SqlDataAccess.LoadData<HobbyModel>(sql);
        }
    }
}
