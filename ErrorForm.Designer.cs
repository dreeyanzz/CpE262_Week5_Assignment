namespace week_5_assignment
{
    partial class ErrorForm
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
            errorIcon = new PictureBox();
            errLbl = new Label();
            okBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            //
            // errorIcon
            //
            errorIcon.Image = SystemIcons.Error.ToBitmap();
            errorIcon.Location = new Point(20, 25);
            errorIcon.Name = "errorIcon";
            errorIcon.Size = new Size(32, 32);
            errorIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            errorIcon.TabIndex = 0;
            errorIcon.TabStop = false;
            //
            // errLbl
            //
            errLbl.Location = new Point(65, 20);
            errLbl.Name = "errLbl";
            errLbl.Size = new Size(300, 60);
            errLbl.TabIndex = 1;
            errLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            errLbl.TextAlign = ContentAlignment.MiddleLeft;
            //
            // okBtn
            //
            okBtn.BackColor = Color.FromArgb(240, 240, 240);
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(290, 90);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(80, 30);
            okBtn.TabIndex = 2;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = false;
            //
            // ErrorForm
            //
            AcceptButton = okBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 140);
            Controls.Add(errorIcon);
            Controls.Add(errLbl);
            Controls.Add(okBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ErrorForm";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Application Error";
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox errorIcon;
        private Label errLbl;
        private Button okBtn;
    }
}
