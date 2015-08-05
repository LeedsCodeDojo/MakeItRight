using System;
using System.Collections.Generic;
using System.Linq;

public class Calc {

    private static Dictionary<string, Func<IEnumerable<float>, float>> _operators = 
        new Dictionary<string, Func<IEnumerable<float>, float>>
            {{"+", args => args.Sum()},
             {"-", args => args.Aggregate((x, y) => x - y)},
             {"*", args => args.Aggregate((x, y) => x * y)},
             {"/", args => args.Aggregate((x, y) => x / y)},
             {"%", args => args.Aggregate((x, y) => x % y)},
             {"^", args => args.Aggregate((x, y) => (int)Math.Pow(x,y))}};

    public static string Evaluate(string expression) {
        var elements = expression.Split(' ');
        string op = elements[0];
        var intArgs = elements.Skip(1).Select(float.Parse);
        float result = _operators[op].Invoke(intArgs);
        return result.ToString();
    }
}