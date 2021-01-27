
namespace Ej_UnitTest_EricPastor
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_opcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_num1 = new System.Windows.Forms.TextBox();
            this.TB_num2 = new System.Windows.Forms.TextBox();
            this.TB_num3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que operación quieres realizar? Pon un número del 1 al 8";
            // 
            // TB_opcion
            // 
            this.TB_opcion.Location = new System.Drawing.Point(42, 72);
            this.TB_opcion.Name = "TB_opcion";
            this.TB_opcion.Size = new System.Drawing.Size(100, 22);
            this.TB_opcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introduce el/los números para realizar la operación";
            // 
            // TB_num1
            // 
            this.TB_num1.Location = new System.Drawing.Point(45, 147);
            this.TB_num1.Name = "TB_num1";
            this.TB_num1.Size = new System.Drawing.Size(100, 22);
            this.TB_num1.TabIndex = 3;
            // 
            // TB_num2
            // 
            this.TB_num2.Location = new System.Drawing.Point(176, 147);
            this.TB_num2.Name = "TB_num2";
            this.TB_num2.Size = new System.Drawing.Size(100, 22);
            this.TB_num2.TabIndex = 4;
            // 
            // TB_num3
            // 
            this.TB_num3.Location = new System.Drawing.Point(311, 147);
            this.TB_num3.Name = "TB_num3";
            this.TB_num3.Size = new System.Drawing.Size(100, 22);
            this.TB_num3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_num3);
            this.Controls.Add(this.TB_num2);
            this.Controls.Add(this.TB_num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_opcion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Unit Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_opcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_num1;
        private System.Windows.Forms.TextBox TB_num2;
        private System.Windows.Forms.TextBox TB_num3;
        private System.Windows.Forms.Button button1;
    }
}

