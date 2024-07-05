using Microsoft_videos.Classes;

// Without constructor
// Person John = new()
// {
//     FirstName = "John",
//     LastName = "Meresurmizesir"
// };

// OR
// var John = new Person()
// {
//     FirstName = "John",
//     LastName = "Meresurmizesir",
//     Birthdate = new DateOnly(1990, 1, 1)
// };

// With constructor
Person John = new ("John", "Meresurmizesir");
var Mary = new Person("Mary", "Johnson", new DateOnly(1990, 1, 1));

List<Person> people = [John, Mary];

foreach (var person in people)
{
    person.Introduce("everyone");
}