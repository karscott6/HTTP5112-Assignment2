using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112RNA_Assignment2.Controllers
{
    public class J1Controller : ApiController
    {

        ///<summary>
        /// Calculates the total calories based on the menu choices at Chip's Fast Food Emporium through an HTTP terminal request
        /// </summary>
        /// <param name="burger">1 - Cheeseburger (461 calories), 2 - Fish Burger (431 calories), 3 - Veggie Burger (420 calories)</param>
        /// <param name="drink">1 - Soft Drink (130), 2 - Orange Juice (160), 3 - Milk (118)</param>
        /// <param name="side">1 - Fries (100), 2 - Baked Potatoe (57), Chef Salad (70)</param>
        /// <param name="dessert">1 - Apple Pie (167), 2 - Sundae (266), 3 - Fruit Cup (75)</param>
        /// <returns>
        /// A string containing the total calories based on the menu choices
        /// </returns>
        /// <example>
        /// GET http://localhost:xxx/api/J1/Menu/1/2/3/4 -> Your total calorie count is 691
        /// GET http://localhost:xxx/api/J1/Menu/4/4/4/4 -> Your total calorie count is 0
        /// </example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public string Menu(int burger, int drink, int side, int dessert)
        {
            int totalCalorie = 0;

            if (burger == 1)
                totalCalorie += 461;
            else if (burger == 2)
                totalCalorie += 431;
            else if (burger == 3)
                totalCalorie +=420;

            if (drink == 1)
                totalCalorie += 130;
            else if (drink == 2)
                totalCalorie += 160;
            else if (drink == 3)
                totalCalorie += 118;

            if (side == 1)
                totalCalorie += 100;
            else if (side == 2)
                totalCalorie += 57;
            else if (side == 3)
                totalCalorie += 70;

            if (dessert == 1)
                totalCalorie += 167;
            else if (dessert == 2)
                totalCalorie += 266;
            else if (dessert == 3)
                totalCalorie += 75;

            return "Your total calorie count is " + totalCalorie;


        }





    }
}