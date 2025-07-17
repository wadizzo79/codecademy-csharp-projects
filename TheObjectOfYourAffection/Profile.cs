using System;

namespace DatingProfile
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        private string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Please enter a valid name.");
                }
            }
        }

        private int Age
        {
            get { return age; }
            set
            {
                if (value >= 18)
                {
                    age = value;

                }
                else
                {
                    throw new ArgumentException("Users must be at least 18 years of age");
                }
            }
        }

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.Name = name;
            this.Age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = [];
        }

        public string ViewProfile()
        {
            string result = "";
            foreach (string hobby in this.hobbies)
            {
                result += $"{hobby}";
            }
            if (hobbies.Length > 0)
            {
                string bio = $"{name},\n{age},\n{city},\n{country},\n{pronouns}, \n{result}";
                return bio;
            }
            else
            {
                return $"{name},\n{age},\n{city},\n{country},\n{pronouns}, \nNo hobbies listed";
            }
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

        public Profile(string name, int age) : this(name, age, "n/a", "n/a", "n/a")
        {

        }
    }
}
