namespace LOGINC7_JEAN
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnsalir = new Button();
            btnlimpiar = new Button();
            btningresar = new Button();
            txtcontraseña = new TextBox();
            txtusuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(251, 27);
            label1.Name = "label1";
            label1.Size = new Size(230, 32);
            label1.TabIndex = 0;
            label1.Text = "INICIAR SESION  ";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnsalir);
            groupBox1.Controls.Add(btnlimpiar);
            groupBox1.Controls.Add(btningresar);
            groupBox1.Controls.Add(txtcontraseña);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(48, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(528, 244);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese sus datos correspondientes";
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(398, 179);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(76, 35);
            btnsalir.TabIndex = 2;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(398, 119);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(76, 24);
            btnlimpiar.TabIndex = 2;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btningresar
            // 
            btningresar.Location = new Point(398, 59);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(76, 24);
            btningresar.TabIndex = 2;
            btningresar.Text = "ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click_1;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(203, 119);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.Size = new Size(157, 24);
            txtcontraseña.TabIndex = 1;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(203, 59);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(157, 24);
            txtusuario.TabIndex = 1;
            txtusuario.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 119);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 0;
            label3.Text = "CONTRASEÑA:";
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 59);
            label2.Name = "label2";
            label2.Size = new Size(191, 24);
            label2.TabIndex = 0;
            label2.Text = "INGRESE USUARIO:";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private TextBox txtcontraseña;
        private TextBox txtusuario;
        private Button btningresar;
        private Button btnlimpiar;
        private Button btnsalir;
    }
}