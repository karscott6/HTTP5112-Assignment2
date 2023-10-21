using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112RNA_Assignment2.Controllers
{
    public class J2Controller : ApiController
    {

        ///<summary>
        /// Calculates the total amount of ways that two dice can equal a targetted sum (set to 10)
        /// </summary>
        /// <param name="m">The number of sides on dice 1</param>
        /// <param name="n">The number of sides on dice 2</param>
        /// <returns>
        /// A string containing the total number of ways the two dice can equal the targetted sum
        /// </returns>
        /// <example>
        /// GET http://localhost:xxx/api/J2/DiceGame/6/8 -> There are 5 total ways to get the sum of 10.
        /// GET http://localhost:xxx/api/J2/DiceGame/12/12 -> There are 9 total ways to get the sum of 10.
        /// </example>

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m, int n)
        {
            int sumTarget = 10; //this is the number i want the two sides to equal
            int totalWays = 0; //a variable for counting the total number of ways for the sum

            for (int i = 1; i <= m; i++) // this will loop through all possibilities for the first dice
            {
                for (int j = 1; j <= n; j++) // this will loop through all the possibilities for the second dice
                {
                    if (i + j == sumTarget) //check if the sum of the two values is equal to the sumTarget
                    {
                        totalWays++; //increase the count of total ways the dice hit targetted sum
                    }
                        
                }

            }


            return "There are " + totalWays.ToString() + " total ways to get the sum " + sumTarget.ToString() + ".";


        }





    }
}