using NUnit.Framework;

// Step 1 - Fake It

[TestFixture]
public class Triangulation_Calc_Tests {
    [Test]
    public void adding_two_numbers_gives_correct_result() {
        Assert.That(Triangulation_Calc.Evaluate("+ 1 2"), Is.EqualTo(3));
    }
}


public class Triangulation_Calc {
    public static int Evaluate(string expression) {
        return 3;
    }
}


// Step 2 - Triangulate

//[TestFixture]
//public class Triangulation_Calc_Tests {
//    [Test]
//    public void adding_two_numbers_gives_correct_result() {
//        Assert.That(Triangulation_Calc.Evaluate("+ 1 2"), Is.EqualTo(3));
//    }

//    [Test]
//    public void adding_two_different_numbers_gives_correct_result() {
//        Assert.That(Triangulation_Calc.Evaluate("+ 99 1"), Is.EqualTo(100));
//    }
//}


//public class Triangulation_Calc {
//    public static int Evaluate(string expression) {
//        var subParts = expression.Split(' ');
//        return int.Parse(subParts[1]) + int.Parse(subParts[2]);
//    }
//}


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

//public class Triangulation_Calc {
//    public static string Evaluate(string expression) {
//        var elements = expression.Split(' ');

//        string op = elements[0],
//            arg1 = elements[1],
//            arg2 = elements[2];

//        int result = int.Parse(arg1) + int.Parse(arg2);

//        return result.ToString();
//    }
//}