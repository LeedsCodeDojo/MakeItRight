Implementation Strategies
=========================

* **Fake It** – Return a constant and gradually replace constants with variables until you have real code
* **Obvious Implementation** – Type in the real implementation
* **Triangulation** – Only generalize code when we have two examples or more

**Note**: Alrays remember to refactor, regardless of your strategy!

#### Fake It

Make the test pass as quickly as possible by using hard-coded constants or hacks:

    [Test]
    public void adding_two_numbers_gives_correct_result() {
        Assert.That(FakeIt_Calc.Evaluate("+ 1 2"), Is.EqualTo(3));
    }
    
    public static int Evaluate(string expression) {
        return 3;
    }

It is particularly important to refactor agressively when using this strategy.  For example, in the above there are a couple of things you would want to refactor:
* The repeated 3 (in both the test and implementation)
* The magic number 3 (which will presumably be removed once you refactor away the duplication)

#### Obvious Implementation

If you know exactly what to do and it's simple (e.g. one or two lines and doable within 30 seconds), just type in the solution:

    [Test]
    public void adding_two_numbers_gives_correct_result() {
        Assert.That(Obvious_Calc.Evaluate("+ 1 2"), Is.EqualTo(3));
    }

    public static int Evaluate(string expression) {
        var subParts = expression.Split(' ');
        return int.Parse(subParts[1]) + int.Parse(subParts[2]);
    }
    
You still want to get the test passing quickly, so save the niceties (good names, patterns, etc.) for the refactoring step.

If it takes longer than you thought, is more complex, or you don't get the test passing first time, back out and revert to a different strategy.

#### Triangulation

First of all, Fake It with a hard-coded value or simple hack:

    [Test]
    public void adding_two_numbers_gives_correct_result() {
        Assert.That(Triangulation_Calc.Evaluate("+ 1 2"), Is.EqualTo(3));
    }

    public static int Evaluate(string expression) {
        return 3;
    }

Then add another test to force you to update the solution:

    [Test]
    public void adding_two_different_numbers_gives_correct_result() {
        Assert.That(Triangulation_Calc.Evaluate("+ 99 1"), Is.EqualTo(100));
    }

    public static int Evaluate(string expression) {
        var subParts = expression.Split(' ');
        return int.Parse(subParts[1]) + int.Parse(subParts[2]);
    }
    
#### Refactor

Whichever strategy you chose, be sure to refactor before moving onto the next test:

    public static int Evaluate(string expression) {
        var elements = expression.Split(' ');

        string op = elements[0],
            arg1 = elements[1],
            arg2 = elements[2];

        return int.Parse(arg1) + int.Parse(arg2);
    }
