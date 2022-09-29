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
    public partial class mainForm : UIAsideHeaderMainFooterFrame
    {
        public FormData mFormData = Singleton.Instance.Data;
        private string excelFilePath;
        private bool exelLoaded = false;
        public mainForm()
        {
            InitializeComponent();

            //设置关联
            Aside.TabControl = MainTabControl;

            //增加页面到Main
            UIPage Selected = new SelectPage();
            UIPage FCW = new Page();
            UIPage ICW = new Page();
            UIPage LTA = new Page();
            UIPage BSW = new Page();
            UIPage DNPW = new Page();
            UIPage EBW = new Page();
            UIPage AVW = new Page();
            UIPage CLW = new Page();
            UIPage HLW = new Page();
            UIPage SLW = new Page();
            UIPage RLVW = new Page();
            UIPage VRUCW = new Page();
            UIPage GLOSA = new Page();
            UIPage IVS = new Page();
            UIPage TJW = new Page();
            UIPage EVW = new Page();
            AddPage(FCW, 1);
            AddPage(ICW, 2);
            AddPage(LTA, 3);
            AddPage(BSW, 4);
            AddPage(DNPW, 5);
            AddPage(EBW, 6);
            AddPage(AVW, 7);
            AddPage(CLW, 8);
            AddPage(HLW, 9);
            AddPage(SLW, 10);
            AddPage(RLVW, 11);
            AddPage(VRUCW, 12);
            AddPage(GLOSA, 13);
            AddPage(IVS, 14);
            AddPage(TJW, 15);
            AddPage(EVW, 16);
            AddPage(Selected, 17);
            //设置Header节点索引
            Aside.CreateNode("FCW", 1);
            Aside.CreateNode("ICW", 2);
            Aside.CreateNode("LTA", 3);
            Aside.CreateNode("BSW", 4);
            Aside.CreateNode("DNPW", 5);
            Aside.CreateNode("EBW", 6);
            Aside.CreateNode("AVW", 7);
            Aside.CreateNode("CLW", 8);
            Aside.CreateNode("HLW", 9);
            Aside.CreateNode("SLW", 10);
            Aside.CreateNode("RLVW", 11);
            Aside.CreateNode("VRUCW", 12);
            Aside.CreateNode("GLOSA", 13);
            Aside.CreateNode("IVS", 14);
            Aside.CreateNode("TJW", 15);
            Aside.CreateNode("EVW", 16);
            Aside.CreateNode("待测项", 17);
            //显示默认界面
            //Aside.SelectFirst();
        }

        private void Aside_MenuItemClick(System.Windows.Forms.TreeNode node, NavMenuItem item, int pageIndex)
        {
            this.ConfirmButton.Hide();
            if (exelLoaded)
            {
                Footer.Text = Header.Text = "Event: " + node.Text;
                Header.Text = "";
                if (mFormData.TableDataDic.TryGetValue(node.Text, out DataTable data))
                {
                    if(node.Text ==  "待测项")
                    {
                        SelectPage page = (SelectPage)GetPage(pageIndex);
                        page.SetTableData(mFormData.SelectedData);
                    }
                    else
                    {
                    Page page = (Page)GetPage(pageIndex);
                    page.SetTableData(data);
                    }
                }
                else
                {
                    if (node.Text == "待测项")
                    {
                        SelectPage page = (SelectPage)GetPage(pageIndex);
                        mFormData.TableDataDic.Add(node.Text, mFormData.SelectedData);
                        page.SetTableData(mFormData.SelectedData);
                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt = mFormData.TableData.Clone();
                        string exp = "场景 = " + "\'" + node.Text + "\'";
                        DataRow[] GetRows = mFormData.TableData.Select(exp);
                        foreach (DataRow row in GetRows)
                        {
                            dt.Rows.Add(row.ItemArray);
                        }
                        mFormData.TableDataDic.Add(node.Text, dt);
                        Page page = (Page)GetPage(pageIndex);
                        page.SetTableData(dt);
                    }
                }
            }
            else
            {

            }


        }

        private void Footer_Click(object sender, System.EventArgs e)
        {
            this.ConfirmButton.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void uiFileBrowserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileBrowserButton_Click(object sender, EventArgs e)
        {
            excelFilePath = string.Empty;
            mFormData.TableData = ExcelHelper.ImportFromExcel(ref excelFilePath, "Sheet1", 0);
            if (mFormData.TableData != null)
            {
                mFormData.SelectedData = mFormData.TableData.Clone();
                uiFileBrowserTextBox.Text = excelFilePath;
                Aside.SelectFirst();
                exelLoaded = true;
            }
            else
            {
            }

            //TestDataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            new SelectForm().Show();
        }
    }
}

