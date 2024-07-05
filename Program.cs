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
List<int> fibNums = [1, 1];
int previous = fibNums[^1];

int i = 0;
while (i < 18)
{
    fibNums.Add(fibNums[^2] + fibNums[^1]);
    i++;
}

Console.WriteLine(string.Join(", ", fibNums));

// LINQ

// Specify the data source.
// int[] scores = [100, 97, 92, 81, 200, 60];

// Define the query expression.
// IEnumerable<int> scoreQuery = from x in scores where x > 80 orderby x descending select x;
// IEnumerable<string> scoreQuery = from x in scores where x > 80 orderby x descending select $"The score is {x}";

// Execute the query.
// foreach (var i in scoreQuery)
// {
    // Console.WriteLine(i);
    // Console.Write(string.Join(", ", scoreQuery));
    // Console.Write(scoreQuery);
// }

// Output: 97 92 81

// The Three Parts of a LINQ Query:
// 1. Data source.
// int[] numbers = [ 0, 1, 2, 3, 4, 5, 6 ];

// 2. Query creation.
// numQuery is an IEnumerable<int>
// var numQuery =
//     from num in numbers
//     where (num % 2) == 0
//     select num;

// List<int>? numQuery0 = [..numbers.Where(x => x % 2 == 0).OrderByDescending(x => x)];

// List<int> numQuery2 =
//     (from num in numbers
//         where (num % 2) == 0
//         select num).ToList();

// or like this:
// numQuery3 is still an int[]

// var numQuery3 =
// int[] numQuery3 =
//     (from num in numbers
//         where (num % 2) == 0
//         select num).ToArray();


// 3. Query execution.
// foreach (int num in numQuery0)Console.WriteLine(num);

// int[] array0 = [1, 2, 3];
// int[] array1 = new int[] {1, 2, 3};

// string[] array2 = ["ab", "c"];
// string[] array3 = new string[] {"ab", "c"};

// List<int> list0 = [1, 2, 3];
// List<int> list1 = new List<int> {1, 2, 3};

// List<string> list2 = ["hello", "world"];
// List<string> list3 = new List<string> {"hello", "world"};
// List<string> list4 = [..list2];
// Console.WriteLine(string.Join(" ", list4));

// Dictionary<string, object> dict0 = new() 
// { 
//     { "name", 3 }, 
//     {"age", 4} 
// };

// Console.WriteLine(dict0["age"]);


// CLASSES
// Person John = new ("John", "Meresurmizesir");
// var Mary = new Person("Mary", "Johnson", new DateOnly(1990, 1, 1));

// List<Person> people = [John, Mary];

// foreach (var person in people)
// {
//     person.Introduce("everyone");
// }