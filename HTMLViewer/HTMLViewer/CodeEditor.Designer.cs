namespace HTMLViewer
{
    partial class CodeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditor));
            this.webControl = new Awesomium.Windows.Forms.WebControl();
            this.saveCodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webControl
            // 
            resources.ApplyResources(this.webControl, "webControl");
            this.webControl.Name = "webControl";
            // 
            // saveCodeButton
            // 
            resources.ApplyResources(this.saveCodeButton, "saveCodeButton");
            this.saveCodeButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveCodeButton.FlatAppearance.BorderSize = 0;
            this.saveCodeButton.Name = "saveCodeButton";
            this.saveCodeButton.UseVisualStyleBackColor = false;
            this.saveCodeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodeEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveCodeButton);
            this.Controls.Add(this.webControl);
            this.Name = "CodeEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Awesomium.Windows.Forms.WebControl webControl;
        private System.Windows.Forms.Button saveCodeButton;
    }
}

