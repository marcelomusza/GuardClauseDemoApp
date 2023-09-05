namespace HelperLibrary;
using Throw;

public class HelperMethods
{
    public int AgeInDecades(int age)
    {
        //if (age < 0)
        //{
        //    throw new ArgumentException("The age should not be less than zero.", nameof(age));
        //}

        //if (age > 130)
        //{
        //    throw new ArgumentException("The age should not be greater than 130.", nameof(age));
        //}

        //age.Throw().IfNegative();
        //age.Throw().IfGreaterThan(130);

        age.Throw()
           .IfNegative()
           .IfGreaterThan(130);

        return age / 10;
    }

    public string TestName(string? name)
    {
        name.ThrowIfNull()
            .IfEmpty()
            .IfWhiteSpace()
            .Throw("Sorry, you cannot use my name.")
            .IfEqualsIgnoreCase("Tim Corey");

        if (name.Contains("Tim"))
        {
            return "Great first name";
        }

        if (name.Contains("Corey"))
        {
            return "Great last name";
        }

        return "Way to be unique";
    }
}

