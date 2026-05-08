namespace CadUsers
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
            txtrm = new TextBox();
            lblRM = new Label();
            lblCPF = new Label();
            txtcpf = new TextBox();
            lblNome = new Label();
            txtnm = new TextBox();
            macpf = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            txrsex = new ComboBox();
            SuspendLayout();
            // 
            // txtrm
            // 
            txtrm.BackColor = Color.HotPink;
            txtrm.Location = new Point(64, 58);
            txtrm.Name = "txtrm";
            txtrm.Size = new Size(150, 31);
            txtrm.TabIndex = 0;
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(76, 30);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(39, 25);
            lblRM.TabIndex = 1;
            lblRM.Text = "Rm";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(289, 30);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(42, 25);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // txtcpf
            // 
            txtcpf.BackColor = Color.CadetBlue;
            txtcpf.Location = new Point(277, 58);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(150, 31);
            txtcpf.TabIndex = 2;
            txtcpf.TextChanged += textBox2_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(507, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(64, 25);
            lblNome.TabIndex = 5;
            lblNome.Text = "NOME";
            // 
            // txtnm
            // 
            txtnm.BackColor = SystemColors.ActiveCaption;
            txtnm.Location = new Point(495, 58);
            txtnm.Name = "txtnm";
            txtnm.Size = new Size(150, 31);
            txtnm.TabIndex = 4;
            // 
            // macpf
            // 
            macpf.Location = new Point(277, 58);
            macpf.Mask = "###.###.###-##";
            macpf.Name = "macpf";
            macpf.Size = new Size(150, 31);
            macpf.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(72, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // txrsex
            // 
            txrsex.FormattingEnabled = true;
            txrsex.Items.AddRange(new object[] { "masculino", "feminio" });
            txrsex.Location = new Point(446, 177);
            txrsex.Name = "txrsex";
            txrsex.Size = new Size(182, 33);
            txrsex.TabIndex = 8;
            txrsex.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(txrsex);
            Controls.Add(dateTimePicker1);
            Controls.Add(macpf);
            Controls.Add(lblNome);
            Controls.Add(txtnm);
            Controls.Add(lblCPF);
            Controls.Add(txtcpf);
            Controls.Add(lblRM);
            Controls.Add(txtrm);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtrm;
        private Label lblRM;
        private Label lblCPF;
        private TextBox txtcpf;
        private Label lblNome;
        private TextBox txtnm;
        private MaskedTextBox macpf;
        private DateTimePicker dateTimePicker1;
        private ComboBox txrsex;
    }
}
