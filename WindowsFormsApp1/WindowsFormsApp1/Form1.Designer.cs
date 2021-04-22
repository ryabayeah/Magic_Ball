
namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.question1 = new System.Windows.Forms.TextBox();
            this.answer1 = new System.Windows.Forms.Button();
            this.random1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericYes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericYes);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.random1);
            this.panel1.Controls.Add(this.question1);
            this.panel1.Controls.Add(this.answer1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 325);
            this.panel1.TabIndex = 0;
            // 
            // question1
            // 
            this.question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question1.Location = new System.Drawing.Point(18, 15);
            this.question1.Margin = new System.Windows.Forms.Padding(4, 5, 6, 7);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(414, 30);
            this.question1.TabIndex = 1;
            // 
            // answer1
            // 
            this.answer1.BackColor = System.Drawing.SystemColors.Window;
            this.answer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1.Location = new System.Drawing.Point(148, 211);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(149, 59);
            this.answer1.TabIndex = 0;
            this.answer1.Text = "Answer";
            this.answer1.UseVisualStyleBackColor = false;
            this.answer1.Click += new System.EventHandler(this.button1_Click);
            // 
            // random1
            // 
            this.random1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.random1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.random1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.random1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.random1.Location = new System.Drawing.Point(106, 97);
            this.random1.Name = "random1";
            this.random1.Size = new System.Drawing.Size(236, 100);
            this.random1.TabIndex = 2;
            this.random1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(183, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Switch to: ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericYes
            // 
            this.numericYes.DecimalPlaces = 1;
            this.numericYes.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericYes.Location = new System.Drawing.Point(221, 63);
            this.numericYes.Name = "numericYes";
            this.numericYes.Size = new System.Drawing.Size(120, 20);
            this.numericYes.TabIndex = 4;
            this.numericYes.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Drop probability \"Yes\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 348);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Random";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.TextBox question1;
        private System.Windows.Forms.Label random1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericYes;
    }
}

