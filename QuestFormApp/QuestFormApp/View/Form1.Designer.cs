namespace QuestFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.VarA = new System.Windows.Forms.Button();
            this.VarD = new System.Windows.Forms.Button();
            this.VarC = new System.Windows.Forms.Button();
            this.VarB = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quest";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(613, 199);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // VarA
            // 
            this.VarA.Location = new System.Drawing.Point(19, 253);
            this.VarA.Name = "VarA";
            this.VarA.Size = new System.Drawing.Size(99, 43);
            this.VarA.TabIndex = 2;
            this.VarA.Text = "Variant A";
            this.VarA.UseVisualStyleBackColor = true;
            this.VarA.Click += new System.EventHandler(this.VarA_Click);
            // 
            // VarD
            // 
            this.VarD.Location = new System.Drawing.Point(254, 314);
            this.VarD.Name = "VarD";
            this.VarD.Size = new System.Drawing.Size(99, 43);
            this.VarD.TabIndex = 3;
            this.VarD.Text = "Variant D";
            this.VarD.UseVisualStyleBackColor = true;
            this.VarD.Click += new System.EventHandler(this.VarD_Click);
            // 
            // VarC
            // 
            this.VarC.Location = new System.Drawing.Point(19, 314);
            this.VarC.Name = "VarC";
            this.VarC.Size = new System.Drawing.Size(99, 43);
            this.VarC.TabIndex = 4;
            this.VarC.Text = "Variant C";
            this.VarC.UseVisualStyleBackColor = true;
            this.VarC.Click += new System.EventHandler(this.VarC_Click);
            // 
            // VarB
            // 
            this.VarB.Location = new System.Drawing.Point(254, 253);
            this.VarB.Name = "VarB";
            this.VarB.Size = new System.Drawing.Size(99, 43);
            this.VarB.TabIndex = 5;
            this.VarB.Text = "Variant B";
            this.VarB.UseVisualStyleBackColor = true;
            this.VarB.Click += new System.EventHandler(this.VarB_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(533, 314);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(99, 43);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(533, 253);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(99, 43);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next >";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 369);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.VarB);
            this.Controls.Add(this.VarC);
            this.Controls.Add(this.VarD);
            this.Controls.Add(this.VarA);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button VarA;
        private System.Windows.Forms.Button VarD;
        private System.Windows.Forms.Button VarC;
        private System.Windows.Forms.Button VarB;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button NextButton;
    }
}

