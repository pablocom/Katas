namespace Kata.LeapYear;

public class Year
{
    private readonly int _year;

    public Year(int year)
    {
        _year = year;
    }

    public bool IsLeap()
    {
        if (!IsDivisibleBy(4))
            return false;
       
        if (IsDivisibleBy(100) && !IsDivisibleBy(400))
            return false;
        
        return true;
    }

    private bool IsDivisibleBy(int value)
    {
        return _year % value == 0;
    }
}