class Overload{
    public double CalculateArea(int length){
        return length * length;
    }

    public double CalculateArea(double length){
        return length * length;
    }

    public double CalculateArea(double length, double height){
        return length * height;
    }
}