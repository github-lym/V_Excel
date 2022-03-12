using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.Streaming;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_Excel
{
    public partial class Form1 : Form
    {
        private List<string> excelPath;
        private IniManager iniManager;
        private string[] 分類1s;
        private string[] 分類2s;
        private string[] 樣態大屬性s;
        private string[] 品項s;

        private string[] Excel標題 = new string[] { "主鍵值", "分類1", "分類2", "樣態(大屬性)", "樣態(小屬性)", "新聞標題", "新聞內容", "發布機關", "主辦機關", "協辦機關", "通報機關", "關鍵字1", "關鍵字2", "關鍵字3", "品名", "下游", "上游", "廠商", "法條", "處置", "品項", "符合標準(Y/N)", "事件", "整理日期" };
        //private int SEQ = -1, 分類1 = -1, 分類2 = -1, 樣態大屬性 = -1, 樣態小屬性 = -1, 新聞內容 = -1, 發布機關 = -1, 協辦機關 = -1, 通報機關 = -1, 關鍵字1 = -1, 關鍵字2 = -1, 關鍵字3 = -1, 品名 = -1, 下游 = -1, 上游 = -1, 廠商 = -1, 法條 = -1, 處置 = -1, 品項 = -1, 符合標準 = -1, 新聞標題 = -1, 整理日期 = -1;

        private Dictionary<string, int> titleDict = new Dictionary<string, int>();
        private List<string> listNew = new List<string>();

        private IWorkbook workbook;
        private ISheet sheet;
        private IFormulaEvaluator formulaEvaluator;
        //private Dictionary<string, int> seqDic = new Dictionary<string, int>();

        public Form1()
        {
            string path = System.Windows.Forms.Application.StartupPath;
            excelPath = Directory.EnumerateFiles(path).Where(file => file.ToLower().EndsWith("xls") || file.ToLower().EndsWith("xlsx")).ToList();

            for (int i = 0; i < Excel標題.Length; i++)
                titleDict.Add(Excel標題[i], -1);

            if (excelPath.Count != 1)
            {
                MessageBox.Show("目錄底下需有/僅能有一個Excel檔案");
                Environment.Exit(0);
            }
            else
            {
                InitializeComponent();

                iniManager = new IniManager(Path.Combine(path, "setting.ini"));
                分類1s = iniManager.ReadIniFile("下拉選單", "分類1", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                分類2s = iniManager.ReadIniFile("下拉選單", "分類2", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                樣態大屬性s = iniManager.ReadIniFile("下拉選單", "樣態大屬性", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                品項s = iniManager.ReadIniFile("下拉選單", "品項", "").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                SET_UI();
                ReadExcel(excelPath[0]);
            }
        }

        public void SET_UI()
        {
            foreach (string 分類1 in 分類1s)
                CBO_分類1.Items.Add(分類1);

            foreach (string 分類2 in 分類2s)
                CBO_分類2.Items.Add(分類2);

            foreach (string 樣態大屬性 in 樣態大屬性s)
                CBO_樣態大屬性.Items.Add(樣態大屬性);

            foreach (string 品項 in 品項s)
                CBO_品項.Items.Add(品項);
        }

        private void CBO_樣態大屬性_CHANGE(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CBO_樣態大屬性.Text))
            {
                CBO_樣態小屬性.Items.Clear();
                CBO_樣態小屬性.Text = string.Empty;
                return;
            }

            CBO_樣態小屬性.Items.Clear();
            CBO_樣態小屬性.Text = string.Empty;
            string selectedItem = CBO_樣態大屬性.Text;
            string[] 樣態小屬性s = iniManager.ReadIniFile("樣態", selectedItem, "").Split(',');
            foreach (string 樣態小屬性 in 樣態小屬性s)
                CBO_樣態小屬性.Items.Add(樣態小屬性);
        }

        private void CBO_品項_TEXTUPDATE(object sender, EventArgs e)
        {
            CBO_品項.Items.Clear();
            listNew.Clear();

            foreach (var item in 品項s)
            {
                if (item.Contains(this.CBO_品項.Text))
                {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
            }

            //combobox添加已经查到的关键词
            this.CBO_品項.Items.AddRange(listNew.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            this.CBO_品項.SelectionStart = this.CBO_品項.Text.Length;
            //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            Cursor = Cursors.Default;
            //自动弹出下拉框
            this.CBO_品項.DroppedDown = true;
        }

        private void CBO_樣態小屬性_TEXTUPDATE(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CBO_樣態大屬性.Text))
            {
                CBO_樣態小屬性.Items.Clear();
                CBO_樣態小屬性.Text = string.Empty;
                return;
            }

            CBO_樣態小屬性.Items.Clear();
            listNew.Clear();

            if (樣態大屬性s.Contains(CBO_樣態大屬性.Text))
            {
                string[] 樣態小屬性s = iniManager.ReadIniFile("樣態", CBO_樣態大屬性.Text, "").Split(',');

                foreach (var item in 樣態小屬性s)
                {
                    if (item.Contains(this.CBO_樣態小屬性.Text))
                    {
                        //符合，插入ListNew
                        listNew.Add(item);
                    }
                }

                //combobox添加已经查到的关键词
                this.CBO_樣態小屬性.Items.AddRange(listNew.ToArray());
                //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
                this.CBO_樣態小屬性.SelectionStart = this.CBO_樣態小屬性.Text.Length;
                //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
                Cursor = Cursors.Default;
                //自动弹出下拉框
                this.CBO_樣態小屬性.DroppedDown = true;
            }
        }

        private void ReadExcel(string filePath)
        {
            using (FileStream filex = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                if (Path.GetExtension(filePath) == ".xls")
                {   // xls
                    workbook = new HSSFWorkbook(filex);
                    formulaEvaluator = new HSSFFormulaEvaluator(workbook); // Important!! 取公式值的時候會用到
                }
                else if (Path.GetExtension(filePath) == ".xlsx")
                {   // xlsx
                    workbook = new XSSFWorkbook(filex);
                    formulaEvaluator = new XSSFFormulaEvaluator(workbook); // Important!! 取公式值的時候會用到
                }
                else
                {
                    MessageBox.Show("檔案格式錯誤");
                }
            }
            sheet = workbook.GetSheetAt(0);
            var row = sheet.GetRow(0);

            for (int c = 0; c < row.Count(); c++)
            {
                var cell = row.GetCell(c);
                for (int i = 0; i < titleDict.Count; i++)
                {
                    string key = ExcelCellValue(cell);
                    if (titleDict.ContainsKey(key))
                    {
                        titleDict[key] = c;
                        continue;
                    }
                }
            }

            string errTitle = string.Empty;
            foreach (var item in titleDict)
            {
                if (item.Value == -1)
                {
                    errTitle += $" {item.Key} ";
                }
            }
            if (!string.IsNullOrEmpty(errTitle))
            {
                MessageBox.Show($"Excel欄位尚缺 {errTitle}");
                Environment.Exit(0);
            }
            //for (int i = 1; i <= sheet.LastRowNum; i++)
            //{
            //    seqDic.Add(ExcelCellValue(sheet.GetRow(i).GetCell(titleDict["主鍵值"])), i + 1);
            //}
        }

        private string ExcelCellValue(ICell cell)
        {

            string columnStr = string.Empty;
            if (cell != null)
            {
                switch (cell.CellType)
                {
                    case CellType.Numeric:  // 數值格式
                        if (DateUtil.IsCellDateFormatted(cell))
                        {   // 日期格式
                            columnStr = cell.DateCellValue.ToString();
                        }
                        else
                        {   // 數值格式
                            columnStr = cell.NumericCellValue.ToString();
                        }
                        break;

                    case CellType.String:   // 字串格式
                        columnStr = cell.StringCellValue;
                        break;

                    case CellType.Formula:  // 公式格式
                        var formulaValue = formulaEvaluator.Evaluate(cell);
                        if (formulaValue.CellType == CellType.String) columnStr = formulaValue.StringValue.ToString();          // 執行公式後的值為字串型態
                        else if (formulaValue.CellType == CellType.Numeric) columnStr = formulaValue.NumberValue.ToString();    // 執行公式後的值為數字型態
                        break;

                    default:
                        break;
                }
            }

            return columnStr;
        }

        private void BTN_QUERY_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(TB_SEQ.Text))
            {
                MessageBox.Show("SEQ不得為空啦幹!!");
                return;
            }

            string seq = TB_SEQ.Text;
            BTN_CLEAR_Click(null, null);
            TB_SEQ.Text = seq;
            int intSeq = -1;
            int.TryParse(seq, out intSeq);
            IRow row = sheet.GetRow(intSeq);

            if (row != null)
            {
                LABEL_MSG.Text = $"{seq} : QUERY SUCCESS!!";
                CBO_分類1.Text = ExcelCellValue(row.GetCell(titleDict["分類1"]));
                CBO_分類2.Text = ExcelCellValue(row.GetCell(titleDict["分類2"]));
                CBO_樣態大屬性.Text = ExcelCellValue(row.GetCell(titleDict["樣態(大屬性)"]));
                CBO_樣態小屬性.Text = ExcelCellValue(row.GetCell(titleDict["樣態(小屬性)"]));
                TB_新聞標題.Text = ExcelCellValue(row.GetCell(titleDict["新聞標題"]));
                TB_新聞內容.Text = ExcelCellValue(row.GetCell(titleDict["新聞內容"]));
                TB_關鍵字1.Text = ExcelCellValue(row.GetCell(titleDict["關鍵字1"]));
                TB_關鍵字2.Text = ExcelCellValue(row.GetCell(titleDict["關鍵字2"]));
                TB_關鍵字3.Text = ExcelCellValue(row.GetCell(titleDict["關鍵字3"]));
                CBO_品項.Text = ExcelCellValue(row.GetCell(titleDict["品項"]));
                TB_品名.Text = ExcelCellValue(row.GetCell(titleDict["品名"]));
                TB_發布機關.Text = ExcelCellValue(row.GetCell(titleDict["發布機關"]));
                TB_主辦機關.Text = ExcelCellValue(row.GetCell(titleDict["主辦機關"]));
                TB_協辦機關.Text = ExcelCellValue(row.GetCell(titleDict["協辦機關"]));
                TB_通報機關.Text = ExcelCellValue(row.GetCell(titleDict["通報機關"]));
                CBO_符合標準.Text = ExcelCellValue(row.GetCell(titleDict["符合標準(Y/N)"]));
                TB_廠商.Text = ExcelCellValue(row.GetCell(titleDict["廠商"]));
                TB_上游.Text = ExcelCellValue(row.GetCell(titleDict["上游"]));
                TB_下游.Text = ExcelCellValue(row.GetCell(titleDict["下游"]));
                TB_處置.Text = ExcelCellValue(row.GetCell(titleDict["處置"]));
                TB_法條.Text = ExcelCellValue(row.GetCell(titleDict["法條"]));
                TB_主鍵值.Text = ExcelCellValue(row.GetCell(titleDict["主鍵值"]));
                TB_事件.Text = ExcelCellValue(row.GetCell(titleDict["事件"]));
            }
            else
                LABEL_MSG.Text = $"{seq} : NO DATA!!";
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            LABEL_MSG.Text = "CLEAR!!";
            TB_SEQ.Text = string.Empty;
            CBO_分類1.SelectedIndex = -1;
            CBO_分類2.SelectedIndex = -1;
            CBO_樣態大屬性.SelectedIndex = -1;
            CBO_樣態小屬性.Items.Clear();
            TB_新聞內容.Text = string.Empty;
            TB_新聞標題.Text = string.Empty;

            TB_關鍵字1.Text = string.Empty;
            TB_關鍵字2.Text = string.Empty;
            TB_關鍵字3.Text = string.Empty;
            CBO_品項.Text = string.Empty;
            TB_品名.Text = string.Empty;
            TB_發布機關.Text = string.Empty;
            TB_主辦機關.Text = string.Empty;
            TB_協辦機關.Text = string.Empty;
            TB_通報機關.Text = string.Empty;

            CBO_符合標準.Text = string.Empty;

            TB_廠商.Text = string.Empty;
            TB_上游.Text = string.Empty;
            TB_下游.Text = string.Empty;

            TB_處置.Text = string.Empty;
            TB_法條.Text = string.Empty;
            TB_主鍵值.Text = string.Empty;
            TB_事件.Text = string.Empty;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int seq = 1;
            if (keyData == Keys.Up)
            {
                if (!string.Empty.Equals(TB_SEQ.Text))
                {
                    int.TryParse(TB_SEQ.Text, out seq);
                    seq--;
                    if (seq < 1)
                        seq = 1;
                    BTN_CLEAR_Click(null, null);
                    TB_SEQ.Text = seq.ToString();
                    BTN_QUERY_Click(null, null);
                    return true;
                }
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                if (!string.Empty.Equals(TB_SEQ.Text))
                {
                    int.TryParse(TB_SEQ.Text, out seq);
                    seq++;
                    BTN_CLEAR_Click(null, null);
                    TB_SEQ.Text = seq.ToString();
                    BTN_QUERY_Click(null, null);
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(TB_SEQ.Text))
            {
                MessageBox.Show("SEQ不得為空啦幹!!");
                return;
            }

            string seq = TB_SEQ.Text;
            int.TryParse(seq, out int intSeq);
            IRow row = sheet.GetRow(intSeq);

            if (row != null && row.GetCell(titleDict["主鍵值"]) != null)
            {
                ICell cellEdit;

                cellEdit = row.GetCell(titleDict["分類1"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["分類1"]);
                row.GetCell(titleDict["分類1"]).SetCellValue(CBO_分類1.Text);

                cellEdit = row.GetCell(titleDict["分類2"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["分類2"]);
                row.GetCell(titleDict["分類2"]).SetCellValue(CBO_分類2.Text);

                cellEdit = row.GetCell(titleDict["樣態(大屬性)"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["樣態(大屬性)"]);
                row.GetCell(titleDict["樣態(大屬性)"]).SetCellValue(CBO_樣態大屬性.Text);

                cellEdit = row.GetCell(titleDict["樣態(小屬性)"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["樣態(小屬性)"]);
                row.GetCell(titleDict["樣態(小屬性)"]).SetCellValue(CBO_樣態小屬性.Text);

                cellEdit = row.GetCell(titleDict["關鍵字1"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["關鍵字1"]);
                row.GetCell(titleDict["關鍵字1"]).SetCellValue(TB_關鍵字1.Text);

                cellEdit = row.GetCell(titleDict["關鍵字2"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["關鍵字2"]);
                row.GetCell(titleDict["關鍵字2"]).SetCellValue(TB_關鍵字2.Text);

                cellEdit = row.GetCell(titleDict["關鍵字3"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["關鍵字3"]);
                row.GetCell(titleDict["關鍵字3"]).SetCellValue(TB_關鍵字3.Text);

                cellEdit = row.GetCell(titleDict["品項"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["品項"]);
                row.GetCell(titleDict["品項"]).SetCellValue(CBO_品項.Text);

                cellEdit = row.GetCell(titleDict["品名"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["品名"]);
                row.GetCell(titleDict["品名"]).SetCellValue(TB_品名.Text);

                cellEdit = row.GetCell(titleDict["發布機關"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["發布機關"]);
                row.GetCell(titleDict["發布機關"]).SetCellValue(TB_發布機關.Text);

                cellEdit = row.GetCell(titleDict["主辦機關"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["主辦機關"]);
                row.GetCell(titleDict["主辦機關"]).SetCellValue(TB_主辦機關.Text);

                cellEdit = row.GetCell(titleDict["協辦機關"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["協辦機關"]);
                row.GetCell(titleDict["協辦機關"]).SetCellValue(TB_協辦機關.Text);

                cellEdit = row.GetCell(titleDict["通報機關"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["通報機關"]);
                row.GetCell(titleDict["通報機關"]).SetCellValue(TB_通報機關.Text);

                cellEdit = row.GetCell(titleDict["符合標準(Y/N)"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["符合標準(Y/N)"]);
                row.GetCell(titleDict["符合標準(Y/N)"]).SetCellValue(CBO_符合標準.Text);

                cellEdit = row.GetCell(titleDict["廠商"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["廠商"]);
                row.GetCell(titleDict["廠商"]).SetCellValue(TB_廠商.Text);

                cellEdit = row.GetCell(titleDict["上游"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["上游"]);
                row.GetCell(titleDict["上游"]).SetCellValue(TB_上游.Text);

                cellEdit = row.GetCell(titleDict["下游"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["下游"]);
                row.GetCell(titleDict["下游"]).SetCellValue(TB_下游.Text);

                cellEdit = row.GetCell(titleDict["處置"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["處置"]);
                row.GetCell(titleDict["處置"]).SetCellValue(TB_處置.Text);

                cellEdit = row.GetCell(titleDict["法條"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["法條"]);
                row.GetCell(titleDict["法條"]).SetCellValue(TB_法條.Text);

                cellEdit = row.GetCell(titleDict["事件"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["事件"]);
                row.GetCell(titleDict["事件"]).SetCellValue(TB_事件.Text);

                cellEdit = row.GetCell(titleDict["整理日期"]);
                if (cellEdit == null)
                    row.CreateCell(titleDict["整理日期"]);
                row.GetCell(titleDict["整理日期"]).SetCellValue($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");

                using (FileStream filex = new FileStream(excelPath[0], FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(filex);
                    LABEL_MSG.Text = $"{TB_SEQ.Text} : UPDATE SUCCESS!!";
                }
            }
            else
                LABEL_MSG.Text = $"{seq} : UPDATE ERROR!!";
        }
    }
}