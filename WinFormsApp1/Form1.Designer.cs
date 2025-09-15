namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtmon = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtconver = new TextBox();
            btnlimpiar = new Button();
            btnsalir = new Button();
            lblmsg = new Label();
            cboconvertir = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 0;
            label1.Text = "INGRESE CANTIDAD (DOP):";
            label1.Click += label1_Click;
            // 
            // txtmon
            // 
            txtmon.Location = new Point(183, 33);
            txtmon.Name = "txtmon";
            txtmon.Size = new Size(132, 23);
            txtmon.TabIndex = 1;
            txtmon.TextChanged += textBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 4;
            label3.Text = "MONEDA A CONVERTIR: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 140);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "MONTO:";
            label4.Click += label4_Click;
            // 
            // txtconver
            // 
            txtconver.Location = new Point(163, 132);
            txtconver.Name = "txtconver";
            txtconver.Size = new Size(132, 23);
            txtconver.TabIndex = 8;
            txtconver.TextChanged += txtconver_TextChanged;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = SystemColors.ActiveCaption;
            btnlimpiar.Location = new Point(108, 204);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 9;
            btnlimpiar.Text = "LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = SystemColors.ActiveCaption;
            btnsalir.Location = new Point(316, 203);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 10;
            btnsalir.Text = "SALIR";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // lblmsg
            // 
            lblmsg.AutoSize = true;
            lblmsg.Location = new Point(338, 140);
            lblmsg.Name = "lblmsg";
            lblmsg.Size = new Size(38, 15);
            lblmsg.TabIndex = 11;
            lblmsg.Text = "label5";
            // 
            // cboconvertir
            // 
            cboconvertir.FormattingEnabled = true;
            cboconvertir.Items.AddRange(new object[] { "DOLAR", "EURO", "PESO MEXICANO" });
            cboconvertir.Location = new Point(183, 80);
            cboconvertir.Name = "cboconvertir";
            cboconvertir.Size = new Size(121, 23);
            cboconvertir.TabIndex = 6;
            cboconvertir.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cboconvertir.Click += cboconvertir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 318);
            Controls.Add(lblmsg);
            Controls.Add(btnsalir);
            Controls.Add(btnlimpiar);
            Controls.Add(txtconver);
            Controls.Add(label4);
            Controls.Add(cboconvertir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtmon);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CONVERITDOR ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtmon;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtconver;
        private Button btnlimpiar;
        private Button btnsalir;
        private Label lblmsg;
        private ComboBox cboconvertir;
    }
}
