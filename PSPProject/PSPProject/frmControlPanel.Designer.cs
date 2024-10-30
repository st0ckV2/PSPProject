namespace PSPProject
{
    partial class frmControlPanel
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
            this.grpStore = new System.Windows.Forms.GroupBox();
            this.bttMakeSale = new System.Windows.Forms.Button();
            this.bttMakeTransfer = new System.Windows.Forms.Button();
            this.grpAdministration = new System.Windows.Forms.GroupBox();
            this.bttMakePurchase = new System.Windows.Forms.Button();
            this.bttAddEmployee = new System.Windows.Forms.Button();
            this.bttMakeAssignment = new System.Windows.Forms.Button();
            this.bttViewInventory = new System.Windows.Forms.Button();
            this.bttSeeSales = new System.Windows.Forms.Button();
            this.bttViewPurchases = new System.Windows.Forms.Button();
            this.grpStore.SuspendLayout();
            this.grpAdministration.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStore
            // 
            this.grpStore.Controls.Add(this.bttSeeSales);
            this.grpStore.Controls.Add(this.bttViewInventory);
            this.grpStore.Controls.Add(this.bttMakeTransfer);
            this.grpStore.Controls.Add(this.bttMakeSale);
            this.grpStore.Location = new System.Drawing.Point(12, 12);
            this.grpStore.Name = "grpStore";
            this.grpStore.Size = new System.Drawing.Size(382, 426);
            this.grpStore.TabIndex = 0;
            this.grpStore.TabStop = false;
            this.grpStore.Text = "Tienda";
            this.grpStore.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bttMakeSale
            // 
            this.bttMakeSale.Location = new System.Drawing.Point(20, 50);
            this.bttMakeSale.Name = "bttMakeSale";
            this.bttMakeSale.Size = new System.Drawing.Size(340, 69);
            this.bttMakeSale.TabIndex = 0;
            this.bttMakeSale.Text = "Realizar Venta";
            this.bttMakeSale.UseVisualStyleBackColor = true;
            // 
            // bttMakeTransfer
            // 
            this.bttMakeTransfer.Location = new System.Drawing.Point(20, 225);
            this.bttMakeTransfer.Name = "bttMakeTransfer";
            this.bttMakeTransfer.Size = new System.Drawing.Size(340, 69);
            this.bttMakeTransfer.TabIndex = 1;
            this.bttMakeTransfer.Text = "Realizar Traspaso";
            this.bttMakeTransfer.UseVisualStyleBackColor = true;
            // 
            // grpAdministration
            // 
            this.grpAdministration.Controls.Add(this.bttViewPurchases);
            this.grpAdministration.Controls.Add(this.bttMakeAssignment);
            this.grpAdministration.Controls.Add(this.bttMakePurchase);
            this.grpAdministration.Controls.Add(this.bttAddEmployee);
            this.grpAdministration.Location = new System.Drawing.Point(406, 12);
            this.grpAdministration.Name = "grpAdministration";
            this.grpAdministration.Size = new System.Drawing.Size(382, 426);
            this.grpAdministration.TabIndex = 3;
            this.grpAdministration.TabStop = false;
            this.grpAdministration.Text = "Administración ";
            this.grpAdministration.Enter += new System.EventHandler(this.grpAdministration_Enter);
            // 
            // bttMakePurchase
            // 
            this.bttMakePurchase.Location = new System.Drawing.Point(21, 225);
            this.bttMakePurchase.Name = "bttMakePurchase";
            this.bttMakePurchase.Size = new System.Drawing.Size(340, 69);
            this.bttMakePurchase.TabIndex = 1;
            this.bttMakePurchase.Text = "Realizar Compra De Mercancía";
            this.bttMakePurchase.UseVisualStyleBackColor = true;
            // 
            // bttAddEmployee
            // 
            this.bttAddEmployee.Location = new System.Drawing.Point(21, 50);
            this.bttAddEmployee.Name = "bttAddEmployee";
            this.bttAddEmployee.Size = new System.Drawing.Size(340, 69);
            this.bttAddEmployee.TabIndex = 0;
            this.bttAddEmployee.Text = "Agregar Empleado";
            this.bttAddEmployee.UseVisualStyleBackColor = true;
            // 
            // bttMakeAssignment
            // 
            this.bttMakeAssignment.Location = new System.Drawing.Point(21, 136);
            this.bttMakeAssignment.Name = "bttMakeAssignment";
            this.bttMakeAssignment.Size = new System.Drawing.Size(340, 69);
            this.bttMakeAssignment.TabIndex = 2;
            this.bttMakeAssignment.Text = "Realizar Asignación De Empleado";
            this.bttMakeAssignment.UseVisualStyleBackColor = true;
            // 
            // bttViewInventory
            // 
            this.bttViewInventory.Location = new System.Drawing.Point(20, 136);
            this.bttViewInventory.Name = "bttViewInventory";
            this.bttViewInventory.Size = new System.Drawing.Size(340, 69);
            this.bttViewInventory.TabIndex = 2;
            this.bttViewInventory.Text = "Ver Inventario";
            this.bttViewInventory.UseVisualStyleBackColor = true;
            // 
            // bttSeeSales
            // 
            this.bttSeeSales.Location = new System.Drawing.Point(20, 311);
            this.bttSeeSales.Name = "bttSeeSales";
            this.bttSeeSales.Size = new System.Drawing.Size(340, 69);
            this.bttSeeSales.TabIndex = 3;
            this.bttSeeSales.Text = "Ver Ventas Realizadas";
            this.bttSeeSales.UseVisualStyleBackColor = true;
            // 
            // bttViewPurchases
            // 
            this.bttViewPurchases.Location = new System.Drawing.Point(21, 311);
            this.bttViewPurchases.Name = "bttViewPurchases";
            this.bttViewPurchases.Size = new System.Drawing.Size(340, 69);
            this.bttViewPurchases.TabIndex = 3;
            this.bttViewPurchases.Text = "Ver Compras Realizadas";
            this.bttViewPurchases.UseVisualStyleBackColor = true;
            // 
            // frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAdministration);
            this.Controls.Add(this.grpStore);
            this.Name = "frmControlPanel";
            this.Text = "Panel de control";
            this.grpStore.ResumeLayout(false);
            this.grpAdministration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStore;
        private System.Windows.Forms.Button bttMakeTransfer;
        private System.Windows.Forms.Button bttMakeSale;
        private System.Windows.Forms.GroupBox grpAdministration;
        private System.Windows.Forms.Button bttMakePurchase;
        private System.Windows.Forms.Button bttAddEmployee;
        private System.Windows.Forms.Button bttSeeSales;
        private System.Windows.Forms.Button bttViewInventory;
        private System.Windows.Forms.Button bttViewPurchases;
        private System.Windows.Forms.Button bttMakeAssignment;
    }
}