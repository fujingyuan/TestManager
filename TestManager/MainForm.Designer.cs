
namespace TestManager
{
    partial class mainForm
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
            this.uiFileBrowserTextBox = new Sunny.UI.UITextBox();
            this.FileBrowserButton = new Sunny.UI.UIButton();
            this.ConfirmButton = new Sunny.UI.UIButton();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.ConfirmButton);
            this.Footer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Footer.Location = new System.Drawing.Point(99, 683);
            this.Footer.Size = new System.Drawing.Size(1105, 55);
            this.Footer.Style = Sunny.UI.UIStyle.Custom;
            this.Footer.StyleCustomMode = true;
            this.Footer.Click += new System.EventHandler(this.Footer_Click);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.FileBrowserButton);
            this.Header.Controls.Add(this.uiFileBrowserTextBox);
            this.Header.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(99, 35);
            this.Header.Size = new System.Drawing.Size(1105, 63);
            this.Header.Style = Sunny.UI.UIStyle.Custom;
            this.Header.StyleCustomMode = true;
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // Aside
            // 
            this.Aside.Size = new System.Drawing.Size(99, 703);
            this.Aside.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.Aside_MenuItemClick);
            // 
            // uiFileBrowserTextBox
            // 
            this.uiFileBrowserTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiFileBrowserTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiFileBrowserTextBox.Location = new System.Drawing.Point(37, 11);
            this.uiFileBrowserTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiFileBrowserTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiFileBrowserTextBox.Name = "uiFileBrowserTextBox";
            this.uiFileBrowserTextBox.ShowButton = true;
            this.uiFileBrowserTextBox.ShowText = false;
            this.uiFileBrowserTextBox.Size = new System.Drawing.Size(813, 39);
            this.uiFileBrowserTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.uiFileBrowserTextBox.TabIndex = 53;
            this.uiFileBrowserTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiFileBrowserTextBox.Watermark = "请选择Excel文件";
            this.uiFileBrowserTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiFileBrowserTextBox.TextChanged += new System.EventHandler(this.uiFileBrowserTextBox_TextChanged);
            // 
            // FileBrowserButton
            // 
            this.FileBrowserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileBrowserButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileBrowserButton.Location = new System.Drawing.Point(875, 10);
            this.FileBrowserButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.FileBrowserButton.Name = "FileBrowserButton";
            this.FileBrowserButton.Size = new System.Drawing.Size(163, 41);
            this.FileBrowserButton.Style = Sunny.UI.UIStyle.Custom;
            this.FileBrowserButton.TabIndex = 54;
            this.FileBrowserButton.Text = "选择Excel文件";
            this.FileBrowserButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileBrowserButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.FileBrowserButton.Click += new System.EventHandler(this.FileBrowserButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.Location = new System.Drawing.Point(875, 8);
            this.ConfirmButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(161, 42);
            this.ConfirmButton.Style = Sunny.UI.UIStyle.Custom;
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1204, 738);
            this.Name = "mainForm";
            this.Text = "V2XTestManager";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 1024, 720);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox uiFileBrowserTextBox;
        private Sunny.UI.UIButton FileBrowserButton;
        private Sunny.UI.UIButton ConfirmButton;
    }
}