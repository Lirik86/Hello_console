int a = 2;
int b = 4;
int c = 9;
int d = 7;
int e = 5;
int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write("Вес самой тяжелой гири: ");
Console.Write(max);