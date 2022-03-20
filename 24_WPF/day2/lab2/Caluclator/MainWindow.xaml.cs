using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Caluclator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double sum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void num(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            txt.Text += b.Content.ToString();
        }

        private void Result(object sender, RoutedEventArgs e)
        {

            //List<int> Operands = new List<int>();

            //for(int i=0;i<txt.Text.Length;i++)
            //{
            //    if (txt.Text[i] == '+' || txt.Text[i] == '-' || txt.Text[i] == '/' || txt.Text[i] == '*')
            //        Operands.Add(i);
            //}

            //Operands.Add(txt.Text.Length-1);
            //sum = Convert.ToDouble(txt.Text.Substring(0, Operands[0])); 
            //for(int i=1;i< Operands.Count;++i)
            //{
            //    double current = Convert.ToDouble(txt.Text.Substring(Operands[i-1], Operands[i]));
            //    if (txt.Text[Operands[i] ]== '+')
            //        sum += current;
            //    else if (txt.Text[Operands[i]] == '-')
            //        sum -= current;
            //    else if (txt.Text[Operands[i]] == '*')
            //        sum *= current;
            //    else if (txt.Text[Operands[i]] == '/' && current != 0)
            //        sum /= current;




            //}
            //txt.Text = sum.ToString();
            string exp = txt.Text;
            Stack<int> operands = new Stack<int>();  //Operand stack
            Stack<char> operations = new Stack<char>();  //Operator stack
            for (int i = 0; i < exp.Length; i++)
            {
                char c = exp[i];
                if (char.IsDigit(c))  //check if it is number
                {
                    //Entry is Digit, and it could be greater than a one-digit number
                    int num = 0;
                    while (char.IsDigit(c))
                    {
                        num = num * 10 + (c - '0');
                        i++;
                        if (i < exp.Length)
                        {
                            c = exp[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    i--;
                    operands.Push(num);
                }
                else if (c == '(')
                {
                    operations.Push(c);   //push character to operators stack
                }
                //Closed brace, evaluate the entire brace
                else if (c == ')')
                {
                    while (operations.Peek() != '(')
                    {
                        int output = performOperation(operands, operations);
                        operands.Push(output);   //push result back to stack
                    }
                    operations.Pop();
                }

                // current character is operator
                else if (isOperator(c))
                {
                    while (operations.Count!=0 && precedence(c) <= precedence(operations.Peek()))
                    {
                        int output = performOperation(operands, operations);
                        operands.Push(output);   //push result back to stack
                    }
                    operations.Push(c);   //push the current operator to stack
                }
            }

            while (operations.Count!=0)
            {
                int output = performOperation(operands, operations);
                operands.Push(output);   //push final result back to stack
            }
            txt.Text = operands.Pop().ToString();
        }

        static int precedence(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
            }
            return -1;
        }

        public int performOperation(Stack<int> operands, Stack<Char> operations)
        {
            int a = operands.Pop();
            int b = operands.Pop();
            char operation = operations.Pop();
            switch (operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return b - a;
                case '*':
                    return a * b;
                case '/':
                    if (a == 0)
                    {
                        txt.Text = "Cannot divide by zero";
                        return 0;
                    }
                    return b / a;
            }
            return 0;

        }
        public bool isOperator(char c)
        {
            return (c == '+' || c == '-' || c == '/' || c == '*' || c == '^');
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            txt.Clear();
        }
    }
}
