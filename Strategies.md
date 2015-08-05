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

kuhi

#### Triangulation

jlbyhb
