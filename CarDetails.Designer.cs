
namespace WindowsFormsApp1
{
    partial class CarDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Carname = new System.Windows.Forms.TextBox();
            this.Brandname = new System.Windows.Forms.TextBox();
            this.Carprice = new System.Windows.Forms.TextBox();
            this.No_Of_Car_In_Stock = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Modelno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BRAND NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "CAR PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "MODEL NO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Carname
            // 
            this.Carname.Location = new System.Drawing.Point(271, 73);
            this.Carname.Name = "Carname";
            this.Carname.Size = new System.Drawing.Size(100, 22);
            this.Carname.TabIndex = 4;
            this.Carname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Brandname
            // 
            this.Brandname.Location = new System.Drawing.Point(271, 138);
            this.Brandname.Name = "Brandname";
            this.Brandname.Size = new System.Drawing.Size(100, 22);
            this.Brandname.TabIndex = 5;
            this.Brandname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Carprice
            // 
            this.Carprice.Location = new System.Drawing.Point(271, 202);
            this.Carprice.Name = "Carprice";
            this.Carprice.Size = new System.Drawing.Size(100, 22);
            this.Carprice.TabIndex = 6;
            this.Carprice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // No_Of_Car_In_Stock
            // 
            this.No_Of_Car_In_Stock.Location = new System.Drawing.Point(271, 275);
            this.No_Of_Car_In_Stock.Name = "No_Of_Car_In_Stock";
            this.No_Of_Car_In_Stock.Size = new System.Drawing.Size(100, 22);
            this.No_Of_Car_In_Stock.TabIndex = 7;
            this.No_Of_Car_In_Stock.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "VIEW ALL DETAILS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "NO OF CAR IN STOCK";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Modelno
            // 
            this.Modelno.Location = new System.Drawing.Point(271, 357);
            this.Modelno.Name = "Modelno";
            this.Modelno.Size = new System.Drawing.Size(100, 22);
            this.Modelno.TabIndex = 12;
            this.Modelno.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Modelno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.No_Of_Car_In_Stock);
            this.Controls.Add(this.Carprice);
            this.Controls.Add(this.Brandname);
            this.Controls.Add(this.Carname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarDetails";
            this.Text = "CarDetails";
            this.Load += new System.EventHandler(this.CarDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Carname;
        private System.Windows.Forms.TextBox Brandname;
        private System.Windows.Forms.TextBox Carprice;
        private System.Windows.Forms.TextBox No_Of_Car_In_Stock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Modelno;
    }
}