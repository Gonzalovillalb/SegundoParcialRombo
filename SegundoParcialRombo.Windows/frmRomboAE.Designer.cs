namespace SegundoParcialRombo.Windows
{
    partial class frmRomboAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtDiagonalMayor = new TextBox();
            label2 = new Label();
            txtDiagonalMenor = new TextBox();
            groupBox1 = new GroupBox();
            rbtDoble = new RadioButton();
            rbtRayado = new RadioButton();
            rbtPunteado = new RadioButton();
            rbtSolido = new RadioButton();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 75);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Diagonal Mayor:";
            // 
            // txtDiagonalMayor
            // 
            txtDiagonalMayor.Location = new Point(226, 70);
            txtDiagonalMayor.Margin = new Padding(4, 5, 4, 5);
            txtDiagonalMayor.Name = "txtDiagonalMayor";
            txtDiagonalMayor.Size = new Size(141, 31);
            txtDiagonalMayor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 0;
            label2.Text = "Diagonal Menor:";
            // 
            // txtDiagonalMenor
            // 
            txtDiagonalMenor.Location = new Point(226, 118);
            txtDiagonalMenor.Margin = new Padding(4, 5, 4, 5);
            txtDiagonalMenor.Name = "txtDiagonalMenor";
            txtDiagonalMenor.Size = new Size(141, 31);
            txtDiagonalMenor.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtDoble);
            groupBox1.Controls.Add(rbtRayado);
            groupBox1.Controls.Add(rbtPunteado);
            groupBox1.Controls.Add(rbtSolido);
            groupBox1.Location = new Point(86, 182);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(286, 233);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = " Seleccione Contorno ";
            // 
            // rbtDoble
            // 
            rbtDoble.AutoSize = true;
            rbtDoble.Location = new Point(16, 162);
            rbtDoble.Margin = new Padding(4, 5, 4, 5);
            rbtDoble.Name = "rbtDoble";
            rbtDoble.Size = new Size(85, 29);
            rbtDoble.TabIndex = 0;
            rbtDoble.Text = "Doble";
            rbtDoble.UseVisualStyleBackColor = true;
            // 
            // rbtRayado
            // 
            rbtRayado.AutoSize = true;
            rbtRayado.Location = new Point(16, 120);
            rbtRayado.Margin = new Padding(4, 5, 4, 5);
            rbtRayado.Name = "rbtRayado";
            rbtRayado.Size = new Size(97, 29);
            rbtRayado.TabIndex = 0;
            rbtRayado.Text = "Rayado";
            rbtRayado.UseVisualStyleBackColor = true;
            // 
            // rbtPunteado
            // 
            rbtPunteado.AutoSize = true;
            rbtPunteado.Location = new Point(16, 78);
            rbtPunteado.Margin = new Padding(4, 5, 4, 5);
            rbtPunteado.Name = "rbtPunteado";
            rbtPunteado.Size = new Size(113, 29);
            rbtPunteado.TabIndex = 0;
            rbtPunteado.Text = "Punteado";
            rbtPunteado.UseVisualStyleBackColor = true;
            // 
            // rbtSolido
            // 
            rbtSolido.AutoSize = true;
            rbtSolido.Checked = true;
            rbtSolido.Location = new Point(16, 37);
            rbtSolido.Margin = new Padding(4, 5, 4, 5);
            rbtSolido.Name = "rbtSolido";
            rbtSolido.Size = new Size(88, 29);
            rbtSolido.TabIndex = 0;
            rbtSolido.TabStop = true;
            rbtSolido.Text = "Sólido";
            rbtSolido.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(86, 505);
            btnOK.Margin = new Padding(4, 5, 4, 5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(107, 90);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(261, 505);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 90);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRomboAE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 637);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(groupBox1);
            Controls.Add(txtDiagonalMenor);
            Controls.Add(label2);
            Controls.Add(txtDiagonalMayor);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(473, 693);
            MinimumSize = new Size(473, 693);
            Name = "frmRomboAE";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmRomboAE_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDiagonalMayor;
        private Label label2;
        private TextBox txtDiagonalMenor;
        private GroupBox groupBox1;
        private RadioButton rbtSolido;
        private RadioButton rbtDoble;
        private RadioButton rbtRayado;
        private RadioButton rbtPunteado;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}