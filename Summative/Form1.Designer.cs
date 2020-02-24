namespace Summative
{
    partial class Form1
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
            this.burgerLabel = new System.Windows.Forms.Label();
            this.fryLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.fryBox = new System.Windows.Forms.TextBox();
            this.drinkBox = new System.Windows.Forms.TextBox();
            this.boxLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.burgerplaceLabel = new System.Windows.Forms.Label();
            this.ordernumberLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.orderburgerLabel = new System.Windows.Forms.Label();
            this.orderfryLabel = new System.Windows.Forms.Label();
            this.orderdrinkLabel = new System.Windows.Forms.Label();
            this.ordersubtotalLabel = new System.Windows.Forms.Label();
            this.ordersubtotalpriceLabel = new System.Windows.Forms.Label();
            this.ordertaxLabel = new System.Windows.Forms.Label();
            this.ordertotalLabel = new System.Windows.Forms.Label();
            this.ordertenderedLabel = new System.Windows.Forms.Label();
            this.orderchangeLabel = new System.Windows.Forms.Label();
            this.ordertaxpriceLabel = new System.Windows.Forms.Label();
            this.ordertotalpriceLabel = new System.Windows.Forms.Label();
            this.ordertenderedtotalLabel = new System.Windows.Forms.Label();
            this.orderchangetotalLabel = new System.Windows.Forms.Label();
            this.byeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalpriceLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxpriceLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalpriceLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changetotalLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerLabel
            // 
            this.burgerLabel.Font = new System.Drawing.Font("Square721 Blk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.ForeColor = System.Drawing.Color.Orange;
            this.burgerLabel.Location = new System.Drawing.Point(60, 39);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(254, 36);
            this.burgerLabel.TabIndex = 0;
            this.burgerLabel.Text = "Number of Burgers";
            // 
            // fryLabel
            // 
            this.fryLabel.Font = new System.Drawing.Font("Square721 Blk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryLabel.ForeColor = System.Drawing.Color.Orange;
            this.fryLabel.Location = new System.Drawing.Point(60, 94);
            this.fryLabel.Name = "fryLabel";
            this.fryLabel.Size = new System.Drawing.Size(254, 33);
            this.fryLabel.TabIndex = 1;
            this.fryLabel.Text = "Number of Fries";
            // 
            // drinkLabel
            // 
            this.drinkLabel.Font = new System.Drawing.Font("Square721 Blk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.ForeColor = System.Drawing.Color.Orange;
            this.drinkLabel.Location = new System.Drawing.Point(60, 155);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(254, 36);
            this.drinkLabel.TabIndex = 2;
            this.drinkLabel.Text = "Number of Drinks";
            // 
            // burgerBox
            // 
            this.burgerBox.Location = new System.Drawing.Point(335, 48);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(123, 20);
            this.burgerBox.TabIndex = 3;
            this.burgerBox.Text = "0";
            this.burgerBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // fryBox
            // 
            this.fryBox.Location = new System.Drawing.Point(305, 103);
            this.fryBox.Name = "fryBox";
            this.fryBox.Size = new System.Drawing.Size(123, 20);
            this.fryBox.TabIndex = 4;
            this.fryBox.Text = "0";
            // 
            // drinkBox
            // 
            this.drinkBox.Location = new System.Drawing.Point(320, 164);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(123, 20);
            this.drinkBox.TabIndex = 5;
            this.drinkBox.Text = "0";
            // 
            // boxLabel
            // 
            this.boxLabel.BackColor = System.Drawing.Color.White;
            this.boxLabel.Location = new System.Drawing.Point(497, 39);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(277, 340);
            this.boxLabel.TabIndex = 6;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DimGray;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Square721 BdEx BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Orange;
            this.resetButton.Location = new System.Drawing.Point(510, 394);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(241, 31);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "New Order";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // burgerplaceLabel
            // 
            this.burgerplaceLabel.BackColor = System.Drawing.Color.White;
            this.burgerplaceLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerplaceLabel.Location = new System.Drawing.Point(585, 52);
            this.burgerplaceLabel.Name = "burgerplaceLabel";
            this.burgerplaceLabel.Size = new System.Drawing.Size(107, 16);
            this.burgerplaceLabel.TabIndex = 8;
            this.burgerplaceLabel.Text = "Burger Place";
            // 
            // ordernumberLabel
            // 
            this.ordernumberLabel.BackColor = System.Drawing.Color.White;
            this.ordernumberLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordernumberLabel.Location = new System.Drawing.Point(507, 81);
            this.ordernumberLabel.Name = "ordernumberLabel";
            this.ordernumberLabel.Size = new System.Drawing.Size(133, 19);
            this.ordernumberLabel.TabIndex = 9;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.White;
            this.dateLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(507, 100);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(150, 21);
            this.dateLabel.TabIndex = 10;
            // 
            // orderburgerLabel
            // 
            this.orderburgerLabel.BackColor = System.Drawing.Color.White;
            this.orderburgerLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderburgerLabel.Location = new System.Drawing.Point(507, 134);
            this.orderburgerLabel.Name = "orderburgerLabel";
            this.orderburgerLabel.Size = new System.Drawing.Size(244, 21);
            this.orderburgerLabel.TabIndex = 11;
            // 
            // orderfryLabel
            // 
            this.orderfryLabel.BackColor = System.Drawing.Color.White;
            this.orderfryLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderfryLabel.Location = new System.Drawing.Point(507, 155);
            this.orderfryLabel.Name = "orderfryLabel";
            this.orderfryLabel.Size = new System.Drawing.Size(244, 21);
            this.orderfryLabel.TabIndex = 12;
            // 
            // orderdrinkLabel
            // 
            this.orderdrinkLabel.BackColor = System.Drawing.Color.White;
            this.orderdrinkLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdrinkLabel.Location = new System.Drawing.Point(507, 176);
            this.orderdrinkLabel.Name = "orderdrinkLabel";
            this.orderdrinkLabel.Size = new System.Drawing.Size(244, 21);
            this.orderdrinkLabel.TabIndex = 13;
            this.orderdrinkLabel.Click += new System.EventHandler(this.OrderdrinkLabel_Click);
            // 
            // ordersubtotalLabel
            // 
            this.ordersubtotalLabel.BackColor = System.Drawing.Color.White;
            this.ordersubtotalLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersubtotalLabel.Location = new System.Drawing.Point(507, 206);
            this.ordersubtotalLabel.Name = "ordersubtotalLabel";
            this.ordersubtotalLabel.Size = new System.Drawing.Size(85, 18);
            this.ordersubtotalLabel.TabIndex = 14;
            // 
            // ordersubtotalpriceLabel
            // 
            this.ordersubtotalpriceLabel.BackColor = System.Drawing.Color.White;
            this.ordersubtotalpriceLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersubtotalpriceLabel.Location = new System.Drawing.Point(629, 206);
            this.ordersubtotalpriceLabel.Name = "ordersubtotalpriceLabel";
            this.ordersubtotalpriceLabel.Size = new System.Drawing.Size(122, 18);
            this.ordersubtotalpriceLabel.TabIndex = 15;
            // 
            // ordertaxLabel
            // 
            this.ordertaxLabel.BackColor = System.Drawing.Color.White;
            this.ordertaxLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertaxLabel.Location = new System.Drawing.Point(507, 224);
            this.ordertaxLabel.Name = "ordertaxLabel";
            this.ordertaxLabel.Size = new System.Drawing.Size(85, 18);
            this.ordertaxLabel.TabIndex = 16;
            // 
            // ordertotalLabel
            // 
            this.ordertotalLabel.BackColor = System.Drawing.Color.White;
            this.ordertotalLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertotalLabel.Location = new System.Drawing.Point(507, 242);
            this.ordertotalLabel.Name = "ordertotalLabel";
            this.ordertotalLabel.Size = new System.Drawing.Size(85, 18);
            this.ordertotalLabel.TabIndex = 17;
            // 
            // ordertenderedLabel
            // 
            this.ordertenderedLabel.BackColor = System.Drawing.Color.White;
            this.ordertenderedLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertenderedLabel.Location = new System.Drawing.Point(507, 274);
            this.ordertenderedLabel.Name = "ordertenderedLabel";
            this.ordertenderedLabel.Size = new System.Drawing.Size(85, 18);
            this.ordertenderedLabel.TabIndex = 18;
            // 
            // orderchangeLabel
            // 
            this.orderchangeLabel.BackColor = System.Drawing.Color.White;
            this.orderchangeLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderchangeLabel.Location = new System.Drawing.Point(507, 292);
            this.orderchangeLabel.Name = "orderchangeLabel";
            this.orderchangeLabel.Size = new System.Drawing.Size(85, 18);
            this.orderchangeLabel.TabIndex = 19;
            // 
            // ordertaxpriceLabel
            // 
            this.ordertaxpriceLabel.BackColor = System.Drawing.Color.White;
            this.ordertaxpriceLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertaxpriceLabel.Location = new System.Drawing.Point(629, 224);
            this.ordertaxpriceLabel.Name = "ordertaxpriceLabel";
            this.ordertaxpriceLabel.Size = new System.Drawing.Size(122, 18);
            this.ordertaxpriceLabel.TabIndex = 20;
            // 
            // ordertotalpriceLabel
            // 
            this.ordertotalpriceLabel.BackColor = System.Drawing.Color.White;
            this.ordertotalpriceLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertotalpriceLabel.Location = new System.Drawing.Point(629, 242);
            this.ordertotalpriceLabel.Name = "ordertotalpriceLabel";
            this.ordertotalpriceLabel.Size = new System.Drawing.Size(122, 18);
            this.ordertotalpriceLabel.TabIndex = 21;
            // 
            // ordertenderedtotalLabel
            // 
            this.ordertenderedtotalLabel.BackColor = System.Drawing.Color.White;
            this.ordertenderedtotalLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordertenderedtotalLabel.Location = new System.Drawing.Point(629, 274);
            this.ordertenderedtotalLabel.Name = "ordertenderedtotalLabel";
            this.ordertenderedtotalLabel.Size = new System.Drawing.Size(122, 18);
            this.ordertenderedtotalLabel.TabIndex = 22;
            // 
            // orderchangetotalLabel
            // 
            this.orderchangetotalLabel.BackColor = System.Drawing.Color.White;
            this.orderchangetotalLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderchangetotalLabel.Location = new System.Drawing.Point(629, 292);
            this.orderchangetotalLabel.Name = "orderchangetotalLabel";
            this.orderchangetotalLabel.Size = new System.Drawing.Size(122, 18);
            this.orderchangetotalLabel.TabIndex = 23;
            // 
            // byeLabel
            // 
            this.byeLabel.BackColor = System.Drawing.Color.White;
            this.byeLabel.Font = new System.Drawing.Font("Square721 BdEx BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byeLabel.Location = new System.Drawing.Point(570, 335);
            this.byeLabel.Name = "byeLabel";
            this.byeLabel.Size = new System.Drawing.Size(122, 18);
            this.byeLabel.TabIndex = 24;
            this.byeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.DimGray;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Square721 BdEx BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.Orange;
            this.calculateButton.Location = new System.Drawing.Point(120, 206);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(241, 31);
            this.calculateButton.TabIndex = 25;
            this.calculateButton.Text = "Calculate Order";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Square721 Blk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.Orange;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 242);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(109, 36);
            this.subtotalLabel.TabIndex = 26;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // subtotalpriceLabel
            // 
            this.subtotalpriceLabel.Font = new System.Drawing.Font("Square721 Blk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalpriceLabel.ForeColor = System.Drawing.Color.Orange;
            this.subtotalpriceLabel.Location = new System.Drawing.Point(205, 242);
            this.subtotalpriceLabel.Name = "subtotalpriceLabel";
            this.subtotalpriceLabel.Size = new System.Drawing.Size(253, 36);
            this.subtotalpriceLabel.TabIndex = 27;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Square721 Blk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.Orange;
            this.taxLabel.Location = new System.Drawing.Point(12, 285);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(109, 36);
            this.taxLabel.TabIndex = 28;
            this.taxLabel.Text = "Tax";
            // 
            // taxpriceLabel
            // 
            this.taxpriceLabel.Font = new System.Drawing.Font("Square721 Blk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxpriceLabel.ForeColor = System.Drawing.Color.Orange;
            this.taxpriceLabel.Location = new System.Drawing.Point(205, 285);
            this.taxpriceLabel.Name = "taxpriceLabel";
            this.taxpriceLabel.Size = new System.Drawing.Size(156, 36);
            this.taxpriceLabel.TabIndex = 29;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Square721 Blk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Orange;
            this.totalLabel.Location = new System.Drawing.Point(12, 330);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(109, 36);
            this.totalLabel.TabIndex = 30;
            this.totalLabel.Text = "Total";
            // 
            // totalpriceLabel
            // 
            this.totalpriceLabel.Font = new System.Drawing.Font("Square721 Blk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpriceLabel.ForeColor = System.Drawing.Color.Orange;
            this.totalpriceLabel.Location = new System.Drawing.Point(205, 321);
            this.totalpriceLabel.Name = "totalpriceLabel";
            this.totalpriceLabel.Size = new System.Drawing.Size(156, 36);
            this.totalpriceLabel.TabIndex = 31;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Square721 Blk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.Orange;
            this.tenderedLabel.Location = new System.Drawing.Point(12, 366);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(109, 36);
            this.tenderedLabel.TabIndex = 32;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(151, 370);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(140, 20);
            this.tenderedBox.TabIndex = 33;
            this.tenderedBox.Text = "0";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DimGray;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Square721 BdEx BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Orange;
            this.changeButton.Location = new System.Drawing.Point(305, 362);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(173, 31);
            this.changeButton.TabIndex = 34;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Square721 Blk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.Orange;
            this.changeLabel.Location = new System.Drawing.Point(12, 402);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(109, 36);
            this.changeLabel.TabIndex = 35;
            this.changeLabel.Text = "Change";
            // 
            // changetotalLabel
            // 
            this.changetotalLabel.Font = new System.Drawing.Font("Square721 Blk", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changetotalLabel.ForeColor = System.Drawing.Color.Orange;
            this.changetotalLabel.Location = new System.Drawing.Point(147, 402);
            this.changetotalLabel.Name = "changetotalLabel";
            this.changetotalLabel.Size = new System.Drawing.Size(156, 36);
            this.changetotalLabel.TabIndex = 36;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.DimGray;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Square721 BdEx BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.Orange;
            this.printButton.Location = new System.Drawing.Point(305, 402);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(173, 31);
            this.printButton.TabIndex = 37;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(86, 9);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(266, 27);
            this.errorLabel.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changetotalLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalpriceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxpriceLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalpriceLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.byeLabel);
            this.Controls.Add(this.orderchangetotalLabel);
            this.Controls.Add(this.ordertenderedtotalLabel);
            this.Controls.Add(this.ordertotalpriceLabel);
            this.Controls.Add(this.ordertaxpriceLabel);
            this.Controls.Add(this.orderchangeLabel);
            this.Controls.Add(this.ordertenderedLabel);
            this.Controls.Add(this.ordertotalLabel);
            this.Controls.Add(this.ordertaxLabel);
            this.Controls.Add(this.ordersubtotalpriceLabel);
            this.Controls.Add(this.ordersubtotalLabel);
            this.Controls.Add(this.orderdrinkLabel);
            this.Controls.Add(this.orderfryLabel);
            this.Controls.Add(this.orderburgerLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.ordernumberLabel);
            this.Controls.Add(this.burgerplaceLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.boxLabel);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.fryBox);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.fryLabel);
            this.Controls.Add(this.burgerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label fryLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.TextBox fryBox;
        private System.Windows.Forms.TextBox drinkBox;
        private System.Windows.Forms.Label boxLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label burgerplaceLabel;
        private System.Windows.Forms.Label ordernumberLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label orderburgerLabel;
        private System.Windows.Forms.Label orderfryLabel;
        private System.Windows.Forms.Label orderdrinkLabel;
        private System.Windows.Forms.Label ordersubtotalLabel;
        private System.Windows.Forms.Label ordersubtotalpriceLabel;
        private System.Windows.Forms.Label ordertaxLabel;
        private System.Windows.Forms.Label ordertotalLabel;
        private System.Windows.Forms.Label ordertenderedLabel;
        private System.Windows.Forms.Label orderchangeLabel;
        private System.Windows.Forms.Label ordertaxpriceLabel;
        private System.Windows.Forms.Label ordertotalpriceLabel;
        private System.Windows.Forms.Label ordertenderedtotalLabel;
        private System.Windows.Forms.Label orderchangetotalLabel;
        private System.Windows.Forms.Label byeLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label subtotalpriceLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxpriceLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalpriceLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changetotalLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

