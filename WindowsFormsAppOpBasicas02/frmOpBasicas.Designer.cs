
namespace WindowsFormsAppOpBasicas02
{
    partial class frmOpBasicas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dividirradioButton = new System.Windows.Forms.RadioButton();
            this.multiplicarRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.restarRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sumarRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // numero1TextBox
            // 
            this.numero1TextBox.Location = new System.Drawing.Point(107, 6);
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero1TextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número 2:";
            // 
            // numero2TextBox
            // 
            this.numero2TextBox.Location = new System.Drawing.Point(107, 43);
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero2TextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.dividirradioButton);
            this.groupBox1.Controls.Add(this.multiplicarRadioButton);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.restarRadioButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.sumarRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Operaciones Básicas ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsAppOpBasicas02.Properties.Resources.divide2_20px;
            this.pictureBox4.Location = new System.Drawing.Point(17, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsAppOpBasicas02.Properties.Resources.asterisk_20px;
            this.pictureBox3.Location = new System.Drawing.Point(17, 84);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // dividirradioButton
            // 
            this.dividirradioButton.AutoSize = true;
            this.dividirradioButton.Location = new System.Drawing.Point(52, 118);
            this.dividirradioButton.Name = "dividirradioButton";
            this.dividirradioButton.Size = new System.Drawing.Size(54, 17);
            this.dividirradioButton.TabIndex = 3;
            this.dividirradioButton.Text = "Dividir";
            this.dividirradioButton.UseVisualStyleBackColor = true;
            // 
            // multiplicarRadioButton
            // 
            this.multiplicarRadioButton.AutoSize = true;
            this.multiplicarRadioButton.Location = new System.Drawing.Point(52, 89);
            this.multiplicarRadioButton.Name = "multiplicarRadioButton";
            this.multiplicarRadioButton.Size = new System.Drawing.Size(72, 17);
            this.multiplicarRadioButton.TabIndex = 2;
            this.multiplicarRadioButton.Text = "Multiplicar";
            this.multiplicarRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsAppOpBasicas02.Properties.Resources.minus_2_math_20px;
            this.pictureBox2.Location = new System.Drawing.Point(17, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // restarRadioButton
            // 
            this.restarRadioButton.AutoSize = true;
            this.restarRadioButton.Location = new System.Drawing.Point(52, 57);
            this.restarRadioButton.Name = "restarRadioButton";
            this.restarRadioButton.Size = new System.Drawing.Size(56, 17);
            this.restarRadioButton.TabIndex = 1;
            this.restarRadioButton.Text = "Restar";
            this.restarRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppOpBasicas02.Properties.Resources.plus_math_20px;
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sumarRadioButton
            // 
            this.sumarRadioButton.AutoSize = true;
            this.sumarRadioButton.Checked = true;
            this.sumarRadioButton.Location = new System.Drawing.Point(52, 25);
            this.sumarRadioButton.Name = "sumarRadioButton";
            this.sumarRadioButton.Size = new System.Drawing.Size(55, 17);
            this.sumarRadioButton.TabIndex = 0;
            this.sumarRadioButton.TabStop = true;
            this.sumarRadioButton.Text = "Sumar";
            this.sumarRadioButton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Image = global::WindowsFormsAppOpBasicas02.Properties.Resources.cancel_36px;
            this.cancelarButton.Location = new System.Drawing.Point(188, 243);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 58);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::WindowsFormsAppOpBasicas02.Properties.Resources.ok_36px;
            this.OkButton.Location = new System.Drawing.Point(26, 243);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 58);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmOpBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero1TextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpBasicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Básicas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero2TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton sumarRadioButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton restarRadioButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton multiplicarRadioButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton dividirradioButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

