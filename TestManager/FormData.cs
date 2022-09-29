using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestManager
{
    public class FormData
    {

        public Dictionary<string, string> SeqMap {private set; get; }
        public Boolean Loop { set; get; }
        public Dictionary<string, DataTable> TableDataDic { set; get; }
        public DataTable TableData { set; get; }
        public DataTable SelectedData { set; get; }
        public int Count { set; get; }
        public bool Exit { set; get; }
        public string ExcelPath { set; get; }
        public FormData()
        {
            SeqMap = new Dictionary<string, string>
            {
                {"FCW","Prescan_Test_0001"},
                {"ICW","Prescan_Test_0002"},
                {"LTA","Prescan_Test_0003"},
                {"BSW","Prescan_Test_0004"},
                {"DNPW","Prescan_Test_0005"},
                {"EBW","Prescan_Test_0006"},
                {"AVW","Prescan_Test_0007"},
                {"CLW","Prescan_Test_0008"},
                {"HLW","Prescan_Test_0009"},
                {"SLW","Prescan_Test_0010"},
                {"RLVW","Prescan_Test_0011"},
                {"VRUCW","Prescan_Test_0012"},
                {"GLOSA","Prescan_Test_0013"},
                {"IVS","Prescan_Test_0014"},
                {"TJW","Prescan_Test_0015"},
                {"EVW","Prescan_Test_0016"},
            };

            Loop = true;
            TableData = new DataTable();
            SelectedData = new DataTable();
            TableDataDic = new Dictionary<string, DataTable>();
            Count = 0;
            Exit = false;
            ExcelPath = string.Empty;
        }

    }
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance { get { return lazy.Value; } }
        private Singleton() { }
        public FormData Data = new FormData();
    }
}
