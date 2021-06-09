using System;
using System.Collections.Generic;

namespace parentheses_Balanced
{
    public class Program
    {
        
        public char missing(string exp) //dice cual parentesis falta
        {

            if (exp == null) //si la expresion esta vacia
            {
                throw new ArgumentNullException(); //null exeption
            }

            Stack<char> st = new Stack<char>();   //crea una pila para los parentesis abiertos

            char[] cArray = exp.ToCharArray(); //divide el string en un array de chars

            for (int i = 0; i < cArray.Length; i++)
            {
                if (cArray[i] == '(')
                {
                    st.Push(cArray[i]);
                }

                if (cArray[i] == ')')
                {
                    if (st.Count != 0)
                    {
                        if (!isMatchingPair(st.Pop(), cArray[i]))
                        {
                            return '(';
                        }
                    }
                    else
                    {
                        return '(';
                    }

                }
            }

            if (st.Count != 0)
            {
                return ')';
            }



            return ' ';
        }

        public bool isMatchingPair(char c1, char c2)
        {
            if (c1 == '(' && c2 == ')')
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            Program check = new Program();
            Console.WriteLine(check.missing("()())((()))"));
        }
    }
}
