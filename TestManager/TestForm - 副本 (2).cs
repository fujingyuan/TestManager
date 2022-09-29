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
        private string excelFilePath = "C:\\Users\\Test\\Desktop\\GGGGGGGGGGGGGGGGGGGG\\测试用例.xlsx";
        private ArrayList arr = new ArrayList();
        private ArrayList arrIndex = new ArrayList();
        private Dictionary<int, int> indexDic = new Dictionary<int, int>();
        private NationalInstruments.TestStand.Interop.API.SequenceContext mSequenceContext;
        private NationalInstruments.TestStand.Interop.API.PropertyObject mTerminationMonitorData;
        public string checkboxName = "选择";

        private int sec = 29;

        public TestForm()
        {

            InitializeComponent();
            this.Timer.Interval = 100;
        }
        public TestForm(NationalInstruments.TestStand.Interop.API.SequenceContext currentContext)
        {
            mSequenceContext = currentContext;
            InitializeComponent();
            this.Timer.Interval = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Timer.Start();
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

                    if (!arrIndex.Contains(rowIndex))
                    {
                        arrIndex.Add(rowIndex);
                        // TestDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
                        // TestDataGrideView.GridColor = Color.Yellow;
                    }

                }
                else
                {
                    //不选中改为选中

                    if (arrIndex.Contains(rowIndex))
                    {
                        arrIndex.Remove(rowIndex);
                        //  TestDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        // mFormData.TableData.Rows.RemoveAt(e.RowIndex);
                    }
                    this.TestDataGrideView.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(mFormData.Count>1 && mFormData.Count<arrIndex.Count)
            {
                if((int)arrIndex[mFormData.Count-1]!=0)
                {
                    int index1 = (int)arrIndex[mFormData.Count - 1];
                   TestDataGrideView.Rows[index1].DefaultCellStyle.BackColor = Color.White;
                    arrIndex[mFormData.Count - 1] = 0;
                }
            }


            //if (arrIndex.Count > 1)
            //{
            //    if (mFormData.Count > 1)
            //    {
            //        if (arrIndex.Contains(arrIndex.Count - 1))
            //        {
            //            int index1 = (int)arrIndex[mFormData.Count - 1];
            //            TestDataGrideView.Rows[index1].DefaultCellStyle.BackColor = Color.White;
            //            arrIndex.Remove(index1);
            //        }
            //        int index2 = (int)arrIndex[mFormData.Count];
            //        TestDataGrideView.Rows[index2].DefaultCellStyle.BackColor = Color.SkyBlue;
            //    }
            //    else
            //    {
            //        int index2 = (int)arrIndex[mFormData.Count];
            //        TestDataGrideView.Rows[index2].DefaultCellStyle.BackColor = Color.SkyBlue;
            //    }

            //}
            //else if (arrIndex.Count == 1)
            //{
            //    int index = (int)arrIndex[mFormData.Count];
            //    TestDataGrideView.Rows[index].DefaultCellStyle.BackColor = Color.SkyBlue;

            //}
            //else
            //{
            //    MessageBox.Show("没有选择测试用例");
            //}

            //Timer.Start();
            //foreach ( int index in arrIndex)
            //{
            //    mFormData.SelectedData.ImportRow(mFormData.TableData.Rows[index]);
            //}

            //TestDataGrideView.DataSource = mFormData.SelectedData;
            // new SelectForm().Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //  sec = 29;
            //Timer.ReStart();
            if (arrIndex.Count >= 2)
            {
                int index1 = (int)arrIndex[mFormData.Count];
                TestDataGrideView.Rows[index1].DefaultCellStyle.BackColor = Color.White;
                int index2 = (int)arrIndex[++mFormData.Count];
                TestDataGrideView.Rows[index2].DefaultCellStyle.BackColor = Color.SkyBlue;
                arrIndex.Remove(mFormData.Count);

            }
            else if (arrIndex.Count == 1)
            {
                int index1 = (int)arrIndex[0];
                TestDataGrideView.Rows[index1].DefaultCellStyle.BackColor = Color.White;
                MessageBox.Show("没有测试用例");
                ++mFormData.Count;
            }
            else
            {
                MessageBox.Show("没有测试用例");
            }
            //  mFormData.SelectedData.Rows.Clear();

        }

        private void uiMillisecondTimer1_Tick(object sender, EventArgs e)
        {
            sec--;
            if (sec == 0)
            {
                sec = 0;
                Timer.Stop();

                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Hide();

                    }));
                }
                else
                {

                }
            }
        }
    }
}
