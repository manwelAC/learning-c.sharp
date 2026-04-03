string sayHello = "Hello World";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Hi");
Console.WriteLine(sayHello);

//Mistakes 
// sayHello = sayHello.Replace("Hi", "Kumusta?");
// Earlier in my learning I tried to use "Hi" and it did not work because the text it is replacing
// is not existing in the variable sayHello.

//Applied Learning
string englishGreeting = "Hello Friend!!";
Console.WriteLine(englishGreeting);

string filipinoGreeting = englishGreeting.Replace("Hello", "Kumusta");
Console.WriteLine(filipinoGreeting);

// the expected output is "Hello Friend!!" since the variable englishGreeting contains "Hello Friend!!"
// the expected output for the second line is "Kumusta Friend!!" since the variable filipinoGreeting contains "Kumusta Friend!!"

//Changing the case of the string 
Console.WriteLine(englishGreeting.ToUpper());
Console.WriteLine(englishGreeting.ToLower());

string myFriend = " Shawn";
string myOtherFriend = " Karl";

string myFriendTrimmed = myFriend.Trim();
string myOtherFriendTrimmed = myOtherFriend.Trim();
string myFriendGreeting = "Hello Kumusta?";
string myOtherFriendGreeting = myFriendGreeting.Replace("Kumusta", "Bounjour");

//Applied Learning of all the methods I have learned from string, whitespace, and the multiple strings.
Console.WriteLine($"My Friend {myFriendTrimmed} says {myFriendGreeting} and his name has {myFriendTrimmed.Length} letters");
Console.WriteLine($"My Other Friend {myOtherFriendTrimmed} says {myOtherFriendGreeting} and his name has {myOtherFriendTrimmed.Length} letters");
