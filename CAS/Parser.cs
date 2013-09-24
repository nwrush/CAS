﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAS
{
    public class Parser
    {
        public static List<Element> Parse(string expression)
        {
            List<Element> elements=new List<Element>();
            char[] characters = expression.ToArray();

            foreach (char c in characters)
            {
                if (c == ' ') break;

                double d;
                Operator o;
                Variable e;
                if (double.TryParse(c.ToString(), out d))
                {
                    elements.Add(new Number(d));
                } else if (Operator.TryParseOperator(c, out o))
                {
                    elements.Add(o);
                } else if (Variable.TryParseVariable(c, out e))
                {
                    elements.Add(e);
                }
            }

            return elements;
        }
    }
}
