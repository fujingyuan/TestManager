﻿
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
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.ResetButton = new Sunny.UI.UIButton();
            this.ExitButton = new Sunny.UI.UIButton();
            this.PauseButton = new Sunny.UI.UIButton();
            this.NextButton = new Sunny.UI.UIButton();
            this.ConfirmButton = new Sunny.UI.UIButton();
            this.Timer = new Sunny.UI.UIMillisecondTimer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CancelTimer = new Sunny.UI.UIMillisecondTimer(this.components);
            this.SelectDataGrideView = new Sunny.UI.UIDataGridView();
            this.ControlPanel = new Sunny.UI.UIPanel();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGrideView)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.ResetButton);
            this.uiGroupBox2.Controls.Add(this.ExitButton);
            this.uiGroupBox2.Controls.Add(this.PauseButton);
            this.uiGroupBox2.Controls.Add(this.NextButton);
            this.uiGroupBox2.Controls.Add(this.ConfirmButton);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(49, 647);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(1062, 97);
            this.uiGroupBox2.TabIndex = 10;
            this.uiGroupBox2.Text = null;
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "测试样例.xls";
            // 
            // CancelTimer
            // 
            this.CancelTimer.Interval = 100;
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
            this.SelectDataGrideView.Size = new System.Drawing.Size(1162, 652);
            this.SelectDataGrideView.TabIndex = 0;
            this.SelectDataGrideView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.SelectDataGrideView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectDataGrideView_CellContentClick);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.SelectDataGrideView);
            this.ControlPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ControlPanel.Location = new System.Drawing.Point(-2, 2);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ControlPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1162, 652);
            this.ControlPanel.TabIndex = 9;
            this.ControlPanel.Text = null;
            this.ControlPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ControlPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SelectPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1160, 769);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.uiGroupBox2);
            this.Name = "SelectPage";
            this.Text = "SelectPage";
            this.Initialize += new System.EventHandler(this.SelectPage_Initialize);
            this.Load += new System.EventHandler(this.SelectPage_Load);
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGrideView)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton ResetButton;
        private Sunny.UI.UIButton ExitButton;
        private Sunny.UI.UIButton PauseButton;
        private Sunny.UI.UIButton NextButton;
        private Sunny.UI.UIButton ConfirmButton;
        private Sunny.UI.UIMillisecondTimer Timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sunny.UI.UIMillisecondTimer CancelTimer;
        private Sunny.UI.UIDataGridView SelectDataGrideView;
        private Sunny.UI.UIPanel ControlPanel;
    }
}