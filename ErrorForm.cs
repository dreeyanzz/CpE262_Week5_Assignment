using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace week_5_assignment
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string error)
        {
            InitializeComponent();

            // 1. Form Window Guards
            this.Text = "Application Error";
            this.Size = new Size(400, 180);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Guard: Prevents resizing
            this.StartPosition = FormStartPosition.CenterParent; // Guard: Centers over main window
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Padding = new Padding(20);
            this.BackColor = Color.White;

            // 2. Error Icon (Standard System Icon)
            PictureBox errorIcon = new PictureBox
            {
                Image = SystemIcons.Error.ToBitmap(),
                Location = new Point(20, 25),
                Size = new Size(32, 32),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // 3. Message Label
            Label errLbl = new Label
            {
                Text = error,
                Location = new Point(65, 20),
                Size = new Size(300, 60),
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // 4. OK Button
            Button okBtn = new Button
            {
                Text = "OK",
                DialogResult = DialogResult.OK, // Guard: Automatically closes form when clicked
                Size = new Size(80, 30),
                Location = new Point(290, 90),
                BackColor = Color.FromArgb(240, 240, 240)
            };

            // Assembly
            this.Controls.Add(errorIcon);
            this.Controls.Add(errLbl);
            this.Controls.Add(okBtn);

            // Final Guard: Enter key triggers the OK button
            this.AcceptButton = okBtn;
        }
    }
}
