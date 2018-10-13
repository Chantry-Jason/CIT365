namespace MegaDesk_3_Jason_Chantry
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddQuote = new System.Windows.Forms.Button();
            this.buttonViewQuote = new System.Windows.Forms.Button();
            this.buttonSearchQuote = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(401, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddQuote
            // 
            this.buttonAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQuote.Location = new System.Drawing.Point(52, 38);
            this.buttonAddQuote.Name = "buttonAddQuote";
            this.buttonAddQuote.Size = new System.Drawing.Size(260, 64);
            this.buttonAddQuote.TabIndex = 1;
            this.buttonAddQuote.Text = "&Add New Quote";
            this.buttonAddQuote.UseVisualStyleBackColor = true;
            this.buttonAddQuote.Click += new System.EventHandler(this.buttonAddQuote_Click);
            // 
            // buttonViewQuote
            // 
            this.buttonViewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewQuote.Location = new System.Drawing.Point(52, 120);
            this.buttonViewQuote.Name = "buttonViewQuote";
            this.buttonViewQuote.Size = new System.Drawing.Size(260, 64);
            this.buttonViewQuote.TabIndex = 2;
            this.buttonViewQuote.Text = "&View Quotes";
            this.buttonViewQuote.UseVisualStyleBackColor = true;
            this.buttonViewQuote.Click += new System.EventHandler(this.buttonViewQuote_Click);
            // 
            // buttonSearchQuote
            // 
            this.buttonSearchQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchQuote.Location = new System.Drawing.Point(52, 205);
            this.buttonSearchQuote.Name = "buttonSearchQuote";
            this.buttonSearchQuote.Size = new System.Drawing.Size(260, 64);
            this.buttonSearchQuote.TabIndex = 3;
            this.buttonSearchQuote.Text = "&Search Quotes";
            this.buttonSearchQuote.UseVisualStyleBackColor = true;
            this.buttonSearchQuote.Click += new System.EventHandler(this.buttonSearchQuote_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(52, 293);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(260, 64);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 390);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearchQuote);
            this.Controls.Add(this.buttonViewQuote);
            this.Controls.Add(this.buttonAddQuote);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MegaDesk v4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddQuote;
        private System.Windows.Forms.Button buttonViewQuote;
        private System.Windows.Forms.Button buttonSearchQuote;
        private System.Windows.Forms.Button buttonExit;
    }
}

