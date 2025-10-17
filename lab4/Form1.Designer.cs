namespace lab4
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
            button1 = new Button();
            outputTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(169, 30);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(299, 70);
            button1.TabIndex = 0;
            button1.Text = "Запустити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Dock = DockStyle.Bottom;
            outputTextBox.Location = new Point(0, 124);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(654, 371);
            outputTextBox.TabIndex = 1;
            outputTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 495);
            Controls.Add(outputTextBox);
            Controls.Add(button1);
            Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox outputTextBox;
    }
}
