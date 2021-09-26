using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class PersonProcessor
    {
        public static int CreatePerson(string firstName, string lastName, string lastNamePrefixes)
        {
            PersonModel data = new PersonModel
            {
                FirstName = firstName,
                LastName = lastName,
                LastNamePrefix = lastNamePrefixes
            };

            string sql = @"insert into dbo.Person (FirstName, LastName, LastNamePrefix) values (@FirstName, @LastName, @LastNamePrefix);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<PersonModel> LoadPersons()
        {
            string sql = @"select Id, FirstName, LastName, LastNamePrefix from dbo.Person;";

            return SqlDataAccess.LoadData<PersonModel>(sql);
        }
        public static int DeletePerson(int id)
        {
            PersonHobbyProcessor.DeletePerson(id);

            string sql = string.Format("DELETE FROM dbo.Person WHERE Id={0};", id);

            return SqlDataAccess.DeleteData<PersonModel>(sql);
        }
        public static PersonModel GetPerson(int id)
        {
            string sql = string.Format("select Id, FirstName, LastName, LastNamePrefix from dbo.Person WHERE Id={0};",id);
            var items = SqlDataAccess.LoadData<PersonModel>(sql);
            if (items.Count != 0)
            {
                return items.First();
            }
            return new PersonModel();
        }
    }
}
