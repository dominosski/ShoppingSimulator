namespace DemoShop
{
    partial class DemoShop
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartlistBox = new System.Windows.Forms.ListBox();
            this.shoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorsListBox = new System.Windows.Forms.ListBox();
            this.vendorList = new System.Windows.Forms.Label();
            this.storePayoutLabel = new System.Windows.Forms.Label();
            this.storePayoutValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.itemsListBoxLabel.Location = new System.Drawing.Point(97, 110);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(146, 29);
            this.itemsListBoxLabel.TabIndex = 0;
            this.itemsListBoxLabel.Text = "Store Items";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 29;
            this.itemsListBox.Location = new System.Drawing.Point(105, 142);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(231, 178);
            this.itemsListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(97, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "SHOP";
            // 
            // addToCart
            // 
            this.addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addToCart.Location = new System.Drawing.Point(413, 209);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(160, 41);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCartlistBox
            // 
            this.shoppingCartlistBox.FormattingEnabled = true;
            this.shoppingCartlistBox.ItemHeight = 29;
            this.shoppingCartlistBox.Location = new System.Drawing.Point(638, 142);
            this.shoppingCartlistBox.Name = "shoppingCartlistBox";
            this.shoppingCartlistBox.Size = new System.Drawing.Size(231, 178);
            this.shoppingCartlistBox.TabIndex = 5;
            // 
            // shoppingCartListBoxLabel
            // 
            this.shoppingCartListBoxLabel.AutoSize = true;
            this.shoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shoppingCartListBoxLabel.Location = new System.Drawing.Point(630, 110);
            this.shoppingCartListBoxLabel.Name = "shoppingCartListBoxLabel";
            this.shoppingCartListBoxLabel.Size = new System.Drawing.Size(180, 29);
            this.shoppingCartListBoxLabel.TabIndex = 4;
            this.shoppingCartListBoxLabel.Text = "Shopping Cart";
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(743, 327);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(125, 47);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorsListBox
            // 
            this.vendorsListBox.FormattingEnabled = true;
            this.vendorsListBox.ItemHeight = 29;
            this.vendorsListBox.Location = new System.Drawing.Point(105, 421);
            this.vendorsListBox.Name = "vendorsListBox";
            this.vendorsListBox.Size = new System.Drawing.Size(231, 178);
            this.vendorsListBox.TabIndex = 8;
            this.vendorsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // vendorList
            // 
            this.vendorList.AutoSize = true;
            this.vendorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vendorList.Location = new System.Drawing.Point(97, 389);
            this.vendorList.Name = "vendorList";
            this.vendorList.Size = new System.Drawing.Size(145, 29);
            this.vendorList.TabIndex = 7;
            this.vendorList.Text = "Vendor List";
            this.vendorList.Click += new System.EventHandler(this.label2_Click);
            // 
            // storePayoutLabel
            // 
            this.storePayoutLabel.AutoSize = true;
            this.storePayoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storePayoutLabel.Location = new System.Drawing.Point(638, 389);
            this.storePayoutLabel.Name = "storePayoutLabel";
            this.storePayoutLabel.Size = new System.Drawing.Size(125, 25);
            this.storePayoutLabel.TabIndex = 9;
            this.storePayoutLabel.Text = "Store Payout";
            // 
            // storePayoutValue
            // 
            this.storePayoutValue.AutoSize = true;
            this.storePayoutValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storePayoutValue.Location = new System.Drawing.Point(786, 389);
            this.storePayoutValue.Name = "storePayoutValue";
            this.storePayoutValue.Size = new System.Drawing.Size(66, 25);
            this.storePayoutValue.TabIndex = 10;
            this.storePayoutValue.Text = "$0,00 ";
            // 
            // DemoShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 653);
            this.Controls.Add(this.storePayoutValue);
            this.Controls.Add(this.storePayoutLabel);
            this.Controls.Add(this.vendorsListBox);
            this.Controls.Add(this.vendorList);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartlistBox);
            this.Controls.Add(this.shoppingCartListBoxLabel);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DemoShop";
            this.Text = "Demo Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.ListBox shoppingCartlistBox;
        private System.Windows.Forms.Label shoppingCartListBoxLabel;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.ListBox vendorsListBox;
        private System.Windows.Forms.Label vendorList;
        private System.Windows.Forms.Label storePayoutLabel;
        private System.Windows.Forms.Label storePayoutValue;
    }
}

