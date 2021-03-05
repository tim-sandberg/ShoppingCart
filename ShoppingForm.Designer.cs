namespace ShoppingCart
{
    partial class ShoppingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApples = new System.Windows.Forms.Button();
            this.btnBroccoli = new System.Windows.Forms.Button();
            this.btnCarrots = new System.Windows.Forms.Button();
            this.btnDillPickles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnScan = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApples
            // 
            this.btnApples.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApples.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnApples.Location = new System.Drawing.Point(22, 49);
            this.btnApples.Name = "btnApples";
            this.btnApples.Size = new System.Drawing.Size(93, 31);
            this.btnApples.TabIndex = 0;
            this.btnApples.Text = "Apples (\"A\")";
            this.btnApples.UseVisualStyleBackColor = true;
            this.btnApples.Click += new System.EventHandler(this.BtnApples_OnClick);
            // 
            // btnBroccoli
            // 
            this.btnBroccoli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBroccoli.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBroccoli.Location = new System.Drawing.Point(142, 49);
            this.btnBroccoli.Name = "btnBroccoli";
            this.btnBroccoli.Size = new System.Drawing.Size(95, 31);
            this.btnBroccoli.TabIndex = 1;
            this.btnBroccoli.Text = "Broccoli (\"B\")";
            this.btnBroccoli.UseVisualStyleBackColor = true;
            this.btnBroccoli.Click += new System.EventHandler(this.BtnBroccoli_OnClick);
            // 
            // btnCarrots
            // 
            this.btnCarrots.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarrots.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCarrots.Location = new System.Drawing.Point(257, 49);
            this.btnCarrots.Name = "btnCarrots";
            this.btnCarrots.Size = new System.Drawing.Size(98, 31);
            this.btnCarrots.TabIndex = 2;
            this.btnCarrots.Text = "Carrots (\"C\")";
            this.btnCarrots.UseVisualStyleBackColor = true;
            this.btnCarrots.Click += new System.EventHandler(this.BtnCarrots_OnClick);
            // 
            // btnDillPickles
            // 
            this.btnDillPickles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDillPickles.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDillPickles.Location = new System.Drawing.Point(376, 49);
            this.btnDillPickles.Name = "btnDillPickles";
            this.btnDillPickles.Size = new System.Drawing.Size(113, 31);
            this.btnDillPickles.TabIndex = 3;
            this.btnDillPickles.Text = "Dill Pickles (\"D\")";
            this.btnDillPickles.UseVisualStyleBackColor = true;
            this.btnDillPickles.Click += new System.EventHandler(this.BtnDillPickles_OnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(224, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shopping Cart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(224, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Receipt";
            // 
            // BtnScan
            // 
            this.BtnScan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnScan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnScan.Location = new System.Drawing.Point(22, 345);
            this.BtnScan.Name = "BtnScan";
            this.BtnScan.Size = new System.Drawing.Size(155, 93);
            this.BtnScan.TabIndex = 7;
            this.BtnScan.Text = "Scan Items After Cart Selected";
            this.BtnScan.UseVisualStyleBackColor = true;
            this.BtnScan.Click += new System.EventHandler(this.BtnScan_OnClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(224, 345);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 8;
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShoppingCart.Location = new System.Drawing.Point(224, 161);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(0, 25);
            this.lblShoppingCart.TabIndex = 9;
            // 
            // btnClearCart
            // 
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearCart.Location = new System.Drawing.Point(619, 345);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(155, 93);
            this.btnClearCart.TabIndex = 10;
            this.btnClearCart.Text = "Clear Cart ";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // ShoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.lblShoppingCart);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.BtnScan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDillPickles);
            this.Controls.Add(this.btnCarrots);
            this.Controls.Add(this.btnBroccoli);
            this.Controls.Add(this.btnApples);
            this.Name = "ShoppingForm";
            this.Text = "Shopping Form";
            this.Load += new System.EventHandler(this.ShoppingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApples;
        private System.Windows.Forms.Button btnBroccoli;
        private System.Windows.Forms.Button btnCarrots;
        private System.Windows.Forms.Button btnDillPickles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnScan;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.Button btnClearCart;
    }
}

