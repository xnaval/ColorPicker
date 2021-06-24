
namespace ColorPicker
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
            this.lbColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrans = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbColor
            // 
            this.lbColor.BackColor = System.Drawing.Color.Red;
            this.lbColor.Location = new System.Drawing.Point(12, 9);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(80, 56);
            this.lbColor.TabIndex = 1;
            this.lbColor.Click += new System.EventHandler(this.lbColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click on the color to open the color picker dialog";
            // 
            // cbTrans
            // 
            this.cbTrans.AutoSize = true;
            this.cbTrans.Checked = true;
            this.cbTrans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrans.Location = new System.Drawing.Point(98, 12);
            this.cbTrans.Name = "cbTrans";
            this.cbTrans.Size = new System.Drawing.Size(109, 17);
            this.cbTrans.TabIndex = 3;
            this.cbTrans.Text = "Use transparency";
            this.cbTrans.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 108);
            this.Controls.Add(this.cbTrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTrans;
    }
}

