using Microsoft_videos.Classes;

// ARRAYS

// arrays are used when you want fixed memory
// var names = new string[] { "Scott0", "Ana1", "Felipe2" }; // immutable
// string[] names = ["Scott0", "Ana1", "Felipe2"]; // immutable

// names = [..names, "Damien3"]; // adding to an array in C# 12 

// foreach (var name in names)
// {
//   Console.WriteLine(name);
// }

// LISTS

// var names = new List<string> { "Scott0", "Ana1", "Felipe2" }; // mutable
// List<string> names = ["Scott0", "Ana1", "Felipe2"]; // mutable
// names.Add("Maria3");
// names.Add("Bill4");
// names.Remove("Ana");


// foreach (var name in names[2..4])
// {
//   Console.WriteLine(name);
// }

// FINDING

// int index = names.IndexOf("Felipe2");
// if (index != -1) Console.WriteLine($"The name {names[index]} is at index {index}.");

// SORTING

// names.Sort();
// foreach (var name in names) Console.WriteLine(name);

// var numbers = new List<int> { 91, 54, 15, 23, 4, 54, 45 }; // mutable
// List<int> numbers = [91, 54, 15, 23, 4, 54, 45]; // mutable
// numbers.Sort();
// foreach (var num in numbers) Console.WriteLine(num);

// Console.WriteLine(numbers.IndexOf(23));

// OTHER TYPES OF LIST

// var fibNums = new List<int> {1, 1};
// List<int> fibNums = [1, 1];
// int previous = fibNums[^1];

// int i = 0;
// while (i < 18)
// {
//     fibNums.Add(fibNums[^2] + fibNums[^1]);
//     i++;
// }

// Console.WriteLine(string.Join(", ", fibNums));

// LINQ

// Specify the data source.
// int[] scores = [100, 97, 92, 81, 200, 60];

// Define the query expression.
// IEnumerable<int> scoreQueryInt = from x in scores where x > 80 orderby x descending select x;
// IEnumerable<string> scoreQueryStr = from x in scores where x > 80 orderby x descending select $"The score is {x}";

// Execute the query.
// Console.Write(string.Join(", ", scoreQueryInt));
// foreach (var i in scoreQueryStr) Console.WriteLine(i);


// The Three Parts of a LINQ Query:
// 1. Data source.
int[] numbers = [ 0, 1, 2, 3, 4, 5, 6 ];

// 2. Query creation.
// numQuery is an IEnumerable<int>
var numQuery = from num in numbers where (num % 2) == 0 select num;

// making it a list
List<int> numQuery1 = (from num in numbers where (num % 2) == 0 select num).ToList();
List<int> numQuery2 = [..numbers.Where(x => x % 2 == 0).OrderByDescending(x => x)];

// making it an array
int[] numQuery3 = (from num in numbers where (num % 2) == 0 select num).ToArray();
int[] numQuery4 = [..numbers.Where(x => x % 2 == 0).OrderByDescending(x => x)];

// 3. Query execution.
// foreach (int num in numQuery4) Console.WriteLine(num);

// MAKING ARRAYS
// int[] array0 = [1, 2, 3];
// int[] array1 = new int[] {1, 2, 3};

// string[] array2 = ["ab", "c"];
// string[] array3 = new string[] {"ab", "c"};

// MAKING LISTS
// List<int> list0 = [1, 2, 3];
// List<int> list1 = new List<int> {1, 2, 3};

// List<string> list2 = ["hello", "world"];
// List<string> list3 = new List<string> {"hello", "world"};
// List<string> list4 = [..list2];
// Console.WriteLine(string.Join(" ", list4));

// MAKING DICTIONARIES
// Dictionary<string, object> dict0 = new() 
// { 
//     { "name", 3 }, 
//     {"age", 4} 
// };

// Console.WriteLine(dict0["age"]);


// CLASSES
Person John = new ("John", "Meresurmizesir");
var Mary = new Person("Mary", "Johnson", new DateOnly(1990, 1, 1));
John.Pets.Add(new Dog("Fido"));
John.Pets.Add(new Dog("Willy"));

// John.Pets[0].MakeSound();

List<Person> people = [John, Mary];

// foreach (var person in people)
// {
//     person.Introduce("everyone");
// }

// foreach ( var p in people)
// {
//     Console.WriteLine(p.Name);

//     foreach (var pet in p.Pets)
//     {
//         Console.WriteLine(pet.ToString());
//     }
// }

// var fido = (from pet in John.Pets where pet.Name == "Fido" select pet.Name).ToList();
var fidoList = John.Pets.Where(pet => pet.Name == "Fido").ToList(); 
var fido = fidoList[0];
Console.WriteLine(fido.Name);