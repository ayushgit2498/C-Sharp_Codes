using System;

namespace OOP
{
    class Human
    {
        private string firstname;
        private string lastName;
        private string eyecolor;
        private int age;

        public string getFirstname()
        {
            return this.firstname;
        }

        public void setFirstname(string firstname)
        {
            this.firstname = firstname;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getEyecolor()
        {
            return this.eyecolor;
        }

        public void setEyecolor(string eyecolor)
        {
            this.eyecolor = eyecolor;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }


        public Human()
        {
            Console.WriteLine("I am a basic human.");
        }
        public Human(string firstname, string lastName, string eyecolor, int age)
        {
            this.firstname = firstname;
            this.lastName = lastName;
            this.eyecolor = eyecolor;
            this.age = age;
        }
        public Human(string firstname, string lastName)
        {
            this.firstname = firstname;
            this.lastName = lastName;
        }
        public Human(string firstname, string lastName, string eyecolor)
        {
            this.firstname = firstname;
            this.lastName = lastName;
            this.eyecolor = eyecolor;
        }
        public Human(string firstname)
        {
            this.firstname = firstname;
        }

        public void introduceMyself()
        {
            if (age != 0 && firstname != null && lastName != null && eyecolor != null)
            {
                Console.WriteLine("Hello!I am {0} {1} .I am {2} years old.My eyecolor is {3}", firstname, lastName, age, eyecolor);
            }
            else if (firstname != null && lastName != null && eyecolor != null)
            {
                Console.WriteLine("Hello!I am {0} {1}.My eyecolor is {2}", firstname, lastName, eyecolor);
            }
            else if (firstname != null && lastName != null)
            {
                Console.WriteLine("Hello!I am {0} {1}", firstname, lastName);
            }
            else if (firstname != null)
            {
                Console.WriteLine("Hello!I am {0}", firstname);
            }
            else
            {
                Console.WriteLine("Still a basic man");
            }
        }
    }
}