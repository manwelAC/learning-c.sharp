string firstFriend = "Shawn ";
string secondFriend = " Karl";

//Applying Trimmed Lesson
string firstFriendTrimmed = firstFriend.TrimEnd();
string secondFriendTrimmed = secondFriend.TrimStart();

//Applying Replace Lesson
string firstFriendGreeting = "Masaya ka pa ba?";
string secondFriendGreeting = firstFriendGreeting.Replace("Masaya", "Happy");

//Applying ToUpper and ToLower Lesson
string firstFriendUpper = firstFriendGreeting.ToUpper();
string secondFriendLower = secondFriendGreeting.ToLower();

//Applying Contains Lesson
string firstFriendContains = firstFriendGreeting.Contains("Kumusta").ToString();
string secondFriendContains = secondFriendGreeting.Contains("Kumusta").ToString();

//Displaying the output in the console:
Console.WriteLine($"First friend {firstFriendTrimmed} says {firstFriendUpper} and his name has {firstFriendTrimmed.Length} letters.");
Console.WriteLine($"Also {firstFriendTrimmed} said that his greeting contains 'Kumusta:' {firstFriendContains} \n");
Console.WriteLine($"Second friend {secondFriendTrimmed} says {secondFriendLower} and his name has {secondFriendTrimmed.Length} letters.");
Console.WriteLine($"Also {secondFriendTrimmed} said that his greeting contains 'Kumusta:' {secondFriendContains}");

//2026-Apr-04