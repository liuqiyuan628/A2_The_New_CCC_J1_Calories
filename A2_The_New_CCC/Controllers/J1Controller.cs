using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A2_The_New_CCC.Controllers
{
    public class J1Controller : ApiController
    {

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public int Menu(int burger, int drink, int side, int dessert)
        {

            int burgerCal = 0;
            int drinkCal = 0;
            int sideCal = 0;
            int dessertCal = 0;

            if (burger == 1) 
                {

                 burgerCal = burgerCal + 461; 

                } else if (burger == 2)
                {

                 burgerCal = burgerCal + 431;

                } else if (burger == 3)
                 {

                 burgerCal = burgerCal + 420;

                } else {

                 burgerCal = burgerCal + 0;

                }


            if (drink == 1)
            {

                drinkCal = drinkCal + 130;

            }
            else if (drink == 2)
            {

                drinkCal = drinkCal + 160;

            }
            else if (drink == 3)
            {

                drinkCal = drinkCal + 118;

            }
            else
            {

                drinkCal = drinkCal + 0;

            }

            if (side == 1)
            {

                sideCal = sideCal + 100;

            }
            else if (side == 2)
            {

                sideCal = sideCal + 57;

            }
            else if (side == 3)
            {

                sideCal = sideCal + 70;

            }
            else
            {

                sideCal = sideCal + 0;

            }

            if (dessert == 1)
            {

                dessertCal = dessertCal + 100;

            }
            else if (dessert == 2)
            {

                dessertCal = dessertCal + 57;

            }
            else if (dessert == 3)
            {

                dessertCal = dessertCal + 70;

            }
            else
            {

                dessertCal = dessertCal + 0;

            }

            int totalCal = burgerCal + drinkCal + sideCal + dessertCal;
            return totalCal;
          

        }
    }
}
