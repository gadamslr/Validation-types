using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_types
{
    internal class Program
    {
        static void Type_Check()
            {
                //Pseudocode

                //          OUTPUT "Please enter your age"​
                //          REPEAT​
                //              INPUT Age​
                //              IF Age <> INTEGER​ // Alternate method for C# 
                //                  THEN​
                //                      OUTPUT "Age must be a whole number, try again."​
                //              ENDIF​
                //          UNTIL Age = DIV(Age, 1)

                //////////////////////////////////////// Add code below
            


            }

        static void Range_Check()
        {
            //          OUTPUT "Please enter your age"
            //          REPEAT
            //              INPUT Age
            //              IF(Age < 0) OR (Age > 100)
            //                  THEN
            //                      OUTPUT “Age must be between 0 - 100, try again."
            //              ENDIF
            //          UNTIL(Age => 0) AND(Age <= 100)

            //////////////////////////////////////// Add code below



        }

            static void Presence_Check()
            {
                //          OUTPUT "Enter your name"
                //          REPEAT
                //              INPUT Name
                //              IF Name = ""
                //                  THEN
                //                      OUTPUT "You must enter your name to continue."
                //              ENDIF
                //          UNTIL Name <> ""



            }

            static void Format_check()
            {
            //              Valid = false
            //              OUTPUT "Enter your date of birth dd/mm/yyyy:"
            //              REPEAT
            //                  INPUT DOB
            //                  
            //                  TRY
            //                      BirthYear = DOB.Substring(6, 4)
            //                      BirthMonth = DOB.Substring(3, 2)
            //                      BirthDay = DOB.Substring(0, 2)
            //                      Valid = true
            //                  EXCEPT
            //                      OUTPUT "Invalid date of birth.“
            //                  ENDIF
            //              UNTIL Valid = true


        }

        static void Length_Check()
            {
                //          OUTPUT "Enter your code"
                //          REPEAT
                //              INPUT Code
                //              IF LENGTH(Code) <> 4
                //                  THEN
                //                      OUTPUT "You must supply a 4 letter code."
                //              ENDIF
                //          UNTIL LENGTH(Code) = 4


            }
            static void Main(string[] args)
            {

                // Validation checks types:

                // Type check
                Type_Check();

                // Range check;
                Range_Check();

                // Presence check
                Presence_Check();

                // Format check
                Format_check();

                // Length check
                Length_Check();

                Console.ReadLine();

            }
        }
    }

}
    }
}
