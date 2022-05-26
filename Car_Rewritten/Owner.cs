public class Owner
{
    private String name;
    public String _name
    {
        get
        {
            return name;
        }
        set
        {
            _name = name;
        }
    }

    private String lastname;
    public String _lastname
    {
        get
        {
            return lastname;
        }
        set
        {
            _lastname = lastname;
        }
    }

    public Owner(String n, String ln)
    {
        name = n;
        lastname = ln;
    }
}
