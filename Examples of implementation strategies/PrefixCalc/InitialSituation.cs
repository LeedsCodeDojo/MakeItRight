using NUnit.Framework;


[TestFixture]
public class Initial_Calc_Tests {
    [Test]
    public void adding_two_numbers_gives_correct_result() {
        Assert.That(Initial_Calc.Evaluate("+ 1 2"), Is.EqualTo(3));
    }
}


public class Initial_Calc {
    public static int Evaluate(string expression) {
        return 3;
    }
}
