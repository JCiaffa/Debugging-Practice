﻿// Challenge 1

// bool amProgrammer = true;
// double Age = 27.9;

// List<string> Names = new List<string>();
// Names.Add("Monica");

// Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
// MyDictionary.Add("Hello", "a");
// MyDictionary.Add("Hi there", "b");


// string MyName = "MyName";

// Challenge 2
// Console.WriteLine("Challenge 2");
// List<int> Numbers = new List<int>() {2,3,6,7,1,5};
// for(int i = Numbers.Count -1; i >= 0; i--)
// {
//     Console.WriteLine(Numbers[i]);
// }


// // Challenge 3
// Console.WriteLine("Challenge 3");
// List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
// foreach(int i in MoreNumbers)
// {
//     Console.WriteLine($"{i}");
// }

// // Challenge 4
// Console.WriteLine("Challenge 4");
// List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
// foreach(int num in EvenMoreNumbers){
//   if(num % 3 == 0)
//     {
//         num = 0;
//     }
// }


// // Challenge 5
// What can we learn from this error message?
// string MyString = "superduberawesome";
// MyString[7] = "p";
//impossible
// strings are immutable once constructed


// Challenge 6
// Hint: some bugs don't come with error messages
Console.WriteLine("Challenge 6");
Random rand = new Random();
int randomNum = rand.Next(5);
if(randomNum == 2)
{
    Console.WriteLine("Hello");
}
