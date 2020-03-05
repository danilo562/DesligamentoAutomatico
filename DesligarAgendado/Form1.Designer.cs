namespace DesligarAgendado
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtHora = new System.Windows.Forms.DateTimePicker();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtRelogio = new System.Windows.Forms.TextBox();
            this.txtDaAgen = new System.Windows.Forms.TextBox();
            this.txtHoraAgen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(95, 162);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(164, 22);
            this.txtData.TabIndex = 0;
            this.txtData.ValueChanged += new System.EventHandler(this.txtData_ValueChanged);
            // 
            // txtHora
            // 
            this.txtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHora.Location = new System.Drawing.Point(296, 162);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(120, 22);
            this.txtHora.TabIndex = 1;
            this.txtHora.ValueChanged += new System.EventHandler(this.txtHora_ValueChanged);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(453, 268);
            this.btnAgendar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(181, 111);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "AGENDAR";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtRelogio
            // 
            this.txtRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRelogio.Location = new System.Drawing.Point(81, 288);
            this.txtRelogio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRelogio.Multiline = true;
            this.txtRelogio.Name = "txtRelogio";
            this.txtRelogio.Size = new System.Drawing.Size(364, 91);
            this.txtRelogio.TabIndex = 3;
            this.txtRelogio.TextChanged += new System.EventHandler(this.txtRelogio_TextChanged);
            // 
            // txtDaAgen
            // 
            this.txtDaAgen.Location = new System.Drawing.Point(95, 245);
            this.txtDaAgen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDaAgen.Name = "txtDaAgen";
            this.txtDaAgen.ReadOnly = true;
            this.txtDaAgen.Size = new System.Drawing.Size(132, 22);
            this.txtDaAgen.TabIndex = 4;
            this.txtDaAgen.TextChanged += new System.EventHandler(this.txtDaAgen_TextChanged);
            // 
            // txtHoraAgen
            // 
            this.txtHoraAgen.Location = new System.Drawing.Point(244, 245);
            this.txtHoraAgen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoraAgen.Name = "txtHoraAgen";
            this.txtHoraAgen.ReadOnly = true;
            this.txtHoraAgen.Size = new System.Drawing.Size(132, 22);
            this.txtHoraAgen.TabIndex = 5;
            this.txtHoraAgen.TextChanged += new System.EventHandler(this.txtHoraAgen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Agendado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Informe a Data e Horario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesligarAgendado.Properties.Resources.logo_dw_2_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoraAgen);
            this.Controls.Add(this.txtDaAgen);
            this.Controls.Add(this.txtRelogio);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtData);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Agendamento Para Desligar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.DateTimePicker txtHora;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtRelogio;
        private System.Windows.Forms.TextBox txtDaAgen;
        private System.Windows.Forms.TextBox txtHoraAgen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

