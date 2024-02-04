namespace Записная_книжка
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.label1 = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonContacts = new System.Windows.Forms.Button();
            this.buttonPlanning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1058, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.Location = new System.Drawing.Point(125, 28);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(551, 73);
            this.labelMain.TabIndex = 1;
            this.labelMain.Text = "Выберите форму";
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalendar.Location = new System.Drawing.Point(31, 144);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(200, 125);
            this.buttonCalendar.TabIndex = 2;
            this.buttonCalendar.Text = "Календарь";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonContacts
            // 
            this.buttonContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContacts.Location = new System.Drawing.Point(308, 144);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new System.Drawing.Size(200, 125);
            this.buttonContacts.TabIndex = 3;
            this.buttonContacts.Text = "Контактная информация";
            this.buttonContacts.UseVisualStyleBackColor = true;
            this.buttonContacts.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPlanning
            // 
            this.buttonPlanning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlanning.Location = new System.Drawing.Point(572, 144);
            this.buttonPlanning.Name = "buttonPlanning";
            this.buttonPlanning.Size = new System.Drawing.Size(200, 125);
            this.buttonPlanning.TabIndex = 4;
            this.buttonPlanning.Text = "Планерки";
            this.buttonPlanning.UseVisualStyleBackColor = true;
            this.buttonPlanning.Click += new System.EventHandler(this.buttonPlanning_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 432);
            this.Controls.Add(this.buttonPlanning);
            this.Controls.Add(this.buttonContacts);
            this.Controls.Add(this.buttonCalendar);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "formMain";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonContacts;
        private System.Windows.Forms.Button buttonPlanning;
    }
}

