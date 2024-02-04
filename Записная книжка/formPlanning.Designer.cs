
namespace Записная_книжка
{
    partial class formPlanning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPlanning));
            this.inputInfo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.textInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputInfo
            // 
            this.inputInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputInfo.Location = new System.Drawing.Point(20, 64);
            this.inputInfo.Margin = new System.Windows.Forms.Padding(2);
            this.inputInfo.Multiline = true;
            this.inputInfo.Name = "inputInfo";
            this.inputInfo.Size = new System.Drawing.Size(756, 33);
            this.inputInfo.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(20, 101);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(757, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClean
            // 
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClean.Location = new System.Drawing.Point(20, 145);
            this.btnClean.Margin = new System.Windows.Forms.Padding(2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(756, 40);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Отчистить ";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // textInfo
            // 
            this.textInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textInfo.Location = new System.Drawing.Point(20, 189);
            this.textInfo.Margin = new System.Windows.Forms.Padding(2);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(757, 253);
            this.textInfo.TabIndex = 3;
            this.textInfo.TabStop = false;
            this.textInfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Информация";
            // 
            // formPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formPlanning";
            this.Text = "formPlanning";
            this.Load += new System.EventHandler(this.formPlanning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.RichTextBox textInfo;
        private System.Windows.Forms.Label label1;
    }
}