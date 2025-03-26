int num = 10;
string a = (num % 2 == 0) ? "even" : "odd";
Console.WriteLine(a);


int num1 = 20;
string b = (num1 > 0) ? "positive" : (num1 < 0) ? "negative" : "zero";
Console.WriteLine(b);

int year = 2025;
string result = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) ? "leap year" : "not aleap year";
Console.WriteLine(result);

int mark = 55;

string s = (mark > 90) ? "s Grade" :
       (mark > 80) ? "a Grade" :
       (mark > 70) ? "b Grade" :
       (mark > 60) ? "c Grade" :
       (mark > 50) ? "d Grade" :
       (mark > 40) ? "e Grade" :
       (mark < 40) ? " student failed" :
       "invalid mark";
Console.WriteLine(s);