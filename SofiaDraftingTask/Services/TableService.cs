using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ExcelDataReader;
using SofiaDraftingTask.Data;
using SofiaDraftingTask.Services.Models;
using static SofiaDraftingTask.Data.DataConstants;

namespace SofiaDraftingTask.Services
{
    public class TableService : ITableService
    {
        public async Task<IEnumerable<PersonServiceModel>> GetPeople()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            await using var stream = File.Open(DataConstants.PeopleXlsxPath, FileMode.Open, FileAccess.Read);
            using var reader = ExcelReaderFactory.CreateReader(stream);
            reader.Read(); //skip 1st row
            reader.Read(); //skip 2nd row
            var people = new List<PersonServiceModel>();
            while (reader.Read()) //Each ROW
            {
                people.Add(new PersonServiceModel()
                {
                    Name = reader[0].ToString(),
                    Surname = reader[1].ToString(),
                    Location = reader[2].ToString(),
                    Email = reader[3].ToString()
                });
            }
            return people;
        }
    }
}
