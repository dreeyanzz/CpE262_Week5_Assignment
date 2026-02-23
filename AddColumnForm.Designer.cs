namespace week_5_assignment
{
    partial class AddColumnForm
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
            colNameInputLbl = new Label();
            colNameInput = new TextBox();
            addColBtn = new Button();
            SuspendLayout();
            //
            // colNameInputLbl
            //
            colNameInputLbl.AutoSize = true;
            colNameInputLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            colNameInputLbl.ForeColor = Color.FromArgb(120, 0, 30);
            colNameInputLbl.Location = new Point(30, 30);
            colNameInputLbl.Name = "colNameInputLbl";
            colNameInputLbl.TabIndex = 0;
            colNameInputLbl.Text = "Column name:";
            //
            // colNameInput
            //
            colNameInput.BorderStyle = BorderStyle.FixedSingle;
            colNameInput.Font = new Font("Segoe UI", 12F);
            colNameInput.Location = new Point(30, 62);
            colNameInput.Name = "colNameInput";
            colNameInput.Size = new Size(420, 34);
            colNameInput.TabIndex = 1;
            //
            // addColBtn  (primary — filled maroon)
            //
            addColBtn.BackColor = Color.FromArgb(120, 0, 30);
            addColBtn.FlatStyle = FlatStyle.Flat;
            addColBtn.FlatAppearance.BorderColor = Color.FromArgb(80, 0, 20);
            addColBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addColBtn.ForeColor = Color.White;
            addColBtn.Location = new Point(130, 116);
            addColBtn.Name = "addColBtn";
            addColBtn.Size = new Size(220, 45);
            addColBtn.TabIndex = 2;
            addColBtn.Text = "Add Column";
            addColBtn.UseVisualStyleBackColor = false;
            addColBtn.Click += AddColBtn_Click;
            //
            // AddColumnForm
            //
            AcceptButton = addColBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(480, 185);
            Controls.Add(colNameInputLbl);
            Controls.Add(colNameInput);
            Controls.Add(addColBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddColumnForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Column";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label colNameInputLbl;
        private TextBox colNameInput;
        private Button addColBtn;
    }
}
