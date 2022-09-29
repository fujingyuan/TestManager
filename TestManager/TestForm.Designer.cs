
namespace TestManager
{
    partial class TestForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FileBrowserButton = new Sunny.UI.UIButton();
            this.ExcelPathTextBox = new Sunny.UI.UITextBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.TestDataGrideView = new Sunny.UI.UIDataGridView();
            this.ControlPanel = new Sunny.UI.UIPanel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.ExitButton = new Sunny.UI.UIButton();
            this.PauseButton = new Sunny.UI.UIButton();
            this.NextButton = new Sunny.UI.UIButton();
            this.ConfirmButton = new Sunny.UI.UIButton();
            this.Timer = new Sunny.UI.UIMillisecondTimer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CancelTimer = new Sunny.UI.UIMillisecondTimer(this.components);
            this.ResetButton = new Sunny.UI.UIButton();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestDataGrideView)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileBrowserButton
            // 
            this.FileBrowserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileBrowserButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileBrowserButton.Location = new System.Drawing.Point(819, 30);
            this.FileBrowserButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.FileBrowserButton.Name = "FileBrowserButton";
            this.FileBrowserButton.Size = new System.Drawing.Size(163, 41);
            this.FileBrowserButton.TabIndex = 1;
            this.FileBrowserButton.Text = "选择Excel文件";
            this.FileBrowserButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileBrowserButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.FileBrowserButton.Click += new System.EventHandler(this.FileBrowserButton_Click);
            // 
            // ExcelPathTextBox
            // 
            this.ExcelPathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExcelPathTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExcelPathTextBox.Location = new System.Drawing.Point(20, 34);
            this.ExcelPathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExcelPathTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.ExcelPathTextBox.Name = "ExcelPathTextBox";
            this.ExcelPathTextBox.ShowText = false;
            this.ExcelPathTextBox.Size = new System.Drawing.Size(680, 36);
            this.ExcelPathTextBox.TabIndex = 2;
            this.ExcelPathTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExcelPathTextBox.Watermark = "";
            this.ExcelPathTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.ExcelPathTextBox);
            this.uiGroupBox1.Controls.Add(this.FileBrowserButton);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(27, 40);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(1062, 81);
            this.uiGroupBox1.TabIndex = 3;
            this.uiGroupBox1.Text = null;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // TestDataGrideView
            // 
            this.TestDataGrideView.AllowUserToAddRows = false;
            this.TestDataGrideView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TestDataGrideView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.TestDataGrideView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.TestDataGrideView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestDataGrideView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.TestDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TestDataGrideView.DefaultCellStyle = dataGridViewCellStyle28;
            this.TestDataGrideView.EnableHeadersVisualStyles = false;
            this.TestDataGrideView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TestDataGrideView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.TestDataGrideView.Location = new System.Drawing.Point(6, 3);
            this.TestDataGrideView.Name = "TestDataGrideView";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestDataGrideView.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.TestDataGrideView.RowHeadersWidth = 51;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TestDataGrideView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.TestDataGrideView.RowTemplate.Height = 27;
            this.TestDataGrideView.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.TestDataGrideView.SelectedIndex = -1;
            this.TestDataGrideView.Size = new System.Drawing.Size(1053, 529);
            this.TestDataGrideView.TabIndex = 0;
            this.TestDataGrideView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.TestDataGrideView);
            this.ControlPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ControlPanel.Location = new System.Drawing.Point(27, 131);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ControlPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1062, 534);
            this.ControlPanel.TabIndex = 4;
            this.ControlPanel.Text = null;
            this.ControlPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ControlPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.ResetButton);
            this.uiGroupBox2.Controls.Add(this.ExitButton);
            this.uiGroupBox2.Controls.Add(this.PauseButton);
            this.uiGroupBox2.Controls.Add(this.NextButton);
            this.uiGroupBox2.Controls.Add(this.ConfirmButton);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(27, 662);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(1062, 97);
            this.uiGroupBox2.TabIndex = 7;
            this.uiGroupBox2.Text = null;
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.Location = new System.Drawing.Point(20, 35);
            this.ExitButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(161, 42);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "退出";
            this.ExitButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PauseButton.Location = new System.Drawing.Point(447, 34);
            this.PauseButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(161, 42);
            this.PauseButton.TabIndex = 9;
            this.PauseButton.Text = "暂停";
            this.PauseButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PauseButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextButton.Location = new System.Drawing.Point(660, 35);
            this.NextButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(161, 42);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = "跳过";
            this.NextButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.Location = new System.Drawing.Point(872, 34);
            this.ConfirmButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(161, 42);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.uiMillisecondTimer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "测试样例.xls";
            // 
            // CancelTimer
            // 
            this.CancelTimer.Interval = 100;
            this.CancelTimer.Tick += new System.EventHandler(this.CancelTimer_Tick);
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetButton.Location = new System.Drawing.Point(235, 35);
            this.ResetButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(161, 42);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "重置";
            this.ResetButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1113, 777);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "TestForm";
            this.Text = "TestManager";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestDataGrideView)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton FileBrowserButton;
        private Sunny.UI.UITextBox ExcelPathTextBox;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIDataGridView TestDataGrideView;
        private Sunny.UI.UIPanel ControlPanel;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton PauseButton;
        private Sunny.UI.UIButton NextButton;
        private Sunny.UI.UIButton ConfirmButton;
        private Sunny.UI.UIMillisecondTimer Timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIButton ExitButton;
        private Sunny.UI.UIMillisecondTimer CancelTimer;
        private Sunny.UI.UIButton ResetButton;
    }
}

