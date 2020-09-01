namespace ViewJsLN
{
    partial class ConfigSet
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtShortcutViews = new System.Windows.Forms.TextBox();
            this.txtShortcutScripts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtViewsSuffix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScriptsRegex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "快捷跳转View";
            // 
            // txtShortcutViews
            // 
            this.txtShortcutViews.Location = new System.Drawing.Point(138, 12);
            this.txtShortcutViews.Name = "txtShortcutViews";
            this.txtShortcutViews.Size = new System.Drawing.Size(100, 21);
            this.txtShortcutViews.TabIndex = 1;
            // 
            // txtShortcutScripts
            // 
            this.txtShortcutScripts.Location = new System.Drawing.Point(387, 12);
            this.txtShortcutScripts.Name = "txtShortcutScripts";
            this.txtShortcutScripts.Size = new System.Drawing.Size(100, 21);
            this.txtShortcutScripts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "快捷跳转Scripts";
            // 
            // txtViewsSuffix
            // 
            this.txtViewsSuffix.Location = new System.Drawing.Point(138, 88);
            this.txtViewsSuffix.Name = "txtViewsSuffix";
            this.txtViewsSuffix.Size = new System.Drawing.Size(100, 21);
            this.txtViewsSuffix.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "View后缀";
            // 
            // txtScriptsRegex
            // 
            this.txtScriptsRegex.Location = new System.Drawing.Point(387, 83);
            this.txtScriptsRegex.Name = "txtScriptsRegex";
            this.txtScriptsRegex.Size = new System.Drawing.Size(100, 21);
            this.txtScriptsRegex.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scripts正则";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(162, 367);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "恢复默认";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(302, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ConfigSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtScriptsRegex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtViewsSuffix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShortcutScripts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShortcutViews);
            this.Controls.Add(this.label1);
            this.Name = "ConfigSet";
            this.Text = "ViewJs配置";
            this.Load += new System.EventHandler(this.ConfigSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShortcutViews;
        private System.Windows.Forms.TextBox txtShortcutScripts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtViewsSuffix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScriptsRegex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
    }
}