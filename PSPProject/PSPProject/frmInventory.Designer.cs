namespace PSPProject
{
    partial class frmInventory
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
            this.grpSaleDetails = new System.Windows.Forms.GroupBox();
            this.tblProductDetails = new System.Windows.Forms.TableLayoutPanel();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.txtScanItem = new PSPProject.Placeholder();
            this.grpSaleDetails.SuspendLayout();
            this.grpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSaleDetails
            // 
            this.grpSaleDetails.Controls.Add(this.tblProductDetails);
            this.grpSaleDetails.Location = new System.Drawing.Point(12, 70);
            this.grpSaleDetails.Name = "grpSaleDetails";
            this.grpSaleDetails.Size = new System.Drawing.Size(776, 368);
            this.grpSaleDetails.TabIndex = 4;
            this.grpSaleDetails.TabStop = false;
            // 
            // tblProductDetails
            // 
            this.tblProductDetails.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblProductDetails.ColumnCount = 5;
            this.tblProductDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.96491F));
            this.tblProductDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.03509F));
            this.tblProductDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tblProductDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblProductDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tblProductDetails.Location = new System.Drawing.Point(22, 20);
            this.tblProductDetails.Name = "tblProductDetails";
            this.tblProductDetails.RowCount = 15;
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductDetails.Size = new System.Drawing.Size(723, 331);
            this.tblProductDetails.TabIndex = 0;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.txtScanItem);
            this.grpData.Location = new System.Drawing.Point(12, 8);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(776, 56);
            this.grpData.TabIndex = 3;
            this.grpData.TabStop = false;
            // 
            // txtScanItem
            // 
            this.txtScanItem.ForeColor = System.Drawing.Color.DimGray;
            this.txtScanItem.Location = new System.Drawing.Point(22, 19);
            this.txtScanItem.Name = "txtScanItem";
            this.txtScanItem.PlaceHolder = "Escanee o ingrese el ID del producto a buscar";
            this.txtScanItem.Size = new System.Drawing.Size(723, 20);
            this.txtScanItem.TabIndex = 2;
            this.txtScanItem.Text = "Escanee o ingrese el ID del producto a buscar";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSaleDetails);
            this.Controls.Add(this.grpData);
            this.Name = "frmInventory";
            this.Text = "Inventario";
            this.grpSaleDetails.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSaleDetails;
        private System.Windows.Forms.TableLayoutPanel tblProductDetails;
        private System.Windows.Forms.GroupBox grpData;
        private Placeholder txtScanItem;
    }
}