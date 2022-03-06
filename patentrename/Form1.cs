using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace patentrename
{
    public partial class Form1 : Form
    {
        string source_path = "";
        string destination_path = "";
        int mDelay = 1000;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string default_str = @"";
            
            if (source_path.Equals(""))
            {
                MessageBox.Show("Please select source folder");
                return;
            }

            if (destination_path.Equals(""))
            {
                MessageBox.Show("Please select destination folder");
                return;
            }

            source_path = default_str + source_path;
            destination_path = default_str + destination_path;

            DirectoryInfo sourcePathInfo = new DirectoryInfo(source_path);
            FileInfo[] source_file_list = sourcePathInfo.GetFiles();

            foreach (FileInfo source_file in source_file_list)
            {
                string file_source_path = source_file.FullName;
                string file_extension = source_file.Extension;

                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(source_file.FullName);
                string file_des_path = destination_path + "\\" +  fileNameWithoutExt + "__p" + source_file.Extension;

                if (file_extension == ".xlsx" || file_extension == ".xls")
                {
                    processingStatusLb.Text = file_source_path + " ---> " + file_des_path;
                    convertExcel(file_source_path, file_des_path);
                }
            }

            MessageBox.Show("The Work Done");
        }

        public void convertExcel(string file_source_path, string file_des_path)
        {
            //read source file----------------
            FileStream r_source_filestream = File.Open(file_source_path, FileMode.Open, FileAccess.Read);

            // ExcelDataReader nuget package to read excel
            IExcelDataReader excelReader = ExcelReaderFactory.CreateReader(r_source_filestream);
            DataSet result = excelReader.AsDataSet();

            //destination new file-------------
            var w_des_filestream = new FileStream(file_des_path, FileMode.Create, FileAccess.Write);

            // NPOI nuget package to write excel
            IWorkbook workbook;
            workbook = new XSSFWorkbook();
            ISheet excelSheet = workbook.CreateSheet("ResultSet");

            int row_index = 0;
            while (excelReader.Read())
            {
                IRow row = excelSheet.CreateRow(row_index);
                bool check_field_haneng = true;

                // tempRowList is 
                // when any field sentence contain korean string, this all field, row has to removed
                List<string> tempRowList = new List<string>();

                for (int field_index = 0; field_index < excelReader.FieldCount; field_index++)
                {
                    string sentence = "";
                    if (excelReader.GetString(field_index) != null)
                        sentence = excelReader.GetString(field_index);
                    if (!check_HanEng_korean(sentence))
                    {
                        tempRowList.Add(sentence);
                    }
                    else
                    {
                        check_field_haneng = false;
                    }
                }

                //check row status for korean string
                if (check_field_haneng)
                {
                    int field_index = 0;
                    foreach (string tempRow in tempRowList)
                    {
                        row.CreateCell(field_index).SetCellValue(tempRow);
                        field_index++;
                    }
                    row_index++;
                }
            }
            workbook.Write(w_des_filestream);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //source folder browser ----------- < 
        private void directoryPathBt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
                source_path = fbd.SelectedPath;
            else
                source_path = string.Empty;
            sourcePathTb.Text = source_path;
        }
        //source folder browser ----------- < 

        public bool check_HanEng_korean(string sentence)
        {
            bool encoding = false;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (isKor(sentence[i]) == true)
                {
                    encoding = true;
                }
            }

            if (sentence.Contains("KOREA"))
                encoding = true;

            return encoding;
        }

        //check containing korean string----------- < 
        public bool isKor(char ch)
        {
            if ((0xAC00 <= ch && ch <= 0xD7A3) || (0x3131 <= ch && ch <= 0x318E))
                return true;
            else
                return false;
        }
        //check containing korean string----------- >


        //destination folder browser ----------- < 
        private void desBrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
                destination_path = fbd.SelectedPath;
            else
                destination_path = string.Empty;
            destinationPathTb.Text = destination_path;
        }
        //destination folder browser ----------- < 
    }
}
