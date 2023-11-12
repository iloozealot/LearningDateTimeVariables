

using System.Globalization;

//DateTime today = DateTime.Now;

DateTime today = DateTime.UtcNow;

//DateTime birthday = DateTime.Parse("6/15/1998");
//DateTime birthday = DateTime.ParseExact("6/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);


Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));
//Console.WriteLine(birthday.ToString());