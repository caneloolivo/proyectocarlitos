namespace proyectocarlitos
{
    partial class altaCarrera
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFacultad = new System.Windows.Forms.TextBox();
            this.txtTotalPeriodo = new System.Windows.Forms.TextBox();
            this.RBCuatri = new System.Windows.Forms.RadioButton();
            this.RBSemestre = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbcStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Director:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Carrera:";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(12, 73);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(136, 20);
            this.txtDirector.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alta Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Facultad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total de Periodo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Periodo:";
            // 
            // txtFacultad
            // 
            this.txtFacultad.Location = new System.Drawing.Point(187, 121);
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.Size = new System.Drawing.Size(132, 20);
            this.txtFacultad.TabIndex = 8;
            // 
            // txtTotalPeriodo
            // 
            this.txtTotalPeriodo.Location = new System.Drawing.Point(12, 121);
            this.txtTotalPeriodo.Name = "txtTotalPeriodo";
            this.txtTotalPeriodo.Size = new System.Drawing.Size(136, 20);
            this.txtTotalPeriodo.TabIndex = 9;
            // 
            // RBCuatri
            // 
            this.RBCuatri.AutoSize = true;
            this.RBCuatri.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCuatri.Location = new System.Drawing.Point(187, 169);
            this.RBCuatri.Name = "RBCuatri";
            this.RBCuatri.Size = new System.Drawing.Size(107, 20);
            this.RBCuatri.TabIndex = 10;
            this.RBCuatri.TabStop = true;
            this.RBCuatri.Text = "Cuatrimestre";
            this.RBCuatri.UseVisualStyleBackColor = true;
            this.RBCuatri.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBSemestre
            // 
            this.RBSemestre.AutoSize = true;
            this.RBSemestre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSemestre.Location = new System.Drawing.Point(300, 169);
            this.RBSemestre.Name = "RBSemestre";
            this.RBSemestre.Size = new System.Drawing.Size(86, 20);
            this.RBSemestre.TabIndex = 11;
            this.RBSemestre.TabStop = true;
            this.RBSemestre.Text = "Semestre";
            this.RBSemestre.UseVisualStyleBackColor = true;
            this.RBSemestre.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Registrar Carrera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Status:";
            // 
            // cbcStatus
            // 
            this.cbcStatus.FormattingEnabled = true;
            this.cbcStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbcStatus.Location = new System.Drawing.Point(12, 172);
            this.cbcStatus.Name = "cbcStatus";
            this.cbcStatus.Size = new System.Drawing.Size(136, 21);
            this.cbcStatus.TabIndex = 16;
            // 
            // altaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 265);
            this.Controls.Add(this.cbcStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RBSemestre);
            this.Controls.Add(this.RBCuatri);
            this.Controls.Add(this.txtTotalPeriodo);
            this.Controls.Add(this.txtFacultad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "altaCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Carrera";
            this.Load += new System.EventHandler(this.altaCarrera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFacultad;
        private System.Windows.Forms.TextBox txtTotalPeriodo;
        private System.Windows.Forms.RadioButton RBCuatri;
        private System.Windows.Forms.RadioButton RBSemestre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbcStatus;
    }
}