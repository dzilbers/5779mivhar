using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = int.Parse("abcd");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("It is not a number in the string :-(\n" + ex);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Why do you think I can decide on null?\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new FormatException("Staaaam\n" + ex);
            }
        }
    }
}
