namespace JLane_Assignment1
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.pnlPiesToDisplay = new System.Windows.Forms.Panel();
            this.grbEnterOrderQuantity = new System.Windows.Forms.GroupBox();
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.grbOrderCustomization = new System.Windows.Forms.GroupBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblSpecialRequests = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.grbCheese = new System.Windows.Forms.GroupBox();
            this.rdbHeavyCheese = new System.Windows.Forms.RadioButton();
            this.rdbNormalCheese = new System.Windows.Forms.RadioButton();
            this.rdbLightCheese = new System.Windows.Forms.RadioButton();
            this.rdbNoneCheese = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkOlivesGreen = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkPineApple = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkOlivesBlack = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grbSauce = new System.Windows.Forms.GroupBox();
            this.rdbHeavySauce = new System.Windows.Forms.RadioButton();
            this.rdbNormalSauce = new System.Windows.Forms.RadioButton();
            this.rdbLightSauce = new System.Windows.Forms.RadioButton();
            this.rdbNoneSauce = new System.Windows.Forms.RadioButton();
            this.pnlOrderSummary = new System.Windows.Forms.Panel();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.grbEnterOrderQuantity.SuspendLayout();
            this.grbOrderCustomization.SuspendLayout();
            this.grbCheese.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbSauce.SuspendLayout();
            this.pnlOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPiesToDisplay
            // 
            this.pnlPiesToDisplay.AutoScroll = true;
            this.pnlPiesToDisplay.Location = new System.Drawing.Point(26, 138);
            this.pnlPiesToDisplay.Name = "pnlPiesToDisplay";
            this.pnlPiesToDisplay.Size = new System.Drawing.Size(196, 435);
            this.pnlPiesToDisplay.TabIndex = 1;
            // 
            // grbEnterOrderQuantity
            // 
            this.grbEnterOrderQuantity.Controls.Add(this.btnStartOrder);
            this.grbEnterOrderQuantity.Controls.Add(this.lblOrderQuantity);
            this.grbEnterOrderQuantity.Controls.Add(this.txtOrderQuantity);
            this.grbEnterOrderQuantity.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEnterOrderQuantity.ForeColor = System.Drawing.Color.Black;
            this.grbEnterOrderQuantity.Location = new System.Drawing.Point(26, 22);
            this.grbEnterOrderQuantity.Name = "grbEnterOrderQuantity";
            this.grbEnterOrderQuantity.Size = new System.Drawing.Size(196, 110);
            this.grbEnterOrderQuantity.TabIndex = 2;
            this.grbEnterOrderQuantity.TabStop = false;
            this.grbEnterOrderQuantity.Text = "Order Quantity";
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStartOrder.Location = new System.Drawing.Point(58, 71);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(84, 33);
            this.btnStartOrder.TabIndex = 2;
            this.btnStartOrder.Text = "Start Order";
            this.btnStartOrder.UseVisualStyleBackColor = false;
            this.btnStartOrder.Click += new System.EventHandler(this.btnStartOrder_Click);
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.Location = new System.Drawing.Point(6, 40);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(112, 19);
            this.lblOrderQuantity.TabIndex = 1;
            this.lblOrderQuantity.Text = "How many pizzas?";
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.BackColor = System.Drawing.Color.Wheat;
            this.txtOrderQuantity.Location = new System.Drawing.Point(135, 37);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(27, 27);
            this.txtOrderQuantity.TabIndex = 0;
            // 
            // grbOrderCustomization
            // 
            this.grbOrderCustomization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbOrderCustomization.Controls.Add(this.btnCheckOut);
            this.grbOrderCustomization.Controls.Add(this.lblSpecialRequests);
            this.grbOrderCustomization.Controls.Add(this.txtInstructions);
            this.grbOrderCustomization.Controls.Add(this.grbCheese);
            this.grbOrderCustomization.Controls.Add(this.grbToppings);
            this.grbOrderCustomization.Controls.Add(this.grbSauce);
            this.grbOrderCustomization.Enabled = false;
            this.grbOrderCustomization.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOrderCustomization.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbOrderCustomization.Location = new System.Drawing.Point(238, 22);
            this.grbOrderCustomization.Name = "grbOrderCustomization";
            this.grbOrderCustomization.Size = new System.Drawing.Size(348, 551);
            this.grbOrderCustomization.TabIndex = 3;
            this.grbOrderCustomization.TabStop = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Red;
            this.btnCheckOut.Location = new System.Drawing.Point(20, 501);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(312, 33);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblSpecialRequests
            // 
            this.lblSpecialRequests.AutoSize = true;
            this.lblSpecialRequests.Location = new System.Drawing.Point(16, 362);
            this.lblSpecialRequests.Name = "lblSpecialRequests";
            this.lblSpecialRequests.Size = new System.Drawing.Size(102, 19);
            this.lblSpecialRequests.TabIndex = 4;
            this.lblSpecialRequests.Text = "Special Requests:";
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.Color.Wheat;
            this.txtInstructions.Location = new System.Drawing.Point(20, 384);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(312, 101);
            this.txtInstructions.TabIndex = 3;
            this.txtInstructions.Leave += new System.EventHandler(this.specialRequests);
            // 
            // grbCheese
            // 
            this.grbCheese.Controls.Add(this.rdbHeavyCheese);
            this.grbCheese.Controls.Add(this.rdbNormalCheese);
            this.grbCheese.Controls.Add(this.rdbLightCheese);
            this.grbCheese.Controls.Add(this.rdbNoneCheese);
            this.grbCheese.Location = new System.Drawing.Point(20, 306);
            this.grbCheese.Name = "grbCheese";
            this.grbCheese.Size = new System.Drawing.Size(312, 45);
            this.grbCheese.TabIndex = 2;
            this.grbCheese.TabStop = false;
            this.grbCheese.Text = "Cheese";
            // 
            // rdbHeavyCheese
            // 
            this.rdbHeavyCheese.AutoSize = true;
            this.rdbHeavyCheese.Location = new System.Drawing.Point(232, 19);
            this.rdbHeavyCheese.Name = "rdbHeavyCheese";
            this.rdbHeavyCheese.Size = new System.Drawing.Size(61, 23);
            this.rdbHeavyCheese.TabIndex = 3;
            this.rdbHeavyCheese.TabStop = true;
            this.rdbHeavyCheese.Text = "Heavy";
            this.rdbHeavyCheese.UseVisualStyleBackColor = true;
            this.rdbHeavyCheese.Click += new System.EventHandler(this.cheeseClicked);
            // 
            // rdbNormalCheese
            // 
            this.rdbNormalCheese.AutoSize = true;
            this.rdbNormalCheese.Location = new System.Drawing.Point(155, 19);
            this.rdbNormalCheese.Name = "rdbNormalCheese";
            this.rdbNormalCheese.Size = new System.Drawing.Size(68, 23);
            this.rdbNormalCheese.TabIndex = 2;
            this.rdbNormalCheese.TabStop = true;
            this.rdbNormalCheese.Text = "Normal";
            this.rdbNormalCheese.UseVisualStyleBackColor = true;
            this.rdbNormalCheese.Click += new System.EventHandler(this.cheeseClicked);
            // 
            // rdbLightCheese
            // 
            this.rdbLightCheese.AutoSize = true;
            this.rdbLightCheese.Location = new System.Drawing.Point(85, 19);
            this.rdbLightCheese.Name = "rdbLightCheese";
            this.rdbLightCheese.Size = new System.Drawing.Size(55, 23);
            this.rdbLightCheese.TabIndex = 1;
            this.rdbLightCheese.TabStop = true;
            this.rdbLightCheese.Text = "Light";
            this.rdbLightCheese.UseVisualStyleBackColor = true;
            this.rdbLightCheese.Click += new System.EventHandler(this.cheeseClicked);
            // 
            // rdbNoneCheese
            // 
            this.rdbNoneCheese.AutoSize = true;
            this.rdbNoneCheese.Location = new System.Drawing.Point(18, 19);
            this.rdbNoneCheese.Name = "rdbNoneCheese";
            this.rdbNoneCheese.Size = new System.Drawing.Size(55, 23);
            this.rdbNoneCheese.TabIndex = 0;
            this.rdbNoneCheese.TabStop = true;
            this.rdbNoneCheese.Text = "None";
            this.rdbNoneCheese.UseVisualStyleBackColor = true;
            this.rdbNoneCheese.Click += new System.EventHandler(this.cheeseClicked);
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.chkSpinach);
            this.grbToppings.Controls.Add(this.chkTomato);
            this.grbToppings.Controls.Add(this.chkHam);
            this.grbToppings.Controls.Add(this.chkOlivesGreen);
            this.grbToppings.Controls.Add(this.chkOnion);
            this.grbToppings.Controls.Add(this.chkPineApple);
            this.grbToppings.Controls.Add(this.chkBacon);
            this.grbToppings.Controls.Add(this.chkOlivesBlack);
            this.grbToppings.Controls.Add(this.chkGreenPeppers);
            this.grbToppings.Controls.Add(this.chkMushrooms);
            this.grbToppings.Controls.Add(this.chkPepperoni);
            this.grbToppings.Location = new System.Drawing.Point(20, 116);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(312, 173);
            this.grbToppings.TabIndex = 1;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // chkSpinach
            // 
            this.chkSpinach.AutoSize = true;
            this.chkSpinach.Location = new System.Drawing.Point(232, 102);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(71, 23);
            this.chkSpinach.TabIndex = 10;
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            this.chkSpinach.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Location = new System.Drawing.Point(232, 67);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(69, 23);
            this.chkTomato.TabIndex = 9;
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = true;
            this.chkTomato.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Location = new System.Drawing.Point(232, 34);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(54, 23);
            this.chkHam.TabIndex = 8;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkOlivesGreen
            // 
            this.chkOlivesGreen.AutoSize = true;
            this.chkOlivesGreen.Location = new System.Drawing.Point(140, 137);
            this.chkOlivesGreen.Name = "chkOlivesGreen";
            this.chkOlivesGreen.Size = new System.Drawing.Size(102, 23);
            this.chkOlivesGreen.TabIndex = 7;
            this.chkOlivesGreen.Text = "Olives, Green";
            this.chkOlivesGreen.UseVisualStyleBackColor = true;
            this.chkOlivesGreen.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(140, 102);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(60, 23);
            this.chkOnion.TabIndex = 6;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkPineApple
            // 
            this.chkPineApple.AutoSize = true;
            this.chkPineApple.Location = new System.Drawing.Point(140, 67);
            this.chkPineApple.Name = "chkPineApple";
            this.chkPineApple.Size = new System.Drawing.Size(81, 23);
            this.chkPineApple.TabIndex = 5;
            this.chkPineApple.Text = "Pineapple";
            this.chkPineApple.UseVisualStyleBackColor = true;
            this.chkPineApple.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(140, 34);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(61, 23);
            this.chkBacon.TabIndex = 4;
            this.chkBacon.Text = "Bacon";
            this.chkBacon.UseVisualStyleBackColor = true;
            this.chkBacon.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkOlivesBlack
            // 
            this.chkOlivesBlack.AutoSize = true;
            this.chkOlivesBlack.Location = new System.Drawing.Point(18, 137);
            this.chkOlivesBlack.Name = "chkOlivesBlack";
            this.chkOlivesBlack.Size = new System.Drawing.Size(98, 23);
            this.chkOlivesBlack.TabIndex = 3;
            this.chkOlivesBlack.Text = "Olives, Black\r\n";
            this.chkOlivesBlack.UseVisualStyleBackColor = true;
            this.chkOlivesBlack.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(18, 102);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(111, 23);
            this.chkGreenPeppers.TabIndex = 2;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(18, 67);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(91, 23);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(18, 34);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(84, 23);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.Click += new System.EventHandler(this.toppingsChecked);
            // 
            // grbSauce
            // 
            this.grbSauce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbSauce.Controls.Add(this.rdbHeavySauce);
            this.grbSauce.Controls.Add(this.rdbNormalSauce);
            this.grbSauce.Controls.Add(this.rdbLightSauce);
            this.grbSauce.Controls.Add(this.rdbNoneSauce);
            this.grbSauce.Location = new System.Drawing.Point(20, 21);
            this.grbSauce.Name = "grbSauce";
            this.grbSauce.Size = new System.Drawing.Size(312, 73);
            this.grbSauce.TabIndex = 0;
            this.grbSauce.TabStop = false;
            this.grbSauce.Text = "Sauce";
            // 
            // rdbHeavySauce
            // 
            this.rdbHeavySauce.AutoSize = true;
            this.rdbHeavySauce.Location = new System.Drawing.Point(232, 34);
            this.rdbHeavySauce.Name = "rdbHeavySauce";
            this.rdbHeavySauce.Size = new System.Drawing.Size(61, 23);
            this.rdbHeavySauce.TabIndex = 3;
            this.rdbHeavySauce.TabStop = true;
            this.rdbHeavySauce.Text = "Heavy";
            this.rdbHeavySauce.UseVisualStyleBackColor = true;
            this.rdbHeavySauce.Click += new System.EventHandler(this.sauceClicked);
            // 
            // rdbNormalSauce
            // 
            this.rdbNormalSauce.AutoSize = true;
            this.rdbNormalSauce.Location = new System.Drawing.Point(155, 34);
            this.rdbNormalSauce.Name = "rdbNormalSauce";
            this.rdbNormalSauce.Size = new System.Drawing.Size(68, 23);
            this.rdbNormalSauce.TabIndex = 2;
            this.rdbNormalSauce.TabStop = true;
            this.rdbNormalSauce.Text = "Normal";
            this.rdbNormalSauce.UseVisualStyleBackColor = true;
            this.rdbNormalSauce.TextChanged += new System.EventHandler(this.sauceClicked);
            this.rdbNormalSauce.Click += new System.EventHandler(this.sauceClicked);
            // 
            // rdbLightSauce
            // 
            this.rdbLightSauce.AutoSize = true;
            this.rdbLightSauce.Location = new System.Drawing.Point(85, 34);
            this.rdbLightSauce.Name = "rdbLightSauce";
            this.rdbLightSauce.Size = new System.Drawing.Size(55, 23);
            this.rdbLightSauce.TabIndex = 1;
            this.rdbLightSauce.TabStop = true;
            this.rdbLightSauce.Text = "Light";
            this.rdbLightSauce.UseVisualStyleBackColor = true;
            this.rdbLightSauce.Click += new System.EventHandler(this.sauceClicked);
            // 
            // rdbNoneSauce
            // 
            this.rdbNoneSauce.AutoSize = true;
            this.rdbNoneSauce.BackColor = System.Drawing.Color.Tomato;
            this.rdbNoneSauce.Location = new System.Drawing.Point(18, 34);
            this.rdbNoneSauce.Name = "rdbNoneSauce";
            this.rdbNoneSauce.Size = new System.Drawing.Size(55, 23);
            this.rdbNoneSauce.TabIndex = 0;
            this.rdbNoneSauce.TabStop = true;
            this.rdbNoneSauce.Text = "None";
            this.rdbNoneSauce.UseVisualStyleBackColor = false;
            this.rdbNoneSauce.Click += new System.EventHandler(this.sauceClicked);
            // 
            // pnlOrderSummary
            // 
            this.pnlOrderSummary.AutoScroll = true;
            this.pnlOrderSummary.BackColor = System.Drawing.Color.Tomato;
            this.pnlOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderSummary.Controls.Add(this.lblOrderSummary);
            this.pnlOrderSummary.Location = new System.Drawing.Point(607, 34);
            this.pnlOrderSummary.Name = "pnlOrderSummary";
            this.pnlOrderSummary.Size = new System.Drawing.Size(151, 473);
            this.pnlOrderSummary.TabIndex = 6;
            this.pnlOrderSummary.Visible = false;
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.Location = new System.Drawing.Point(37, 35);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(9, 19);
            this.lblOrderSummary.TabIndex = 4;
            this.lblOrderSummary.Text = "\r\n";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.Olive;
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(607, 523);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(151, 33);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Visible = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(786, 599);
            this.Controls.Add(this.pnlOrderSummary);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.grbOrderCustomization);
            this.Controls.Add(this.grbEnterOrderQuantity);
            this.Controls.Add(this.pnlPiesToDisplay);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order";
            this.grbEnterOrderQuantity.ResumeLayout(false);
            this.grbEnterOrderQuantity.PerformLayout();
            this.grbOrderCustomization.ResumeLayout(false);
            this.grbOrderCustomization.PerformLayout();
            this.grbCheese.ResumeLayout(false);
            this.grbCheese.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbSauce.ResumeLayout(false);
            this.grbSauce.PerformLayout();
            this.pnlOrderSummary.ResumeLayout(false);
            this.pnlOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPiesToDisplay;
        private System.Windows.Forms.GroupBox grbEnterOrderQuantity;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.GroupBox grbOrderCustomization;
        private System.Windows.Forms.GroupBox grbSauce;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkOlivesGreen;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkPineApple;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkOlivesBlack;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.RadioButton rdbHeavySauce;
        private System.Windows.Forms.RadioButton rdbNormalSauce;
        private System.Windows.Forms.RadioButton rdbLightSauce;
        private System.Windows.Forms.RadioButton rdbNoneSauce;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblSpecialRequests;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.GroupBox grbCheese;
        private System.Windows.Forms.RadioButton rdbHeavyCheese;
        private System.Windows.Forms.RadioButton rdbNormalCheese;
        private System.Windows.Forms.RadioButton rdbLightCheese;
        private System.Windows.Forms.RadioButton rdbNoneCheese;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Panel pnlOrderSummary;
    }
}

