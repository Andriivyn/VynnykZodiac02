using System;
using System.Threading.Tasks;
namespace Vynnyk02.Entities
{
    public class BirthInfo
    {
        private DateTime _birthDate;

        public DateTime BirthDate => _birthDate;

        public async Task SetBirthDateAsync(DateTime birthDate)
        {
            var today = DateTime.Now;
            int age = await CalcAge(birthDate, today);

            if (age >= 0 && age <= 135)
            {

                _birthDate = birthDate;
                IsBornToday = _birthDate.Day == today.Day && _birthDate.Month == today.Month;
                Age = age;
            }
        }


        private static Task<int> CalcAge(DateTime birthDate, DateTime today)
        {
            return Task.Run(() =>
            {
                var age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age)) return --age;
                return age;
            });
        }

        public int Age { get; private set; } = -1;

        public bool IsBornToday { get; private set; }
    }
}