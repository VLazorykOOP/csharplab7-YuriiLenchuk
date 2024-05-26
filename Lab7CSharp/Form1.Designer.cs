namespace AddSentenceToRichTextBox
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button suppressColorButton;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.ComboBox comboBoxShapes;
        private System.Windows.Forms.ComboBox comboBoxColors;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.TextBox textBoxStartAngle; // Додане поле для введення кута сектора
        private System.Windows.Forms.TextBox textBoxSweepAngle; // Додане поле для введення ширини сектора
        private System.ComponentModel.IContainer components;

        private System.Windows.Forms.Label labelStartAngle;
        private System.Windows.Forms.Label labelSweepAngle;

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.suppressColorButton = new System.Windows.Forms.Button();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.comboBoxShapes = new System.Windows.Forms.ComboBox();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.textBoxStartAngle = new System.Windows.Forms.TextBox();
            this.textBoxSweepAngle = new System.Windows.Forms.TextBox();
            this.labelStartAngle = new System.Windows.Forms.Label();
            this.labelSweepAngle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.radioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 20);
            this.textBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 222);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(375, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(477, 414);

            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 266);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(86, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Завантажити";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(104, 266);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // suppressColorButton
            // 
            this.suppressColorButton.Location = new System.Drawing.Point(185, 266);
            this.suppressColorButton.Name = "suppressColorButton";
            this.suppressColorButton.Size = new System.Drawing.Size(75, 23);
            this.suppressColorButton.TabIndex = 6;
            this.suppressColorButton.Text = "Пригнітити";
            this.suppressColorButton.UseVisualStyleBackColor = true;
            this.suppressColorButton.Click += new System.EventHandler(this.suppressColorButton_Click);
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(6, 19);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(75, 17);
            this.radioRed.TabIndex = 7;
            this.radioRed.TabStop = true;
            this.radioRed.Text = "Червоний";
            this.radioRed.UseVisualStyleBackColor = true;
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(6, 42);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(68, 17);
            this.radioGreen.TabIndex = 8;
            this.radioGreen.TabStop = true;
            this.radioGreen.Text = "Зелений";
            this.radioGreen.UseVisualStyleBackColor = true;
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(6, 65);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(52, 17);
            this.radioBlue.TabIndex = 9;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Синій";
            this.radioBlue.UseVisualStyleBackColor = true;
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.radioRed);
            this.radioGroup.Controls.Add(this.radioBlue);
            this.radioGroup.Controls.Add(this.radioGreen);
            this.radioGroup.Location = new System.Drawing.Point(12, 295);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Size = new System.Drawing.Size(200, 100);
            this.radioGroup.TabIndex = 16;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Виберіть колір для пригнічення";
            // 
            // comboBoxShapes
            // 
            this.comboBoxShapes.FormattingEnabled = true;
            this.comboBoxShapes.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Star",

            "Sector"});
            this.comboBoxShapes.Location = new System.Drawing.Point(12, 401);
            this.comboBoxShapes.Name = "comboBoxShapes";
            this.comboBoxShapes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShapes.TabIndex = 11;
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Black"});
            this.comboBoxColors.Location = new System.Drawing.Point(139, 401);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColors.TabIndex = 12;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(278, 399);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(82, 23);
            this.drawButton.TabIndex = 13;
            this.drawButton.Text = "Намалювати";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // textBoxStartAngle
            // 
            this.textBoxStartAngle.Location = new System.Drawing.Point(139, 452);
            this.textBoxStartAngle.Name = "textBoxStartAngle";
            this.textBoxStartAngle.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartAngle.TabIndex = 14;
            // 
            // textBoxSweepAngle
            // 
            this.textBoxSweepAngle.Location = new System.Drawing.Point(139, 478);
            this.textBoxSweepAngle.Name = "textBoxSweepAngle";
            this.textBoxSweepAngle.Size = new System.Drawing.Size(100, 20);
            this.textBoxSweepAngle.TabIndex = 15;
            // 
            // labelStartAngle
            // 
            this.labelStartAngle.AutoSize = true;
            this.labelStartAngle.Location = new System.Drawing.Point(25, 455);
            this.labelStartAngle.Name = "labelStartAngle";
            this.labelStartAngle.Size = new System.Drawing.Size(89, 13);
            this.labelStartAngle.TabIndex = 17;
            this.labelStartAngle.Text = "Початковий кут:";
            // 
            // labelSweepAngle
            // 
            this.labelSweepAngle.AutoSize = true;
            this.labelSweepAngle.Location = new System.Drawing.Point(25, 481);
            this.labelSweepAngle.Name = "labelSweepAngle";
            this.labelSweepAngle.Size = new System.Drawing.Size(74, 13);
            this.labelSweepAngle.TabIndex = 18;
            this.labelSweepAngle.Text = "Ширина кута:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 521);
            this.Controls.Add(this.labelStartAngle);
            this.Controls.Add(this.labelSweepAngle);
            this.Controls.Add(this.textBoxSweepAngle);
            this.Controls.Add(this.textBoxStartAngle);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.comboBoxColors);
            this.Controls.Add(this.comboBoxShapes);
            this.Controls.Add(this.radioGroup);
            this.Controls.Add(this.suppressColorButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Додати речення та обробити зображення";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.radioGroup.ResumeLayout(false);

            this.radioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}