using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A2_The_New_CCC.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Diana is playing a game with two dice. One die has m sides labelled 1, 2, 3, ...m,.
        /// The other diehas n sides labelled 1, 2, 3, ..., n.
        /// Write a program to determine how many ways can she roll thedice to get the sum 10
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>the ways of Diana can get sum10</returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m, int n)
        {
           
            int ways = 0;

            for (int i = 1; i <= m; i++)
            {
                if ((10-i <= n) && (10-i > 0))
                {
                    ways = ways + 1; 
                }
            }

            if (ways == 1)
                {
                    return "There is " + ways.ToString() + " way to get the sum 10.";
                } else
                {
                    return "There are " + ways.ToString() + " ways to get the sum 10.";
                }
            


        }
    }
}
