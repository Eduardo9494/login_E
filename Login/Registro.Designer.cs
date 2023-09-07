namespace Login
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            panel1 = new Panel();
            Cerrar2 = new Button();
            user2 = new TextBox();
            pass2 = new TextBox();
            guardar = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(Cerrar2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 36);
            panel1.TabIndex = 0;
            // 
            // Cerrar2
            // 
            Cerrar2.FlatStyle = FlatStyle.Flat;
            Cerrar2.Image = (Image)resources.GetObject("Cerrar2.Image");
            Cerrar2.Location = new Point(354, 3);
            Cerrar2.Name = "Cerrar2";
            Cerrar2.Size = new Size(29, 27);
            Cerrar2.TabIndex = 1;
            Cerrar2.UseVisualStyleBackColor = true;
            // 
            // user2
            // 
            user2.BorderStyle = BorderStyle.None;
            user2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            user2.Location = new Point(138, 101);
            user2.Name = "user2";
            user2.Size = new Size(211, 18);
            user2.TabIndex = 3;
            user2.TextAlign = HorizontalAlignment.Center;
            // 
            // pass2
            // 
            pass2.BorderStyle = BorderStyle.None;
            pass2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pass2.Location = new Point(138, 176);
            pass2.Name = "pass2";
            pass2.Size = new Size(211, 18);
            pass2.TabIndex = 4;
            pass2.TextAlign = HorizontalAlignment.Center;
            // 
            // guardar
            // 
            guardar.BackColor = Color.DodgerBlue;
            guardar.FlatAppearance.BorderColor = Color.White;
            guardar.FlatAppearance.BorderSize = 0;
            guardar.FlatAppearance.MouseDownBackColor = Color.White;
            guardar.FlatAppearance.MouseOverBackColor = Color.White;
            guardar.FlatStyle = FlatStyle.Flat;
            guardar.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            guardar.Location = new Point(138, 250);
            guardar.Name = "guardar";
            guardar.Size = new Size(94, 43);
            guardar.TabIndex = 6;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 98);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 173);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 344);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guardar);
            Controls.Add(pass2);
            Controls.Add(user2);
            Controls.Add(panel1);
            Name = "Registro";
            Text = "Registro";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Cerrar2;
        private TextBox user2;
        private TextBox pass2;
        private Button guardar;
        private Label label1;
        private Label label2;
    }
}