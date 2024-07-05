// namespace Microsoft_videos.Classes
// {
//     public class Person
//     {
//         public string? FirstName { get; set; }
//         public string? LastName { get; set;}
//         public string Name
//         {
//             get
//             {
//                 return $"{FirstName} {LastName}";
//             }
//         }

//         public DateOnly Birthdate { get; set; }

//         public void Introduce(string to)
//         {
//             Console.WriteLine("Hi {0}, I am {1}. My birthday is {2}.", to, Name, Birthdate);
//         }
//     }
// }

namespace Microsoft_videos.Classes
{
    public class Person(string firstName, string lastName, DateOnly? birthdate = null)
    {
        private string? FirstName { get; set; } = firstName;
        private string? LastName { get; set; } = lastName;
        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        private DateOnly? Birthdate { get; set; } = birthdate;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}. " + (Birthdate.HasValue ? $"My birthday is {Birthdate}." : ""));
        }
    }
}