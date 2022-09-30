using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestManager
{
    public partial class SelectPage : UIPage
    {
        public FormData mFormData = Singleton.Instance.Data;
        private int rowCount = 0;
        private bool excelLoaded = false;
        public SelectPage()
        {  
            InitializeComponent();
            SelectDataGrideView.DataSource = mFormData.SelectedData;
            SelectDataGrideView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Timer.Interval = 1000;     
        }
        private void SelectPage_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mFormData.ExcelPath) && mFormData.SelectedData.Columns.Count>0)
            {
                excelLoaded = true;
                SelectDataGrideView.DataSource = mFormData.SelectedData;
                SelectDataGrideView.Columns[0].Visible = false;
                rowCount = mFormData.SelectedData.Rows.Count;
                SelectDataGrideView.DataSource = mFormData.SelectedData;
                if (mFormData.Count < rowCount - 1 && mFormData.Count > 0)
                {
                    SelectDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.SelectDataGrideView.CurrentCell = this.SelectDataGrideView.Rows[mFormData.Count].Cells[0];
                    Timer.Start();
                }
                if (mFormData.Count == 0)
                {
                    SelectDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.SelectDataGrideView.CurrentCell = this.SelectDataGrideView.Rows[mFormData.Count].Cells[0];
                }
                else
                {

                }
            }
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (excelLoaded == true)
            {
                if (mFormData.Count >= 1 && mFormData.Count < rowCount - 1)
                {
                    SelectDataGrideView.Rows[mFormData.Count - 1].DefaultCellStyle.BackColor = Color.White;
                    SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.SelectDataGrideView.CurrentCell = this.SelectDataGrideView.Rows[mFormData.Count].Cells[0];
                }
                else if (mFormData.Count == 0 || mFormData.Count == rowCount - 1)

                {
                    SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.SelectDataGrideView.CurrentCell = this.SelectDataGrideView.Rows[mFormData.Count].Cells[0];
                }
                else
                {
                    mFormData.Loop = false;
                    ShowWarningDialog("没有测试用例");
                }
            }
            else
            {
                ShowWarningDialog("没有测试用例");
            }

        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (excelLoaded)
            {
                Timer.Stop();
                if (mFormData.Count < rowCount - 1 && mFormData.Count >= 0)
                {

                    SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.White;
                    ++mFormData.Count;
                    SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.SelectDataGrideView.CurrentCell = this.SelectDataGrideView.Rows[mFormData.Count].Cells[0];
                }
                else if (mFormData.Count == rowCount - 1)
                {
                    mFormData.Loop = false;
                    SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.White;
                    ShowWarningDialog("没有测试用例");
                }
            }
            else
            {
                ShowWarningDialog("没有测试用例");
            }

            //  mFormData.SelectedData.Rows.Clear();

        }
        public void TimerStart()
        {
            Timer.ReStart();
        }
        public void TimerStop()
        {
            Timer.Stop();
        }
        private void uiMillisecondTimer1_Tick(object sender, EventArgs e)
        {

            Timer.Stop();
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    if (mFormData.Count < rowCount - 1 && mFormData.Count > 0)
                    {
                        SelectDataGrideView.Rows[mFormData.Count - 1].DefaultCellStyle.BackColor = Color.White;
                        SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                        this.SelectDataGrideView.CurrentCell = this.SelectDataGrideView.Rows[mFormData.Count].Cells[0];
                    }
                    else if (mFormData.Count == rowCount - 1)
                    {
                        mFormData.Loop = false;
                        SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.White;
                    }
                    else
                    {
                        mFormData.Loop = false;
                        ShowWarningDialog("没有测试用例");
                    }
                    this.Hide();
                }));
            }
            else
            {

            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

     

        private void ExitButton_Click(object sender, EventArgs e)
        {
            mFormData.Exit = true;
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (excelLoaded)
            {
                Timer.Stop();
                SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.White;
                mFormData.Loop = true;
                mFormData.Count = 0;
                mFormData.Exit = false;
                SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                this.SelectDataGrideView.CurrentCell = this.SelectDataGrideView.Rows[mFormData.Count].Cells[0];
            }
            else
            {
                ShowWarningDialog("没有测试用例");
            }

        }
        private int getValue(object cell)
        {
            if (string.IsNullOrEmpty(cell.ToString()))
            {
                return 0;
            }
            else
            {
                return int.Parse(cell.ToString());
            }
        }

        private void SelectPage_Initialize(object sender, EventArgs e)
        {
           
        }

        private void HighlightRow()
        {
            if (!string.IsNullOrEmpty(mFormData.ExcelPath) && mFormData.SelectedData.Columns.Count > 0)
            {
                excelLoaded = true;
                SelectDataGrideView.DataSource = mFormData.SelectedData;
                SelectDataGrideView.Columns[0].Visible = false;
                rowCount = mFormData.SelectedData.Rows.Count;
                SelectDataGrideView.DataSource = mFormData.SelectedData;
                if (mFormData.Count < rowCount - 1 && mFormData.Count > 0)
                {
                    SelectDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.SelectDataGrideView.CurrentCell = this.SelectDataGrideView.Rows[mFormData.Count].Cells[0];
                    Timer.Start();
                }
                if (mFormData.Count == 0)
                {
                    SelectDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    SelectDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.SelectDataGrideView.CurrentCell = this.SelectDataGrideView.Rows[mFormData.Count].Cells[0];
                }
                else
                {

                }
            }
        }
        public void SetTableData(DataTable data)
        {
            SelectDataGrideView.DataSource = data;
            SelectDataGrideView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            SelectDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // HighlightRow();
        }
        private void SelectDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
