namespace PSPProject
{
    partial class frmBranches
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
            this.grpSelecrBranches = new System.Windows.Forms.GroupBox();
            this.bttBranchPalenque = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelectBranch = new System.Windows.Forms.Label();
            this.grpSelecrBranches.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelecrBranches
            // 
            this.grpSelecrBranches.Controls.Add(this.lblSelectBranch);
            this.grpSelecrBranches.Controls.Add(this.button1);
            this.grpSelecrBranches.Controls.Add(this.bttBranchPalenque);
            this.grpSelecrBranches.Location = new System.Drawing.Point(140, 78);
            this.grpSelecrBranches.Name = "grpSelecrBranches";
            this.grpSelecrBranches.Size = new System.Drawing.Size(509, 246);
            this.grpSelecrBranches.TabIndex = 0;
            this.grpSelecrBranches.TabStop = false;
            // 
            // bttBranchPalenque
            // 
            this.bttBranchPalenque.Location = new System.Drawing.Point(75, 77);
            this.bttBranchPalenque.Name = "bttBranchPalenque";
            this.bttBranchPalenque.Size = new System.Drawing.Size(130, 92);
            this.bttBranchPalenque.TabIndex = 0;
            this.bttBranchPalenque.Text = "Palenque";
            this.bttBranchPalenque.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "D\' Sofi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSelectBranch
            // 
            this.lblSelectBranch.AutoSize = true;
            this.lblSelectBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectBranch.Location = new System.Drawing.Point(162, 16);
            this.lblSelectBranch.Name = "lblSelectBranch";
            this.lblSelectBranch.Size = new System.Drawing.Size(181, 20);
            this.lblSelectBranch.TabIndex = 2;
            this.lblSelectBranch.Text = "Seleccione una sucursal";
            // 
            // frmBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSelecrBranches);
            this.Name = "frmBranches";
            this.Text = "Sucursales";
            this.grpSelecrBranches.ResumeLayout(false);
            this.grpSelecrBranches.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelecrBranches;
        private System.Windows.Forms.Label lblSelectBranch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttBranchPalenque;
    }
}