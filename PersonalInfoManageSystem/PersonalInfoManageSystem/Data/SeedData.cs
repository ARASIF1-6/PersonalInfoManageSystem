using PersonalInfoManageSystem.Models;

namespace PersonalInfoManageSystem.Data
{
    public class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // If data already exists then skip
            if (context.PersonalInfos.Any())
                return;

            var rand = new Random();
            var list = new List<PersonalInfo>();

            for (int i = 1; i <= 1000; i++)
            {
                list.Add(new PersonalInfo
                {
                    FirstName = "User" + i,
                    LastName = "Test",
                    Email = $"user{i}@gmail.com",
                    PhoneNumber = "0170000" + rand.Next(1000, 9999),
                    DateOfBirth = DateTime.Now.AddYears(-rand.Next(18, 40)),
                    Gender = "Male",
                    Address = "Dhaka",
                    Nationality = "Bangladeshi",
                    CreatedDate = DateTime.Now
                });
            }

            context.PersonalInfos.AddRange(list);
            context.SaveChanges();
        }
    }
}
