// // Challenge 1
// //should be boolean not string
// bool amProgrammer = "true";
// //integers can't have decimals
// int Age = 27.9;

// List<string> Names = new List<string>();
// // Cannot overwrite a whole list with one string
// Names = "Monica";
// Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
// MyDictionary.Add("Hello", "0");
// // Cannot put an integer where a string was expected
// MyDictionary.Add("Hi there", 0);
// // Single quotes are used to denote chars, not strings, in C#
// string MyName = 'MyName';

// // Challenge 2
// List<int> Numbers = new List<int>() {2,3,6,7,1,5};
// // i started out of bounds, which doesn't allow the loop to start
// for(int i = Numbers.Count; i >= 0; i--)
// {
//     Console.WriteLine(Numbers[i]);
// }

// // Challenge 3
// // MoreNumbers[i] would be pulling values like MoreNumbers[12] which is way out of bounds. 
// // Foreach loops already grab the value at an index and we do not need to reference the index
// List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
// foreach(int i in MoreNumbers)
// {
//     Console.WriteLine(MoreNumbers[i]);
// }

// // Challenge 4
// // Cannot assign a foreach iteration variable a value. A better option would be to use a standard for loop instead
// List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
// foreach(int num in EvenMoreNumbers)
// {
//     if(num % 3 == 0)
//     {
//         num = 0;
//     }
// }
// // Challenge 5
// // What can we learn from this error message?
// // We cannot edit strings using index values the same way we can an array or 
// // list because strings are read only values. This piece of code cannot execute
// string MyString = "superduberawesome";
// MyString[7] = "p";
// // Challenge 6
// // Hint: some bugs don't come with error messages
// // Random will only generate values between 0 and 11 
// // in this case, meaning we will never hit the if statement
// Random rand = new Random();
// int randomNum = rand.Next(12);
// if(randomNum == 12)
// {
//     Console.WriteLine("Hello");
// }

