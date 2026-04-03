//Practicing how to trim whitespaces

//untrimmed
string greeting = "    Hello   ";

Console.WriteLine($"[{greeting}]");

//Trimming the start of the variable greeting

string StartTrimmedGreeting = greeting.TrimStart();

Console.WriteLine($"[{StartTrimmedGreeting}]");

//Trimming the end of the variable greeting

string EndTrimmedGreeting = greeting.TrimEnd();

Console.WriteLine($"[{EndTrimmedGreeting}]");

//Trimming all the Whitespace at the variable greeting

string TrimmedGreeting = greeting.Trim();

Console.WriteLine($"[{TrimmedGreeting}]");



//Applied learning

string firstFriend = " Shawn Kenneth France ";
string secondFriend = " Karl Christian Brizuela";

//Calling both Friends while also trimming their whitespaces while also counting the length of the string

string firstFriendTrim = firstFriend.Trim();
string secondFriendTrim = secondFriend.TrimStart();

Console.WriteLine($"My Friend {firstFriendTrim} has {firstFriendTrim.Length} letters ");
Console.WriteLine($"My Friend {secondFriendTrim} has {secondFriendTrim.Length} letters ");