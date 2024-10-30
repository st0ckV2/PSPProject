namespace PSPProject
{
    partial class frmAddEmployee
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
            this.grpPersonalData = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bttNew = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttEdit = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttUploadImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonalData
            // 
            this.grpPersonalData.Controls.Add(this.pictureBox1);
            this.grpPersonalData.Controls.Add(this.bttUploadImage);
            this.grpPersonalData.Controls.Add(this.bttCancel);
            this.grpPersonalData.Controls.Add(this.bttEdit);
            this.grpPersonalData.Controls.Add(this.bttSave);
            this.grpPersonalData.Controls.Add(this.bttNew);
            this.grpPersonalData.Controls.Add(this.textBox4);
            this.grpPersonalData.Controls.Add(this.textBox3);
            this.grpPersonalData.Controls.Add(this.textBox2);
            this.grpPersonalData.Controls.Add(this.textBox1);
            this.grpPersonalData.Controls.Add(this.lblAdress);
            this.grpPersonalData.Controls.Add(this.lblPhoneNumber);
            this.grpPersonalData.Controls.Add(this.lblLastName);
            this.grpPersonalData.Controls.Add(this.lblName);
            this.grpPersonalData.Location = new System.Drawing.Point(12, 12);
            this.grpPersonalData.Name = "grpPersonalData";
            this.grpPersonalData.Size = new System.Drawing.Size(660, 320);
            this.grpPersonalData.TabIndex = 0;
            this.grpPersonalData.TabStop = false;
            this.grpPersonalData.Text = "Datos Personales";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(25, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastName.Location = new System.Drawing.Point(24, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Apellidos";
            this.lblLastName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(24, 104);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(71, 20);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Teléfono";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdress.Location = new System.Drawing.Point(25, 138);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(75, 20);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Dirección";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(276, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 20);
            this.textBox4.TabIndex = 7;
            // 
            // bttNew
            // 
            this.bttNew.Location = new System.Drawing.Point(28, 185);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(159, 46);
            this.bttNew.TabIndex = 8;
            this.bttNew.Text = "Nuevo";
            this.bttNew.UseVisualStyleBackColor = true;
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(233, 185);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(159, 46);
            this.bttSave.TabIndex = 9;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = true;
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(29, 251);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(159, 46);
            this.bttEdit.TabIndex = 10;
            this.bttEdit.Text = "Modificar";
            this.bttEdit.UseVisualStyleBackColor = true;
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(233, 251);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(159, 46);
            this.bttCancel.TabIndex = 11;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // bttUploadImage
            // 
            this.bttUploadImage.Location = new System.Drawing.Point(448, 251);
            this.bttUploadImage.Name = "bttUploadImage";
            this.bttUploadImage.Size = new System.Drawing.Size(159, 46);
            this.bttUploadImage.TabIndex = 12;
            this.bttUploadImage.Text = "Cargar Imagen";
            this.bttUploadImage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(425, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 195);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 344);
            this.Controls.Add(this.grpPersonalData);
            this.Name = "frmAddEmployee";
            this.Text = "Agregar Empleado";
            this.grpPersonalData.ResumeLayout(false);
            this.grpPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonalData;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttUploadImage;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.TextBox textBox4;
    }
}