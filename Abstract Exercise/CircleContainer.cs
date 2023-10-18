class CircleContainer : Container{
    public override double AreaOfBase(int length)
    {
        double area = Math.PI * (length / 2) * (length / 2);
        Console.WriteLine("The area of the square is {0}", area);
        return area;
    }
}