// Console.WriteLine("welcome to MGQS: Input your gender");
// string gender = Console.ReadLine()!;
// gender = gender.ToLower();

// switch(gender)
// {
//     case"male":
//         Console.WriteLine("Assalamualaikum you are a male student");
//     break;
//     case"female":
//         Console.WriteLine("Assalamualaikum you are a female stdent");
//     break;

//     default:
//     Console.WriteLine("You can go to Yaba left.");
//     break;
// }


Console.WriteLine("Your Mtn Data Subscribtion Reminder: Input No of day");
int daysReminder  = Convert.ToInt32(Console.ReadLine())!;

if (daysReminder == 5)
{
    Console.WriteLine("Dear customer your data will expire in 4 days rollover to enjoy 20% discount");
}

else if (daysReminder >=2 && daysReminder <=4)
{
    Console.WriteLine("Dear customer your subscribtion will soon finish");
}
else if (daysReminder == 1)
{
    Console.WriteLine("Dear customer ypur subscribtion will expire tommorrow");
}

else 
{
    Console.WriteLine("Dear customer u do not have any active data plan");    
}

Console.WriteLine("THANKS for using mtn");
 