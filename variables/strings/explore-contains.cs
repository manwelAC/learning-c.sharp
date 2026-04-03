string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

//Understanding: Contains is a method wherein it checks if the string that was in the parentheses
// is existing at the string, if it's existing it returns True, and if not then it returns False.

//Applied Learning
string birthdayGreeting = "Happy Birthday, Sana mas marami pang birthday ang dumating";
string meetingGreeting = "Hello, nice to meet you";

Console.WriteLine(birthdayGreeting.Contains("happy"));
Console.WriteLine(meetingGreeting.Contains("nice"));

// in my applied learning the expected output is False and True
// the first line expects happy but since the happy has an uppercase H, it returns false
// the second line expects nice and since it is existing in the variable meetingGreeting, it returns true

//Applied Learning of all the methods
//First I declared the string names of my friends
string myFriend = "Shawn  ";
string myOtherFriend = "  Karl";
//then I trimmed the whitespaces to their names
string myFriendTrimmed = myFriend.TrimEnd();
string myOtherFriendTrimmed = myOtherFriend.TrimStart();
//then I declared a greeting for my friends that will be called later
string myFriendGreeting = "Hello Kumusta?";
string myOtherFriendGreeting = myFriendGreeting.Replace("Kumusta", "Bounjour");
//I changed the case of the variable myFriendGreeting and the myOtherFriendGreeting
string myFriendUpper = myFriendGreeting.ToUpper();
string myOtherFriendLower = myOtherFriendGreeting.ToLower();
//then I used the Contain method to verify if the Hello is existing for both greetings
string myFriendContains = myFriendGreeting.Contains("Hello").ToString();
string myOtherFriendContains = myOtherFriendGreeting.Contains("Kumusta").ToString();
//I applied all the methods to display in the console
//first is I called the friend name and then I called the Upper cased greeting of that friend and his name length
Console.WriteLine($"{myFriendTrimmed} says {myFriendUpper} and his name has {myFriendTrimmed.Length} letters.");
Console.WriteLine($"Also He said that his greeting contains 'Kumusta': {myFriendContains}");
//same here at the second call 
//first is I called the friend name and then I called the lower cased greeting of that friend and his name length
Console.WriteLine($"{myOtherFriendTrimmed} says {myOtherFriendLower} and his name has {myOtherFriendTrimmed.Length} letters.");
Console.WriteLine($"Also He said that his greeting contains 'Kumusta': {myOtherFriendContains}");

//expected output is that for the contain method check of the second friend, it will show False since there is no Kumusta to his greetings but Bounjour.

