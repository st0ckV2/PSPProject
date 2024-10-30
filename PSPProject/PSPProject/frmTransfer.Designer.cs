namespace PSPProject
{
    partial class frmTransfer
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
            this.grpNumberDetails = new System.Windows.Forms.GroupBox();
            this.lblNumeralTotal = new System.Windows.Forms.Label();
            this.lblNumeralQty = new System.Windows.Forms.Label();
            this.lblNumeralItems = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblNoItems = new System.Windows.Forms.Label();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.bttPutOnHold = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttMakeAndPrint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpSaleDetails = new System.Windows.Forms.GroupBox();
            this.tblProductDetails = new System.Windows.Forms.TableLayoutPanel();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.txtScanItem = new PSPProject.Placeholder();
            this.txtBranchID = new PSPProject.Placeholder();
            this.grpNumberDetails.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpSaleDetails.SuspendLayout();
            this.grpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNumberDetails
            // 
            this.grpNumberDetails.Controls.Add(this.lblNumeralTotal);
            this.grpNumberDetails.Controls.Add(this.lblNumeralQty);
            this.grpNumberDetails.Controls.Add(this.lblNumeralItems);
            this.grpNumberDetails.Controls.Add(this.lblTotal);
            this.grpNumberDetails.Controls.Add(this.lblQty);
            this.grpNumberDetails.Controls.Add(this.lblNoItems);
            this.grpNumberDetails.Location = new System.Drawing.Point(534, 338);
            this.grpNumberDetails.Name = "grpNumberDetails";
            this.grpNumberDetails.Size = new System.Drawing.Size(254, 100);
            this.grpNumberDetails.TabIndex = 9;
            this.grpNumberDetails.TabStop = false;
            // 
            // lblNumeralTotal
            // 
            this.lblNumeralTotal.AutoSize = true;
            this.lblNumeralTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumeralTotal.Location = new System.Drawing.Point(170, 69);
            this.lblNumeralTotal.Name = "lblNumeralTotal";
            this.lblNumeralTotal.Size = new System.Drawing.Size(64, 20);
            this.lblNumeralTotal.TabIndex = 5;
            this.lblNumeralTotal.Text = "700.00";
            // 
            // lblNumeralQty
            // 
            this.lblNumeralQty.AutoSize = true;
            this.lblNumeralQty.Location = new System.Drawing.Point(221, 46);
            this.lblNumeralQty.Name = "lblNumeralQty";
            this.lblNumeralQty.Size = new System.Drawing.Size(13, 13);
            this.lblNumeralQty.TabIndex = 4;
            this.lblNumeralQty.Text = "5";
            // 
            // lblNumeralItems
            // 
            this.lblNumeralItems.AutoSize = true;
            this.lblNumeralItems.Location = new System.Drawing.Point(221, 20);
            this.lblNumeralItems.Name = "lblNumeralItems";
            this.lblNumeralItems.Size = new System.Drawing.Size(13, 13);
            this.lblNumeralItems.TabIndex = 3;
            this.lblNumeralItems.Text = "3";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(105, 69);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(10, 46);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(144, 13);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "Cantidad Total De Productos";
            // 
            // lblNoItems
            // 
            this.lblNoItems.AutoSize = true;
            this.lblNoItems.Location = new System.Drawing.Point(62, 20);
            this.lblNoItems.Name = "lblNoItems";
            this.lblNoItems.Size = new System.Drawing.Size(92, 13);
            this.lblNoItems.TabIndex = 0;
            this.lblNoItems.Text = "No. De Productos";
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.bttPutOnHold);
            this.grpControls.Controls.Add(this.bttCancel);
            this.grpControls.Controls.Add(this.bttMakeAndPrint);
            this.grpControls.Controls.Add(this.groupBox2);
            this.grpControls.Location = new System.Drawing.Point(12, 338);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(510, 100);
            this.grpControls.TabIndex = 8;
            this.grpControls.TabStop = false;
            // 
            // bttPutOnHold
            // 
            this.bttPutOnHold.Location = new System.Drawing.Point(22, 17);
            this.bttPutOnHold.Name = "bttPutOnHold";
            this.bttPutOnHold.Size = new System.Drawing.Size(150, 70);
            this.bttPutOnHold.TabIndex = 10;
            this.bttPutOnHold.Text = "Poner En Espera";
            this.bttPutOnHold.UseVisualStyleBackColor = true;
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(179, 18);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(150, 70);
            this.bttCancel.TabIndex = 9;
            this.bttCancel.Text = "Cancelar Opercaión";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // bttMakeAndPrint
            // 
            this.bttMakeAndPrint.Location = new System.Drawing.Point(339, 17);
            this.bttMakeAndPrint.Name = "bttMakeAndPrint";
            this.bttMakeAndPrint.Size = new System.Drawing.Size(150, 70);
            this.bttMakeAndPrint.TabIndex = 8;
            this.bttMakeAndPrint.Text = "Realizar E Imprimir Nota";
            this.bttMakeAndPrint.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(516, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // grpSaleDetails
            // 
            this.grpSaleDetails.Controls.Add(this.tblProductDetails);
            this.grpSaleDetails.Location = new System.Drawing.Point(12, 74);
            this.grpSaleDetails.Name = "grpSaleDetails";
            this.grpSaleDetails.Size = new System.Drawing.Size(776, 258);
            this.grpSaleDetails.TabIndex = 7;
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
            this.tblProductDetails.RowCount = 12;
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductDetails.Size = new System.Drawing.Size(723, 219);
            this.tblProductDetails.TabIndex = 0;
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.txtScanItem);
            this.grpData.Controls.Add(this.txtBranchID);
            this.grpData.Location = new System.Drawing.Point(12, 12);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(776, 56);
            this.grpData.TabIndex = 6;
            this.grpData.TabStop = false;
            // 
            // txtScanItem
            // 
            this.txtScanItem.ForeColor = System.Drawing.Color.DimGray;
            this.txtScanItem.Location = new System.Drawing.Point(301, 19);
            this.txtScanItem.Name = "txtScanItem";
            this.txtScanItem.PlaceHolder = "Escanee o ingrese el ID del producto";
            this.txtScanItem.Size = new System.Drawing.Size(444, 20);
            this.txtScanItem.TabIndex = 2;
            this.txtScanItem.Text = "Escanee o ingrese el ID del producto";
            // 
            // txtBranchID
            // 
            this.txtBranchID.ForeColor = System.Drawing.Color.DimGray;
            this.txtBranchID.Location = new System.Drawing.Point(22, 19);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.PlaceHolder = "Ingrese ID de la sucursal a traspasar";
            this.txtBranchID.Size = new System.Drawing.Size(253, 20);
            this.txtBranchID.TabIndex = 1;
            this.txtBranchID.Text = "Ingrese ID de la sucursal a traspasar";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpNumberDetails);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.grpSaleDetails);
            this.Controls.Add(this.grpData);
            this.Name = "frmTransfer";
            this.Text = "Traspaso";
            this.grpNumberDetails.ResumeLayout(false);
            this.grpNumberDetails.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpSaleDetails.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNumberDetails;
        private System.Windows.Forms.Label lblNumeralTotal;
        private System.Windows.Forms.Label lblNumeralQty;
        private System.Windows.Forms.Label lblNumeralItems;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblNoItems;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button bttPutOnHold;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttMakeAndPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpSaleDetails;
        private System.Windows.Forms.TableLayoutPanel tblProductDetails;
        private System.Windows.Forms.GroupBox grpData;
        private Placeholder txtScanItem;
        private Placeholder txtBranchID;
    }
}