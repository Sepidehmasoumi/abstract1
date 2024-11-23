
namespace _6._1
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
            this.comboboxvehicle = new System.Windows.Forms.ComboBox();
            this.buttonshowmove = new System.Windows.Forms.Button();
            this.labelresult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboboxvehicle
            // 
            this.comboboxvehicle.FormattingEnabled = true;
            this.comboboxvehicle.Location = new System.Drawing.Point(43, 71);
            this.comboboxvehicle.Name = "comboboxvehicle";
            this.comboboxvehicle.Size = new System.Drawing.Size(188, 28);
            this.comboboxvehicle.TabIndex = 0;
            // 
            // buttonshowmove
            // 
            this.buttonshowmove.Location = new System.Drawing.Point(72, 118);
            this.buttonshowmove.Name = "buttonshowmove";
            this.buttonshowmove.Size = new System.Drawing.Size(128, 29);
            this.buttonshowmove.TabIndex = 1;
            this.buttonshowmove.Text = "نمایش حرکت";
            this.buttonshowmove.UseVisualStyleBackColor = true;
            this.buttonshowmove.Click += new System.EventHandler(this.buttonshowmove_Click);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Location = new System.Drawing.Point(43, 171);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(0, 20);
            this.labelresult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "لطفا نوع وسیله نقلیه را انتخاب کنید";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.buttonshowmove);
            this.Controls.Add(this.comboboxvehicle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxvehicle;
        private System.Windows.Forms.Button buttonshowmove;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Label label1;
    }
}

