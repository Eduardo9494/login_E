namespace Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Cerrar = new Button();
            pictureBox1 = new PictureBox();
            user = new TextBox();
            pass = new TextBox();
            muestra = new CheckBox();
            entrar = new Button();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(Cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 42);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Cerrar
            // 
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Image = (Image)resources.GetObject("Cerrar.Image");
            Cerrar.Location = new Point(416, 3);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(29, 27);
            Cerrar.TabIndex = 0;
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 230);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // user
            // 
            user.BorderStyle = BorderStyle.None;
            user.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            user.Location = new Point(124, 320);
            user.Name = "user";
            user.Size = new Size(211, 18);
            user.TabIndex = 2;
            user.Text = "Ingrese Usuario";
            user.TextAlign = HorizontalAlignment.Center;
            user.TextChanged += textBox1_TextChanged;
            // 
            // pass
            // 
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(124, 386);
            pass.Name = "pass";
            pass.Size = new Size(211, 18);
            pass.TabIndex = 3;
            pass.Text = "Ingrese contraseña";
            pass.TextAlign = HorizontalAlignment.Center;
            // 
            // muestra
            // 
            muestra.AutoSize = true;
            muestra.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            muestra.Location = new Point(270, 426);
            muestra.Name = "muestra";
            muestra.Size = new Size(65, 17);
            muestra.TabIndex = 4;
            muestra.Text = "Mostrar";
            muestra.UseVisualStyleBackColor = true;
            // 
            // entrar
            // 
            entrar.BackColor = Color.DodgerBlue;
            entrar.FlatAppearance.BorderColor = Color.White;
            entrar.FlatAppearance.BorderSize = 0;
            entrar.FlatAppearance.MouseDownBackColor = Color.White;
            entrar.FlatAppearance.MouseOverBackColor = Color.White;
            entrar.FlatStyle = FlatStyle.Flat;
            entrar.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            entrar.Location = new Point(175, 468);
            entrar.Name = "entrar";
            entrar.Size = new Size(94, 43);
            entrar.TabIndex = 5;
            entrar.Text = "Entrar";
            entrar.UseVisualStyleBackColor = false;
            entrar.Click += entrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 530);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 6;
            label1.Text = "¿No estas resgistrado?";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(175, 596);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
            button1.TabIndex = 7;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(457, 652);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(entrar);
            Controls.Add(muestra);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Cerrar;
        private PictureBox pictureBox1;
        private TextBox user;
        private TextBox pass;
        private CheckBox muestra;
        private Button entrar;
        private Label label1;
        private Button button1;
    }
}