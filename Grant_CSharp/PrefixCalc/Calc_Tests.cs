using NUnit.Framework;

[TestFixture]
public class Calc_Tests {
    [Test]
    public void adding_numbers_gives_correct_result() {
        Assert.That(Calc.Evaluate("+ 1 2 3"), Is.EqualTo("6"));
    }

    [Test]
    public void subtracting_numbers_gives_correct_result() {
        Assert.That(Calc.Evaluate("- 10 2 1"), Is.EqualTo("7"));
    }

    [Test]
    public void multiplying_numbers_gives_correct_result() {
        Assert.That(Calc.Evaluate("* 5 10 2"), Is.EqualTo("100"));
    }

    [Test]
    public void dividing_numbers_gives_correct_result() {
        Assert.That(Calc.Evaluate("/ 20 5 2"), Is.EqualTo("2"));
    }

    [Test]
    public void power_operator_gives_correct_result() {
        Assert.That(Calc.Evaluate("^ 2 4"), Is.EqualTo("16"));
    }

    [Test]
    public void mod_operator_gives_correct_result() {
        Assert.That(Calc.Evaluate("% 7 4 2"), Is.EqualTo("1"));
    }

    [Test]
    public void large_number_of_parameters_works() {
        Assert.That(Calc.Evaluate("+ 1 2 3 4 5 6 7 8 9"), Is.EqualTo("45"));
    }

    [Test]
    public void works_with_decimals() {
        Assert.That(Calc.Evaluate("+ 1.0 2.5"), Is.EqualTo("3.5"));
    }

    [Test]
    public void division_resulting_in_numbers_below_one_works() {
        Assert.That(Calc.Evaluate("/ 1.0 2.0"), Is.EqualTo("0.5"));
    }

    [Test]
    public void works_with_one_level_of_sub_expression() {
        Assert.That(Calc.Evaluate("+ [+ 1 2] [- 9 1]"), Is.EqualTo("11"));
    }
}
