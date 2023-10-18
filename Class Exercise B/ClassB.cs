class classB{
    public string[] str { get; set; }

    public classB(string[] str)
    {
        this.str = str;
    }

    public double Calculate(){
        int strsCount = str.Count();

        double sum = 0;

        for(int a = 0; a <= strsCount - 1; a++)
        {
            sum = sum + Convert.ToDouble(str[a]);
        }

        return sum;
    }
}