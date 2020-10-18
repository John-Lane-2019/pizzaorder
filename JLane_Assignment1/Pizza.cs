using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLane_Assignment1
{
    class Pizza
    {
        public bool HasPepperoni;//toppings set to boolean because checkboxes are true or false.
        public bool HasBacon;
        public bool HasHam;
        public bool HasMushrooms;
        public bool HasPineApple;
        public bool HasTomato;
        public bool HasGreenPepper;
        public bool HasOnion;
        public bool HasSpinach;
        public bool HasBlackOlives;
        public bool HasGreenOlives;

        public string CheeseAmount;//cheese, sauce, and special instructions set to string because they aren't true/false.
        public string SauceAmount;
        public string SpecialInstructions;

        public Pizza()
        {

        }
        public string GetPizzaDescriptionString()
        {
            StringBuilder desciption = new StringBuilder();

            if (HasBlackOlives)
            {
                desciption.Append("Black Olives\r\n");
            }
            if (HasGreenOlives)
            {
                desciption.Append("Green Olives\r\n");
            }
            if (HasBacon)
            {
                desciption.Append("Bacon\r\n");
            }

            if (HasGreenPepper)
            {
                desciption.Append("Green Pepper\r\n");
            }
            if (HasHam)
            {
                desciption.Append("Ham\r\n");
            }
            if (HasMushrooms)
            {
                desciption.Append("Mushrooms\r\n");
            }
            if (HasOnion)
            {
                desciption.Append("Onion\r\n");
            }
            if (HasPepperoni)
            {
                desciption.Append("Pepperoni\r\n");
            }
            if (HasPineApple)
            {
                desciption.Append("Pineapple\r\n");
            }
            if (HasSpinach)
            {
                desciption.Append("Spinach\r\n");
            }
            if (HasTomato)
            {
                desciption.Append("Tomato\r\n");
            }
            if (CheeseAmount == "None")
            {
                desciption.Append("No Cheese\r\n");
            }
            if (CheeseAmount == "Light")
            {
                desciption.Append("Light Cheese\r\n");
            }
            if (CheeseAmount == "Normal")
            {
                desciption.Append("Normal Cheese\r\n");
            }
            if (CheeseAmount == "Heavy")
            {
                desciption.Append("Heavy Cheese\r\n");
            }
            if (SauceAmount == "None")
            {
                desciption.Append("No Sauce\r\n");
            }
            if (SauceAmount == "Light")
            {
                desciption.Append("Light Sauce\r\n");
            }
            if (SauceAmount == "Normal")
            {
                desciption.Append("Normal Sauce\r\n");
            }
            if (SauceAmount == "Heavy")
            {
                desciption.Append("Heavy Sauce\r\n");
            }
            if (SpecialInstructions!="")
            {
                desciption.Append(SpecialInstructions);
            }
                return desciption.ToString();

        }
    }
}
