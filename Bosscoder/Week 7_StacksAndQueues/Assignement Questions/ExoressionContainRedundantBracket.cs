using System.Collections;

namespace Bosscoder.Week_7_StacksAndQueues.Assignement_Questions
{
    public class ExoressionContainRedundantBracket
    {
        public bool Check(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            Stack expStack= new Stack();


            foreach (char r in s)
            {
                if(r == ')')
                {
                    char top = (char)expStack.Pop();

                    bool flag = true;

                    while(expStack.Count > 0 && top != '(')
                    {
                        if (top == '+' || top == '-' || top == '*' || top == '/')
                            flag = false;

                        top = (char)expStack.Pop();
                    }

                    if (flag == true)
                        return true;
                }
                else
                {
                    expStack.Push(r);
                }
            }

            return false;
        }
    }
}
