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
        private ArrayList arr = new ArrayList();
        private ArrayList arrIndex = new ArrayList();
        private Dictionary<int, int> indexDic = new Dictionary<int, int>();
        private NationalInstruments.TestStand.Interop.API.SequenceContext mSequenceContext;
        private NationalInstruments.TestStand.Interop.API.PropertyObject mTerminationMonitorData;
        public string checkboxName = "选择";
        private int rowCount = 0;
        private Thread invokeThread;
        private bool excelLoaded = false;
        public TestForm()
        {

            InitializeComponent();
            this.Timer.Interval = 100;
        }
        public TestForm(NationalInstruments.TestStand.Interop.API.SequenceContext currentContext)
        {
            mSequenceContext = currentContext;
            //mFormData.Count = 0;
            InitializeComponent();
            this.Timer.Interval = 3000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mFormData.ExcelPath))
            {
                excelLoaded = true;
                rowCount = mFormData.TableData.Rows.Count;
                //mFormData.SelectedData = mFormData.TableData.Clone();
                ExcelPathTextBox.Text = mFormData.ExcelPath;
                TestDataGrideView.DataSource = mFormData.TableData;
                if (mFormData.Count < rowCount - 1 && mFormData.Count > 0)
                {
                    TestDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.TestDataGrideView.CurrentCell = this.TestDataGrideView.Rows[mFormData.Count].Cells[0];
                    Timer.Start();
                }
                if (mFormData.Count == 0)
                {
                    TestDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.TestDataGrideView.CurrentCell = this.TestDataGrideView.Rows[mFormData.Count].Cells[0];
                }
                else
                {

                }
            }
        }

        private void FileBrowserButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            string oldpath = mFormData.ExcelPath;
            openFileDialog1.InitialDirectory = Common.DesktopDirectory;
            openFileDialog1.Filter = "Excel Office2007及以上(*.xlsx)|*.xlsx|Excel Office97-2003(*.xls)|*.xls";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "打开";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            invokeThread = new Thread(new ThreadStart(InvokeMethod));
            invokeThread.SetApartmentState(ApartmentState.STA);
            invokeThread.Start();
            invokeThread.Join();
            if (!mFormData.ExcelPath.Equals(oldpath))
            {
                mFormData.Count = 0;
                mFormData.TableData = ExcelHelper.ImportFromExcel(mFormData.ExcelPath, "Sheet1", 0) ?? mFormData.TableData;
                rowCount = mFormData.TableData.Rows.Count;
                mFormData.SelectedData = mFormData.TableData.Clone();
                ExcelPathTextBox.Text = mFormData.ExcelPath ?? ExcelPathTextBox.Text;
                TestDataGrideView.DataSource = mFormData.TableData;
                TestDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                this.TestDataGrideView.CurrentCell = this.TestDataGrideView.Rows[mFormData.Count].Cells[0];
                excelLoaded = true;
            }


        }


        // }
        private void InvokeMethod()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mFormData.ExcelPath = openFileDialog1.FileName;
                //  System.Diagnostics.Process.Start(openFileDialog1.FileName);
            }

        }
        private void excelPathTextBox_TextChanged(object sender, EventArgs e)
        {
            ExcelPathTextBox.Text = mFormData.ExcelPath;
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (excelLoaded == true)
            {
                if (mFormData.Count >= 1 && mFormData.Count < rowCount - 1)
                {
                    TestDataGrideView.Rows[mFormData.Count - 1].DefaultCellStyle.BackColor = Color.White;
                    TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.TestDataGrideView.CurrentCell = this.TestDataGrideView.Rows[mFormData.Count].Cells[0];
                }
                else if (mFormData.Count == 0 || mFormData.Count == rowCount - 1)

                {
                    TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.TestDataGrideView.CurrentCell = this.TestDataGrideView.Rows[mFormData.Count].Cells[0];
                }
                else
                {
                    mFormData.Loop = false;
                    ShowWarningDialog("没有测试用例");
                }

                this.Hide();
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

                    TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.White;
                    ++mFormData.Count;
                    TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                    this.TestDataGrideView.CurrentCell = this.TestDataGrideView.Rows[mFormData.Count].Cells[0];
                }
                else if (mFormData.Count == rowCount - 1)
                {
                    mFormData.Loop = false;
                    TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.White;
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

                        TestDataGrideView.Rows[mFormData.Count - 1].DefaultCellStyle.BackColor = Color.White;
                        TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                        this.TestDataGrideView.CurrentCell = this.TestDataGrideView.Rows[mFormData.Count].Cells[0];
                    }
                    else if (mFormData.Count == rowCount - 1)
                    {
                        mFormData.Loop = false;
                        TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.White;
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
            //string testSeq = mFormData.SeqMap[mFormData.TableData.Rows[mFormData.Count][2].ToString()];
            //int hv_v = getValue(mFormData.TableData.Rows[mFormData.Count][3]);
            //int hv_t = getValue(mFormData.TableData.Rows[mFormData.Count][4]);
            //int rv_v = getValue(mFormData.TableData.Rows[mFormData.Count][5]);
            //int rv_t = getValue(mFormData.TableData.Rows[mFormData.Count][6]);
            //int rv_dec = getValue(mFormData.TableData.Rows[mFormData.Count][7]);
            //int distance = getValue(mFormData.TableData.Rows[mFormData.Count][8]);
        }
        public void InitializeTerminationStateChecking()
        {
            this.mTerminationMonitorData = this.mSequenceContext.Execution.InitTerminationMonitor();
            if (mSequenceContext != null)
                CancelTimer.Enabled = true;
        }
        private void CancelTimer_Tick(object sender, EventArgs e)
        {
            //if the execution is terminated, close the dialog
            if (this.mSequenceContext != null)
                if (this.mSequenceContext.Execution != null)
                    if (this.mSequenceContext.Execution.GetTerminationMonitorStatus(this.mTerminationMonitorData, this.mSequenceContext))
                        Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CancelTimer.Enabled = false;
            this.Dispose();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            mFormData.Exit = true;
            this.Hide();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (excelLoaded)
            {
                Timer.Stop();
                TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.White;
                mFormData.Loop = true;
                mFormData.Count = 0;
                mFormData.Exit = false;
                TestDataGrideView.Rows[mFormData.Count].DefaultCellStyle.BackColor = Color.Gold;
                this.TestDataGrideView.CurrentCell = this.TestDataGrideView.Rows[mFormData.Count].Cells[0];
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
    }
}
