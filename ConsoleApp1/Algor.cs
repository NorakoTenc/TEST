using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Algor
    {
        public int calcresult(bool par2, int par3, int par1)
        {
            if (par3 < 0 || par1 < 0)
            {
                throw new System.ArgumentException("par3 and par1 must be non-negative integers.");
            }
            int result = 0, var1 = 89;
            result = 89;
            if (result == var1)
            {
                result += par3 + par1;
                if (result > 150 && par2 == true)
                {
                    if (result>250 && par2 == false)
                    {
                        return result > 350 ? result : result * 2;
                    } else
                    {
                        result *= 3;
                        return result;
                    }
                }
                else
                {
                    result *= 2;
                    return result;
                }
            } else
            {
                if (var1 == 89)
                {
                    result *= 2;
                    return result;
                }
                else
                {
                    result *= 3;
                    return result;
                }
            }
        }
    }
}