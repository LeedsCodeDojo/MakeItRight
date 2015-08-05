using NUnit.Framework;


[TestFixture]
public class FakeIt_Calc_Tests {
    [Test]
    public void adding_two_numbers_gives_correct_result() {
        Assert.That(FakeIt_Calc.Evaluate("+ 1 2"), Is.EqualTo(3));
    }
}


public class FakeIt_Calc {
    public static int Evaluate(string expression) {
        return 3;
    }
}


/*       "
         "
         "
         "
         "
         "
         "
         "
         "
         "
         "
         "
         "
         "
         "
         "
     \   "   /
      \  "  /
       \ " /
        \ /
         V
 */

// Refactor

//public class FakeIt_Calc {
//    public static string Evaluate(string expression) {
//        var elements = expression.Split(' ');

//        string op = elements[0],
//            arg1 = elements[1],
//            arg2 = elements[2];

//        int result = int.Parse(arg1) + int.Parse(arg2);

//        return result.ToString();
//    }
//}