using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JLane_Assignment1
{
    public partial class OrderForm : Form
    {
        private Pizza activePizza = new Pizza();
        public OrderForm()
        {
            InitializeComponent();
        }
        public void btnStartOrder_Click(object sender, EventArgs e)
        {
            string orderQuantityEnteredByUser = txtOrderQuantity.Text;//create variable to capture user input
            int orderQuantityEnteredByUserParsed;//create variable to store parsed user input.

            const int minimumOrder = 1;// declare minimum and maximum orders as constants. avoid magic numbers.
            const int maximumOrder = 9;
            if (!int.TryParse(orderQuantityEnteredByUser, out orderQuantityEnteredByUserParsed) || orderQuantityEnteredByUserParsed > maximumOrder || orderQuantityEnteredByUserParsed < minimumOrder)
            {
                MessageBox.Show("Orders may consist of a minimum of 1 pizza, or a maximum of 9");//prompt user if input incorrect
                txtOrderQuantity.Clear();//clear text box if input incorrect.
            }
            else
            {
                int xAxis = 48; //create x value on x/y axis for button location
                int yAxis = 15;// create y value on x/y axis for button location
                int yAxisSpacing = 65;// spacing along y axis

                for (int i = 0; i < orderQuantityEnteredByUserParsed; i++)
                {
                    RadioButton orderControlButton = new RadioButton();//creates multiple objects i.e. radio buttons

                    Pizza pizzaObject = new Pizza();
                    orderControlButton.Tag = pizzaObject;//tag is obect that contains data about control.
                                                        //any type can derived from object class can be assigned to this property.
                    orderControlButton.SetBounds(0, 0, 100, 100);
                    orderControlButton.Appearance = Appearance.Button;
                    
                    orderControlButton.Location = new Point(xAxis, yAxis + (xAxis * i) + (yAxisSpacing * i));
                    pnlPiesToDisplay.Controls.Add(orderControlButton);//'this' keyword not necessary. grbBoxDisplay.Controls.Add(newTextBox) adds all the new textboxes to the groupbox.

                    //create event handler for newly created buttons. takes pizzaPieClick() as argument.
                    orderControlButton.Click += new EventHandler(pizzaPieClick);
                }
            }
        }
        public void pizzaPieClick(object sender, EventArgs e)
        {
            grbOrderCustomization.Enabled = true;
            
            RadioButton radioButton = (RadioButton)sender;//grabs the radio button, so we can access it as a button.

            activePizza = (Pizza)radioButton.Tag;

            UpDateControlsOnForm();
        }
        public void sauceClicked(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;//grabs the radio button, so we can access it as a button.

            activePizza.SauceAmount = radioButton.Text;
        }
        public void cheeseClicked(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;//grabs the radio button, so we can access it as a button.

            activePizza.CheeseAmount = radioButton.Text;
        }
        public void specialRequests(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;//grabs the radio button, so we can access it as a button.

            activePizza.SpecialInstructions = textBox.Text;
        }
        public void toppingsChecked(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;//grabs the radio button, so we can access it as a button.

            activePizza.HasBacon = chkBacon.Checked;
            activePizza.HasBlackOlives = chkOlivesBlack.Checked;
            activePizza.HasGreenOlives = chkOlivesGreen.Checked;
            activePizza.HasGreenPepper = chkGreenPeppers.Checked;
            activePizza.HasHam = chkHam.Checked;
            activePizza.HasMushrooms = chkMushrooms.Checked;
            activePizza.HasOnion = chkOnion.Checked;
            activePizza.HasPepperoni = chkPepperoni.Checked;
            activePizza.HasPineApple = chkPineApple.Checked;
            activePizza.HasSpinach = chkSpinach.Checked;
            activePizza.HasTomato = chkTomato.Checked;
        }
        private void UpDateControlsOnForm()
        {
            switch (activePizza.SauceAmount)
            {
                case "None":
                    rdbNoneSauce.Checked = true;
                    break;
                case "Light":
                    rdbLightSauce.Checked = true;
                    break;
                case "Normal":
                    rdbNormalSauce.Checked = true;
                    break;
                case "Heavy":
                    rdbHeavySauce.Checked = true;
                    break;
                default:
                    rdbNoneSauce.Checked = false;
                    rdbLightSauce.Checked = false;
                    rdbNormalSauce.Checked = false;
                    rdbHeavySauce.Checked = false;
                    break;
            }

            switch (activePizza.CheeseAmount)
            {
                case "None":
                    rdbNoneCheese.Checked = true;
                    break;
                case "Light":
                    rdbLightCheese.Checked = true;
                    break;
                case "Normal":
                    rdbNormalCheese.Checked = true;
                    break;
                case "Heavy":
                    rdbHeavyCheese.Checked = true;
                    break;
                default:
                    rdbNoneCheese.Checked = false;
                    rdbLightCheese.Checked = false;
                    rdbNormalCheese.Checked = false;
                    rdbHeavyCheese.Checked = false;
                    break;
            }

            if (activePizza.HasBacon)
            {
                chkBacon.Checked = true;
            }
            else
            {
                chkBacon.Checked = false;
            }

            if (activePizza.HasBlackOlives)
            {
                chkOlivesBlack.Checked = true;
            }
            else
            {
                chkOlivesBlack.Checked = false;
            }

            if (activePizza.HasGreenOlives)
            {
                chkOlivesGreen.Checked = true;
            }
            else
            {
                chkOlivesGreen.Checked = false;
            }

            if (activePizza.HasGreenPepper)
            {
                chkGreenPeppers.Checked = true;
            }
            else
            {
                chkGreenPeppers.Checked = false;
            }

            if (activePizza.HasHam)
            {
                chkHam.Checked = true;
            }
            else
            {
                chkHam.Checked = false;
            }

            if (activePizza.HasMushrooms)
            {
                chkMushrooms.Checked = true;
            }
            else
            {
                chkMushrooms.Checked = false;
            }

            if (activePizza.HasOnion)
            {
                chkOnion.Checked = true;
            }
            else
            {
                chkOnion.Checked = false;
            }

            if (activePizza.HasPepperoni)
            {
                chkPepperoni.Checked = true;
            }
            else
            {
                chkPepperoni.Checked = false;
            }

            if (activePizza.HasTomato)
            {
                chkTomato.Checked = true;
            }
            else
            {
                chkTomato.Checked = false;
            }

            if (activePizza.HasSpinach)
            {
                chkSpinach.Checked = true;
            }
            else
            {
                chkSpinach.Checked = false;
            }

            if (activePizza.HasPineApple)
            {
                chkPineApple.Checked = true;
            }
            else
            {
                chkPineApple.Checked = false;
            }

            txtInstructions.Text = activePizza.SpecialInstructions;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            
            StringBuilder purchaseOrder = new StringBuilder($"Your Order");
            purchaseOrder.AppendLine();
            purchaseOrder.AppendLine("____________");
            purchaseOrder.AppendLine();
            
            foreach (Control control in pnlPiesToDisplay.Controls)
            {
                RadioButton radioButton = (RadioButton)control;

                // get the pizza back from the Tag of this button
                Pizza pizza = (Pizza)radioButton.Tag;
                
                //  add the summary string from this pizza to the 
                // summary we are building
                purchaseOrder.AppendLine(pizza.GetPizzaDescriptionString());
                purchaseOrder.AppendLine();
             
            }

            // finally print this summary to the label provided for 
            // this purpose
            pnlOrderSummary.Visible = true;
            lblOrderSummary.Text = purchaseOrder.ToString();
           
            btnNewOrder.Visible = true;

            grbEnterOrderQuantity.Enabled = false;
            grbOrderCustomization.Enabled = false;
            pnlPiesToDisplay.Enabled = false;
        }
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            pnlPiesToDisplay.Controls.Clear();
            
            switch (activePizza.SauceAmount)
            {
                case "None":
                    rdbNoneSauce.Checked = false;
                    break;
                case "Light":
                    rdbLightSauce.Checked = false;
                    break;
                case "Normal":
                    rdbNormalSauce.Checked = false;
                    break;
                case "Heavy":
                    rdbHeavySauce.Checked = false;
                    break;
                
            }
            switch (activePizza.CheeseAmount)
            {
                case "None":
                    rdbNoneCheese.Checked = false;
                    break;
                case "Light":
                    rdbLightCheese.Checked = false;
                    break;
                case "Normal":
                    rdbNormalCheese.Checked = false;
                    break;
                case "Heavy":
                    rdbHeavyCheese.Checked = false;
                    break;
               
            }

            if (activePizza.HasBacon)
            {
                chkBacon.Checked = false;
            }

            if (activePizza.HasBlackOlives)
            {
                chkOlivesBlack.Checked = false;
            }
            

            if (activePizza.HasGreenOlives)
            {
                chkOlivesGreen.Checked = false;
            }

            if (activePizza.HasGreenPepper)
            {
                chkGreenPeppers.Checked = false;
            }

            if (activePizza.HasHam)
            {
                chkHam.Checked = false;
            }
            
            if (activePizza.HasMushrooms)
            {
                chkMushrooms.Checked = false;
            }
            

            if (activePizza.HasOnion)
            {
                chkOnion.Checked = false;
            }
            

            if (activePizza.HasPepperoni)
            {
                chkPepperoni.Checked = false;
            }
            

            if (activePizza.HasTomato)
            {
                chkTomato.Checked = false;
            }

            if (activePizza.HasSpinach)
            {
                chkSpinach.Checked = false;
            }

            if (activePizza.HasPineApple)
            {
                chkPineApple.Checked = false;
            }
           

            txtInstructions.Text = "";
            txtOrderQuantity.Text = "";

            lblOrderSummary.Text = "";

            pnlOrderSummary.Visible = false;
            pnlPiesToDisplay.Enabled = true;

            btnNewOrder.Visible = false;
            //btnNewOrder.Enabled = false;

            grbEnterOrderQuantity.Enabled = true;
            grbOrderCustomization.Enabled = true;

        }

    }


    
}
