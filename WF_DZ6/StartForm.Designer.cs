namespace WF_DZ6
{
    partial class StartForm
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
            label1 = new Label();
            label2 = new Label();
            closeButton = new Button();
            nextButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 32);
            label1.Name = "label1";
            label1.Size = new Size(304, 80);
            label1.TabIndex = 0;
            label1.Text = "Приветствуем в мастере установки умного дома";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(48, 144);
            label2.Name = "label2";
            label2.Size = new Size(320, 112);
            label2.TabIndex = 1;
            label2.Text = "Данный установщик поможет быстро и удобно установить и настроить модули и сам умный дом";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(208, 304);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(304, 304);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 3;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 341);
            Controls.Add(nextButton);
            Controls.Add(closeButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StartForm";
            Text = "Мастер установки";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button closeButton;
        private Button nextButton;
    }
}
