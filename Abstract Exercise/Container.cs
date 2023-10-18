abstract class Container{
    public void CalculateVolume(int height, int length)
    {
        double volument = AreaOfBase(length) * height;
        Console.WriteLine("The volume is {0}", volument);
    }

    public abstract double AreaOfBase(int length);
}