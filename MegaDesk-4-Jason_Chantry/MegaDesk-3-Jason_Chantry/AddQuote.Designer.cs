﻿namespace MegaDesk_3_Jason_Chantry
{
    partial class AddQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textCustName = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textDepth = new System.Windows.Forms.TextBox();
            this.textNumDrawers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreateQuote = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textCost = new System.Windows.Forms.TextBox();
            this.CalcCostButton = new System.Windows.Forms.Button();
            this.listSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.listRushOrder = new System.Windows.Forms.ComboBox();
            this.DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(688, 472);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 64);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add a New Quote";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(8, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(940, 5);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Desk Width:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(539, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Desk Depth:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textCustName
            // 
            this.textCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCustName.Location = new System.Drawing.Point(275, 77);
            this.textCustName.MaxLength = 128;
            this.textCustName.Name = "textCustName";
            this.textCustName.Size = new System.Drawing.Size(672, 38);
            this.textCustName.TabIndex = 1;
            // 
            // textWidth
            // 
            this.textWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWidth.Location = new System.Drawing.Point(275, 134);
            this.textWidth.MaxLength = 2;
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(126, 38);
            this.textWidth.TabIndex = 2;
            this.textWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textWidth_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "inches";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(854, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "inches";
            // 
            // textDepth
            // 
            this.textDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepth.Location = new System.Drawing.Point(722, 134);
            this.textDepth.MaxLength = 2;
            this.textDepth.Name = "textDepth";
            this.textDepth.Size = new System.Drawing.Size(126, 38);
            this.textDepth.TabIndex = 3;
            this.textDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepth_KeyPress);
            // 
            // textNumDrawers
            // 
            this.textNumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumDrawers.Location = new System.Drawing.Point(275, 191);
            this.textNumDrawers.MaxLength = 1;
            this.textNumDrawers.Name = "textNumDrawers";
            this.textNumDrawers.Size = new System.Drawing.Size(126, 38);
            this.textNumDrawers.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 31);
            this.label10.TabIndex = 16;
            this.label10.Text = "Number of Drawers:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 31);
            this.label11.TabIndex = 18;
            this.label11.Text = "Surface Material:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 31);
            this.label12.TabIndex = 20;
            this.label12.Text = "Rush Order: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCreateQuote
            // 
            this.btnCreateQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuote.Location = new System.Drawing.Point(413, 472);
            this.btnCreateQuote.Name = "btnCreateQuote";
            this.btnCreateQuote.Size = new System.Drawing.Size(260, 64);
            this.btnCreateQuote.TabIndex = 8;
            this.btnCreateQuote.Text = "C&reate Quote";
            this.btnCreateQuote.UseVisualStyleBackColor = true;
            this.btnCreateQuote.Click += new System.EventHandler(this.btnCreateQuote_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(74, 475);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 31);
            this.label13.TabIndex = 24;
            this.label13.Text = "Cost: ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textCost
            // 
            this.textCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCost.Location = new System.Drawing.Point(167, 472);
            this.textCost.MaxLength = 2;
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(126, 38);
            this.textCost.TabIndex = 25;
            this.textCost.TextChanged += new System.EventHandler(this.textCost_TextChanged);
            // 
            // CalcCostButton
            // 
            this.CalcCostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcCostButton.Location = new System.Drawing.Point(80, 416);
            this.CalcCostButton.Name = "CalcCostButton";
            this.CalcCostButton.Size = new System.Drawing.Size(213, 41);
            this.CalcCostButton.TabIndex = 7;
            this.CalcCostButton.Text = "Ca&lculate Cost";
            this.CalcCostButton.UseVisualStyleBackColor = true;
            this.CalcCostButton.Click += new System.EventHandler(this.CalcCostButton_Click);
            // 
            // listSurfaceMaterial
            // 
            this.listSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSurfaceMaterial.FormattingEnabled = true;
            this.listSurfaceMaterial.Location = new System.Drawing.Point(275, 248);
            this.listSurfaceMaterial.Name = "listSurfaceMaterial";
            this.listSurfaceMaterial.Size = new System.Drawing.Size(320, 39);
            this.listSurfaceMaterial.TabIndex = 5;
            // 
            // listRushOrder
            // 
            this.listRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRushOrder.FormattingEnabled = true;
            this.listRushOrder.Location = new System.Drawing.Point(275, 301);
            this.listRushOrder.Name = "listRushOrder";
            this.listRushOrder.Size = new System.Drawing.Size(320, 39);
            this.listRushOrder.TabIndex = 6;
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(727, 15);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(219, 31);
            this.DateLabel.TabIndex = 26;
            this.DateLabel.Text = "Todays Date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddQuote
            // 
            this.ClientSize = new System.Drawing.Size(958, 548);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.listRushOrder);
            this.Controls.Add(this.listSurfaceMaterial);
            this.Controls.Add(this.CalcCostButton);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreateQuote);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textNumDrawers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textDepth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.textCustName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddQuote";
            this.Text = "Create Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCustName;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDepth;
        private System.Windows.Forms.TextBox textNumDrawers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCreateQuote;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Button CalcCostButton;
        private System.Windows.Forms.ComboBox listSurfaceMaterial;
        private System.Windows.Forms.ComboBox listRushOrder;
        private System.Windows.Forms.Label DateLabel;
    }
}