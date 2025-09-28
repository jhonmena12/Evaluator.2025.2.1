namespace Evaluator.Core
{
    public class ExpressionEvaluator
    {
        public static double Evaluate(string infix)
        {
            var tokens = Tokenize(infix);
            var postfix = InfixToPostfix(tokens);
            return Calculate(postfix);
        }

        // -------------------- Tokenizer --------------------
        private static List<string> Tokenize(string expr)
        {
            List<string> tokens = new();
            int i = 0;
            while (i < expr.Length)
            {
                char ch = expr[i];

                if (char.IsWhiteSpace(ch))
                {
                    i++;
                    continue;
                }

                if (char.IsDigit(ch) || ch == '.')
                {
                    string num = "";
                    int dotCount = 0;
                    while (i < expr.Length && (char.IsDigit(expr[i]) || expr[i] == '.'))
                    {
                        if (expr[i] == '.')
                        {
                            dotCount++;
                            if (dotCount > 1)
                                throw new Exception("Número con más de un punto decimal.");
                        }
                        num += expr[i];
                        i++;
                    }
                    tokens.Add(num);
                    continue;
                }

                if ("+-*/^()%".Contains(ch))
                {
                    tokens.Add(ch.ToString());
                    i++;
                    continue;
                }

                throw new Exception($"Carácter inválido: {ch}");
            }
            return tokens;
        }

        // -------------------- Infix → Postfix --------------------
        private static List<string> InfixToPostfix(List<string> tokens)
        {
            var stack = new Stack<string>();
            var output = new List<string>();

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out _))
                {
                    output.Add(token);
                }
                else if (token == "(")
                {
                    stack.Push(token);
                }
                else if (token == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                        output.Add(stack.Pop());
                    if (stack.Count == 0 || stack.Peek() != "(")
                        throw new Exception("Paréntesis desbalanceados.");
                    stack.Pop();
                }
                else if (IsOperator(token))
                {
                    while (stack.Count > 0 && Priority(stack.Peek()) >= Priority(token))
                        output.Add(stack.Pop());
                    stack.Push(token);
                }
            }

            while (stack.Count > 0)
            {
                var top = stack.Pop();
                if (top == "(" || top == ")")
                    throw new Exception("Paréntesis desbalanceados.");
                output.Add(top);
            }

            return output;
        }

        private static bool IsOperator(string token) => token is "+" or "-" or "*" or "/" or "^" or "%";

        private static int Priority(string op) => op switch
        {
            "^" => 3,
            "*" or "/" or "%" => 2,
            "+" or "-" => 1,
            _ => 0
        };

        // -------------------- Postfix evaluation --------------------
        private static double Calculate(List<string> postfix)
        {
            var stack = new Stack<double>();
            foreach (var token in postfix)
            {
                if (double.TryParse(token, out double num))
                {
                    stack.Push(num);
                }
                else if (IsOperator(token))
                {
                    if (stack.Count < 2) throw new Exception("Faltan operandos.");
                    double b = stack.Pop();
                    double a = stack.Pop();
                    stack.Push(Calculate(a, token, b));
                }
            }
            if (stack.Count != 1)
                throw new Exception("Expresión inválida.");
            return stack.Pop();
        }

        private static double Calculate(double a, string op, double b) => op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b == 0 ? throw new DivideByZeroException("División por cero.") : a / b,
            "^" => Math.Pow(a, b),
            "%" => a % b,
            _ => throw new Exception("Operador inválido.")
        };
    }
}