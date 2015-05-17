using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfPeople
{
    public static class Data
    {
        public static Person[] All()
        {
            var all = new Person[] {

                new Person()  {
                    id = 1,
                    firstName = "John",
                    lastName = "Papa",
                    age = 25,
                    location = "Florida"
                },
                new Person()  {
                    id= 2,
                    firstName= "Ward",
                    lastName= "Bell",
                    age= 31,
                    location= "California"
                },
                new Person()  {
                    id= 3,
                    firstName= "Colleen",
                    lastName= "Jones",
                    age= 21,
                    location= "New York"
                },
                new Person()  {
                    id= 4,
                    firstName= "Madelyn",
                    lastName= "Green",
                    age= 18,
                    location= "North Dakota"
                },
                new Person()  {
                    id= 5,
                    firstName= "Ella",
                    lastName= "Jobs",
                    age= 18,
                    location= "South Dakota"
                },
                 new Person() {
                    id= 6,
                    firstName= "Landon",
                    lastName= "Gates",
                    age= 11,
                    location= "South Carolina"
                },
                 new Person() {
                    id= 7,
                    firstName= "Haley",
                    lastName= "Guthrie",
                    age= 35,
                    location= "Wyoming"
                },
                 new Person() {
                    id= 8,
                    firstName= "Aaron",
                    lastName= "Jinglehiemer",
                    age= 22,
                    location= "Utah"
                }
            };

            return all;
        }
    }

    public class Person
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public int age { get; set; }
        public string location { get; set; }

    }
}