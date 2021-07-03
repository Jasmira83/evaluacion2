
namespace evaluacion2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nomestudiante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.Label();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_n4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.txt_n4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_n3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_n2);
            this.groupBox1.Controls.Add(this.txt_n);
            this.groupBox1.Controls.Add(this.txt_n1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(113, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUADRO DE NOTAS";
            // 
            // txt_nomestudiante
            // 
            this.txt_nomestudiante.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomestudiante.Location = new System.Drawing.Point(203, 44);
            this.txt_nomestudiante.Name = "txt_nomestudiante";
            this.txt_nomestudiante.Size = new System.Drawing.Size(314, 25);
            this.txt_nomestudiante.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE DEL ESTUDIANTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMERO DE CUENTA:";
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuenta.Location = new System.Drawing.Point(203, 96);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(314, 25);
            this.txt_cuenta.TabIndex = 3;
            this.txt_cuenta.TextChanged += new System.EventHandler(this.txt_cuenta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOTA 1";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(205, 42);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(135, 25);
            this.txt_n1.TabIndex = 5;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(205, 88);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(135, 25);
            this.txt_n2.TabIndex = 7;
            // 
            // txt_n
            // 
            this.txt_n.AutoSize = true;
            this.txt_n.Location = new System.Drawing.Point(102, 95);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(51, 23);
            this.txt_n.TabIndex = 6;
            this.txt_n.Text = "NOTA 2";
            // 
            // txt_n3
            // 
            this.txt_n3.Location = new System.Drawing.Point(205, 129);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(135, 25);
            this.txt_n3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOTA 3";
            // 
            // txt_n4
            // 
            this.txt_n4.Location = new System.Drawing.Point(205, 181);
            this.txt_n4.Name = "txt_n4";
            this.txt_n4.Size = new System.Drawing.Size(135, 25);
            this.txt_n4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "NOTA 4";
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackColor = System.Drawing.Color.Snow;
            this.btn_procesar.Location = new System.Drawing.Point(556, 62);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(88, 33);
            this.btn_procesar.TabIndex = 5;
            this.btn_procesar.Text = "PROCESAR";
            this.btn_procesar.UseVisualStyleBackColor = false;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomestudiante);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_n4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label txt_n;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nomestudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cuenta;
        private System.Windows.Forms.Button btn_procesar;
    }
}

