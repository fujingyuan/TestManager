using NPOI.SS.Formula.Functions;
using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestManager
{
    public partial class TestForm : UIForm
    {
        public FormData mFormData = Singleton.Instance.Data;
        private string excelFilePath= "C:\\Users\\Test\\Desktop\\GGGGGGGGGGGGGGGGGGGG\\测试用例.xlsx";
        private ArrayList arr = new ArrayList();
        private ArrayList arrIndex = new ArrayList();
        private NationalInstruments.TestStand.Interop.API.SequenceContext mSequenceContext;
        public string checkboxName = "选择";
        private System.Windows.Forms.Timer mSetForegroundTimer;
        private System.Windows.Forms.Timer mCancelDialogTimer;
        private NationalInstruments.TestStand.Interop.API.PropertyObject mTerminationData;

        public TestForm()
        {
         
            InitializeComponent();
            
        }
        public TestForm(NationalInstruments.TestStand.Interop.API.SequenceContext currentContext)
        {
            mSequenceContext = currentContext;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn CheckColunms = new DataGridViewCheckBoxColumn();
            CheckColunms.Name = checkboxName;
            CheckColunms.HeaderText = checkboxName;
            //  CheckColunms.Width = 60;
            CheckColunms.TrueValue = "1";
            CheckColunms.FalseValue = "0";
            TestDataGrideView.Columns.Add(CheckColunms);
            TestDataGrideView.CellContentClick += TestDataGrideView_CellContentClick;

            mFormData.TableData = ExcelHelper.ImportFromExcel(ref excelFilePath, "Sheet1", 0);
            mFormData.SelectedData = mFormData.TableData.Clone();
            ExcelPathTextBox.Text = excelFilePath;
            TestDataGrideView.DataSource = mFormData.TableData;
            TestDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void FileBrowserButton_Click(object sender, EventArgs e)
        {
            excelFilePath = string.Empty;
            mFormData.TableData = ExcelHelper.ImportFromExcel(ref excelFilePath, "Sheet1", 0);
            mFormData.SelectedData = mFormData.TableData.Clone();
            ExcelPathTextBox.Text = excelFilePath;
            TestDataGrideView.DataSource = mFormData.TableData;
            TestDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void excelPathTextBox_TextChanged(object sender, EventArgs e)
        {
            ExcelPathTextBox.Text = excelFilePath;
        }

        private void TestDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                int rowIndex = e.RowIndex;
                //checkbox 勾上
                if ((bool)TestDataGrideView.Rows[e.RowIndex].Cells[0].EditedFormattedValue == true)
                {
                    //选中改为不选中
                    this.TestDataGrideView.Rows[e.RowIndex].Cells[0].Value = false;
                
                        if(!arrIndex.Contains(rowIndex))
                        {
                            arrIndex.Add(rowIndex);
                            TestDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
                           // TestDataGrideView.GridColor = Color.Yellow;
                        }
         
                }
                else
                {
                    //不选中改为选中
             
                    if (arrIndex.Contains(rowIndex))
                    {
                        arrIndex.Remove(rowIndex);
                        TestDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                       // mFormData.TableData.Rows.RemoveAt(e.RowIndex);
                    }
                    this.TestDataGrideView.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            foreach ( int index in arrIndex)
            {
                //mFormData.SelectedData.ImportRow(mFormData.TableData.Rows[index]);
            }
            //TestDataGrideView.DataSource = mFormData.SelectedData;
            new SelectForm().Show();
            this.Hide();
        }


        private void SetForegroundTimer_Tick(object sender, System.EventArgs e)
        {
            this.Activate();
            this.mSetForegroundTimer.Enabled = false;
        }

        public void InitializeTerminationStateChecking()
        {
            this.mTerminationData = this.mSequenceContext.Execution.InitTerminationMonitor();
            if (this.mSequenceContext != null)
                this.mCancelDialogTimer.Enabled = true;
        }

        private void CancelDialogTimer_Tick(object sender, System.EventArgs e)
        {
            if (this.mSequenceContext != null)
                if (this.mSequenceContext.Execution != null)
                    if (this.mSequenceContext.Execution.GetTerminationMonitorStatus(this.mTerminationData, this.mSequenceContext))
                        ConfirmButton_Click(this.ConfirmButton, new System.EventArgs());
        }

    }
}
