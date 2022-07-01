namespace Kata.LeapYear.UnitTests;

public class YearShould
{
    [Fact]
    public void NotBeLeapYearIfIsNotDivisibleBy4()
    {
        var year = new Year(1997);

        var isLeapYear = year.IsLeap();

        isLeapYear.Should().BeFalse();
    }

    [Fact]
    public void BeLeapYearIfIsDivisibleBy4()
    {
        var year = new Year(1996);

        var isLeapYear = year.IsLeap();

        isLeapYear.Should().BeTrue();
    }

    [Fact]
    public void NotBeLeapYearIfDivisibleBy100ButNotBy400()
    {
        var year = new Year(1800);

        var isLeapYear = year.IsLeap();

        isLeapYear.Should().BeFalse();
    }
}