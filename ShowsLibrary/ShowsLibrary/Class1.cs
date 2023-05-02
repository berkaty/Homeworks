using System;
using HRLibrary;
using ShowsLibrary;

namespace HRLibrary
{
    public class Showw
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly DateTime Birthday;
        public readonly Gender Gender;
        private string v1;
        private string v2;
        private string v3;
        private Frequency daily;
        private string v4;

        public int Age => DateTime.Now.Year - Birthday.Year;

        public Showw(string name, string surname, string birthday, Gender gender)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Birthday = DateTime.Parse(birthday);
        }

        public Showw(string v1, string v2, string v3, Frequency daily, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.daily = daily;
            this.v4 = v4;
        }

        public string GetInfo()
        {
            var gender = "";

            if (Gender == Gender.Male)
                gender = "мужской";
            else if (Gender == Gender.Female)
                gender = "женский";
            return $"{Name} {Surname}. Датарождения: {Birthday:d}. " + $"Пол: {gender}. Возраст: {Age}.";
        }
    }
}
