string[] strs = {"3.45", "3.87", "87.98", "56.7"};

int strsCount = strs.Count();

double sum = 0;

for(int a = 0; a <= strsCount - 1; a++)
{
    sum = sum + Convert.ToDouble(strs[a]);
}

Console.WriteLine(sum);
