double salary = 45000;
double tax = 0;

if(salary <= 8350)
{
    tax = salary * 0.10;
}
else if(salary> 8350 && salary <= 33950)
{
    tax = salary * 0.15;
}
else{
    tax = salary * 0.25;
}

Console.WriteLine(tax);
