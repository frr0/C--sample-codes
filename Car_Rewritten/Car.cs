class Car
{
    private String color;
    public String _color
    {
        get
        {
            return color;
        }
        set
        {
            _color = color;
        }
    }

    private String brand;
    public String _brand
    {
        get
        {
            return brand;
        }
        set
        {
            _brand = brand;
        }
    }

    public Car(String c, String b)
    {
        color = c;
        brand = b;
    }


}
