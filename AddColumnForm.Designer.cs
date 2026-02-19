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
            addColBtn = new Button();
            colNameInput = new TextBox();
            colNameInputLbl = new Label();
            SuspendLayout();
            // 
            // addColBtn
            // 
            addColBtn.Location = new Point(251, 92);
            addColBtn.Name = "addColBtn";
            addColBtn.Size = new Size(160, 56);
            addColBtn.TabIndex = 0;
            addColBtn.Text = "Add Column";
            addColBtn.UseVisualStyleBackColor = true;
            addColBtn.Click += AddColBtn_Click;
            // 
            // colNameInput
            // 
            colNameInput.Location = new Point(149, 31);
            colNameInput.Name = "colNameInput";
            colNameInput.Size = new Size(445, 27);
            colNameInput.TabIndex = 1;
            // 
            // colNameInputLbl
            // 
            colNameInputLbl.AutoSize = true;
            colNameInputLbl.Location = new Point(39, 34);
            colNameInputLbl.Name = "colNameInputLbl";
            colNameInputLbl.Size = new Size(104, 20);
            colNameInputLbl.TabIndex = 2;
            colNameInputLbl.Text = "Column name:";
            // 
            // AddColumnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 172);
            Controls.Add(colNameInputLbl);
            Controls.Add(colNameInput);
            Controls.Add(addColBtn);
            Name = "AddColumnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add column";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button addColBtn;
        private TextBox colNameInput;
        private Label colNameInputLbl;
    }
}