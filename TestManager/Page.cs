using Sunny.UI;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TestManager
{
    public partial class Page :  UIPage
    {
        public LinkedList<DataRow> selectList { get; private set; } = new LinkedList<DataRow>();
        public FormData mFormData = Singleton.Instance.Data;
        public Page()
    {
            InitializeComponent();
            DataGridViewCheckBoxColumn CheckColunms = new DataGridViewCheckBoxColumn();
            CheckColunms.Name = "选择";
            CheckColunms.HeaderText = "选择";
            CheckColunms.TrueValue = "1";
            CheckColunms.FalseValue = "0";
            PageDataGrideView.Columns.Add(CheckColunms); 
            PageDataGrideView.CellContentClick += PageDataGrideView_CellContentClick;
        }

        private void Page_Initialize(object sender, System.EventArgs e)
        {

           
        }

        private void PageDataGrideView_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    int rowIndex = e.RowIndex;
                    DataTable dt = (DataTable)PageDataGrideView.DataSource as DataTable;
                    DataRow row = dt.Rows[rowIndex];
                    DataTable selectedData=  mFormData.SelectedData;
                    //checkbox 勾上
                    if ((bool)PageDataGrideView.Rows[e.RowIndex].Cells[0].EditedFormattedValue == true)
                    {
                        //选中改为不选中
                        this.PageDataGrideView.Rows[e.RowIndex].Cells[0].Value = false;
                        if (!ContainDataRowInDataTable(selectedData,row,out _))
                        {
                            selectList.AddLast(row);
                            PageDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue
;
                            // TestDataGrideView.GridColor = Color.Yellow;
               
                            selectedData.ImportRow(row);
                        }

                    }
                    else
                    {
                        //不选中改为选中

                        if (ContainDataRowInDataTable(selectedData, row,out DataRow row2))
                        {
                            selectedData.Rows.Remove(row2);
                            PageDataGrideView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;                  
                        }
                        this.PageDataGrideView.Rows[e.RowIndex].Cells[0].Value = true;
                    }
                }
            }
        }
        public void SetTableData(DataTable data)
        {
            PageDataGrideView.DataSource = data;
            PageDataGrideView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }
        bool ContainDataRowInDataTable(DataTable T, DataRow R,out DataRow R2)
        {
            foreach (DataRow item in T.Rows)
            {
                if (Enumerable.SequenceEqual(item.ItemArray, R.ItemArray))
                {
                    
                    R2 = item;
                    return true;
                }
                    
            }
            R2 = T.NewRow();
            return false;
        }
    }
}