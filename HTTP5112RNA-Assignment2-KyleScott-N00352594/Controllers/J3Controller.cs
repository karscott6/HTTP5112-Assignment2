using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112RNA_Assignment2.Controllers
{
    public class J3Controller : ApiController
    {

        ///<summary>
        /// Takes a 3x3 Grid Image and Scales to 3k x 3k
        /// </summary>
        /// <param name="k">A positive integer {k} such that k < 25</param>
        /// <returns>
        /// Returns 3k lines. Ie. each line scaled by k, and repeated k times. each character in line has k copies.
        /// </returns>
        /// <example>
        /// GET http://localhost:xxx/api/J3/IconScaling/3 -> a 9x9 grid.
        /// GET http://localhost:xxx/api/J3/IconScaling/25 -> a 75x75 grid.
        /// </example>

        [HttpGet]
        [Route("api/J3/IconScaling/{k}")]
        public string IconScaling(int k)
        {

            //*x* // I need {k} for each of the 9 characters in the original 9x9. So I am hoping if I can get one
            // xx // to multiply by {k), then all I need to do copy and paste it 9 times?
            //* * // have to do it left-right; some kind of line break. have to take character, multiple by k and return cK to the result and keep adding each one (????

            string iconResult = ""; // this is a variable to hold my result
            for (int i = 0; i < 3 * k; i++) // this will cause the loop to scale the icon by {k}
            {
                if ( )
            }


                return iconResult;
        }
    }
