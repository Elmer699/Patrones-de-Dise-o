namespace CommandForm
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
            this.objeto = new System.Windows.Forms.ComboBox();
            this.instruccion = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // objeto
            // 
            this.objeto.FormattingEnabled = true;
            this.objeto.Items.AddRange(new object[] {
            "luces",
            "portada"});
            this.objeto.Location = new System.Drawing.Point(158, 107);
            this.objeto.Name = "objeto";
            this.objeto.Size = new System.Drawing.Size(121, 21);
            this.objeto.TabIndex = 0;
            this.objeto.SelectedIndexChanged += new System.EventHandler(this.Input1_SelectedIndexChanged);
            // 
            // instruccion
            // 
            this.instruccion.FormattingEnabled = true;
            this.instruccion.Location = new System.Drawing.Point(304, 107);
            this.instruccion.Name = "instruccion";
            this.instruccion.Size = new System.Drawing.Size(121, 21);
            this.instruccion.TabIndex = 1;
            this.instruccion.SelectedIndexChanged += new System.EventHandler(this.objeto_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btn.Location = new System.Drawing.Point(280, 216);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "BOTON";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(491, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Objeto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instruccion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.instruccion);
            this.Controls.Add(this.objeto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox objeto;
        private System.Windows.Forms.ComboBox instruccion;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}