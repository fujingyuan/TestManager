
namespace TestManager
{
    partial class SelectPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Timer = new Sunny.UI.UIMillisecondTimer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CancelTimer = new Sunny.UI.UIMillisecondTimer(this.components);
            this.ControlPanel = new Sunny.UI.UIPanel();
            this.ResetButton = new Sunny.UI.UIButton();
            this.ExitButton = new Sunny.UI.UIButton();
            this.PauseButton = new Sunny.UI.UIButton();
            this.NextButton = new Sunny.UI.UIButton();
            this.ConfirmButton = new Sunny.UI.UIButton();
            this.SelectDataGrideView = new Sunny.UI.UIDataGridView();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "测试样例.xls";
            // 
            // CancelTimer
            // 
            this.CancelTimer.Interval = 100;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.SelectDataGrideView);
            this.ControlPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ControlPanel.Location = new System.Drawing.Point(-2, 2);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ControlPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1162, 500);
            this.ControlPanel.TabIndex = 9;
            this.ControlPanel.Text = null;
            this.ControlPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ControlPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetButton.Location = new System.Drawing.Point(285, 519);
            this.ResetButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(161, 42);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "重置";
            this.ResetButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.Location = new System.Drawing.Point(70, 519);
            this.ExitButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(161, 42);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "退出";
            this.ExitButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ExitButton.Click   += new System.EventHandler(this.ExitButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PauseButton.Location = new System.Drawing.Point(497, 518);
            this.PauseButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(161, 42);
            this.PauseButton.TabIndex = 14;
            this.PauseButton.Text = "暂停";
            this.PauseButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PauseButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextButton.Location = new System.Drawing.Point(710, 519);
            this.NextButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(161, 42);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "跳过";
            this.NextButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);

            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.Location = new System.Drawing.Point(922, 518);
            this.ConfirmButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(161, 42);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SelectDataGrideView
            // 
            this.SelectDataGrideView.AllowUserToAddRows = false;
            this.SelectDataGrideView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.SelectDataGrideView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SelectDataGrideView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.SelectDataGrideView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectDataGrideView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SelectDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectDataGrideView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SelectDataGrideView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectDataGrideView.EnableHeadersVisualStyles = false;
            this.SelectDataGrideView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectDataGrideView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.SelectDataGrideView.Location = new System.Drawing.Point(0, 0);
            this.SelectDataGrideView.Name = "SelectDataGrideView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectDataGrideView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SelectDataGrideView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SelectDataGrideView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.SelectDataGrideView.RowTemplate.Height = 27;
            this.SelectDataGrideView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.SelectDataGrideView.SelectedIndex = -1;
            this.SelectDataGrideView.Size = new System.Drawing.Size(1162, 500);
            this.SelectDataGrideView.TabIndex = 1;
            this.SelectDataGrideView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SelectPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1160, 572);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ControlPanel);
            this.Name = "SelectPage";
            this.Text = "SelectPage";
            this.Initialize += new System.EventHandler(this.SelectPage_Initialize);
            this.Load += new System.EventHandler(this.SelectPage_Load);
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGrideView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIMillisecondTimer Timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIMillisecondTimer CancelTimer;
        private Sunny.UI.UIPanel ControlPanel;
        private Sunny.UI.UIButton ResetButton;
        private Sunny.UI.UIButton ExitButton;
        private Sunny.UI.UIButton PauseButton;
        private Sunny.UI.UIButton NextButton;
        private Sunny.UI.UIButton ConfirmButton;
        private Sunny.UI.UIDataGridView SelectDataGrideView;
    }
}