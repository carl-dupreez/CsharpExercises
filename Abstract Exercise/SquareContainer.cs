class SquareContainer : Container{
    public override double AreaOfBase(int length)
    {
        double area = length * length;
        Console.WriteLine("The area of the square is {0}", area);
        return area;
    }
}