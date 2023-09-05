using HelperLibrary;

HelperMethods helpers = new();

int decades = helpers.AgeInDecades(43);
Console.WriteLine($"43 is {decades} decades old");

decades = helpers.AgeInDecades(49);
Console.WriteLine($"49 is {decades} decades old");

try
{
	decades = helpers.AgeInDecades(-200);
	Console.WriteLine($"-200 is {decades} decades old");
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}

try
{
	decades = helpers.AgeInDecades(200);
	Console.WriteLine($"200 is {decades} decades old");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();

Console.WriteLine(helpers.TestName("Tim Smith"));
Console.WriteLine(helpers.TestName("Bob Corey"));
Console.WriteLine(helpers.TestName("Sue Storm"));

try
{
	helpers.TestName("Tim Corey");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    helpers.TestName("");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    helpers.TestName("   ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    helpers.TestName(null);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}