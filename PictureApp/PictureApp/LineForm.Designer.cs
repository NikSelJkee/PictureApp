namespace PictureApp
{
    partial class LineForm
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
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.labelCoor = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialogLine = new System.Windows.Forms.ColorDialog();
            this.labelWidthLine = new System.Windows.Forms.Label();
            this.textBoxWidthLine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(15, 51);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(62, 20);
            this.textBoxX1.TabIndex = 0;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(99, 51);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(62, 20);
            this.textBoxY1.TabIndex = 1;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(15, 89);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(62, 20);
            this.textBoxX2.TabIndex = 2;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(99, 89);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(62, 20);
            this.textBoxY2.TabIndex = 3;
            // 
            // labelCoor
            // 
            this.labelCoor.AutoSize = true;
            this.labelCoor.Location = new System.Drawing.Point(12, 9);
            this.labelCoor.Name = "labelCoor";
            this.labelCoor.Size = new System.Drawing.Size(119, 13);
            this.labelCoor.TabIndex = 4;
            this.labelCoor.Text = "Укажите координаты:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(33, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(23, 13);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "X 1";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(120, 35);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(23, 13);
            this.labelY1.TabIndex = 6;
            this.labelY1.Text = "Y 1";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(120, 74);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(23, 13);
            this.labelY2.TabIndex = 7;
            this.labelY2.Text = "Y 2";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(33, 74);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(23, 13);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "X 2";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 221);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(93, 221);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(15, 184);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(146, 23);
            this.buttonColor.TabIndex = 13;
            this.buttonColor.Text = "Выбрать цвет";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // labelWidthLine
            // 
            this.labelWidthLine.AutoSize = true;
            this.labelWidthLine.Location = new System.Drawing.Point(21, 131);
            this.labelWidthLine.Name = "labelWidthLine";
            this.labelWidthLine.Size = new System.Drawing.Size(134, 13);
            this.labelWidthLine.TabIndex = 14;
            this.labelWidthLine.Text = "Укажите толщину линии:";
            // 
            // textBoxWidthLine
            // 
            this.textBoxWidthLine.Location = new System.Drawing.Point(15, 151);
            this.textBoxWidthLine.Name = "textBoxWidthLine";
            this.textBoxWidthLine.Size = new System.Drawing.Size(146, 20);
            this.textBoxWidthLine.TabIndex = 15;
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 253);
            this.Controls.Add(this.textBoxWidthLine);
            this.Controls.Add(this.labelWidthLine);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelCoor);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.MaximumSize = new System.Drawing.Size(200, 292);
            this.MinimumSize = new System.Drawing.Size(200, 292);
            this.Name = "LineForm";
            this.Text = "LineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCoor;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        protected internal System.Windows.Forms.TextBox textBoxX1;
        protected internal System.Windows.Forms.TextBox textBoxY1;
        protected internal System.Windows.Forms.TextBox textBoxX2;
        protected internal System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialogLine;
        private System.Windows.Forms.Label labelWidthLine;
        protected internal System.Windows.Forms.TextBox textBoxWidthLine;
    }
}