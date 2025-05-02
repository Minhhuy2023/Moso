using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Moso
{
    public partial class Form1 : Form
    {
        int mouseX;
        int mouseY;  // biến toàn cục
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView1 ();
            dataGridView1.DataSource =steplist; // liên kết dữ liệu với datagridview khi formload

            //timer lấy tọa độ chuột liên tục
            timer1 = new Timer ();
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            timer1 .Start (); 
            //
        }
        BindingList<StepData> steplist = new BindingList<StepData>();
        //khai báo danh sách toàn cục bingding class stepdata & steplist hiển thị lên datagridview1
        private void InitializeDataGridView1()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersWidth = 20; // Cài độ rộng của cột heatders là 10
            
        }



        private void btDel_Click(object sender, EventArgs e)
        {
            //rtbStatus.Text = (" Xóa Thành Công ---");
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.IsNewRow)  // Dòng mới chưa được commit
                    {
                        rtbStatus.Text = (" Dòng Bạn Chọn Không Có Dữ Liệu");
                        return;
                    }
                    else
                    {
                        rtbStatus.Text = (" Xóa Thành Công ");
                        
                    }

                    // Xóa dòng đã được commit
                    
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            else 
            {
                rtbStatus.Text = (" Hãy Chọn Một Dòng muốn xóa");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StepData stepData = new StepData();
                {
                    stepData.No = 0;
                    stepData.Pos_X = mouseX;
                    stepData.Pos_Y = mouseY;
                    stepData.Click_Mode = "RLC";
                    stepData.Delay = 1000;
                    rtbStatus.Text = ("Thêm Bước \r Add Step");
                }
                steplist.Add(stepData);  //binding dữ liệu

            }
            catch (Exception ex)
            {
                rtbStatus.Text += ex.ToString();

            }
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            rtbStatus.Text = (" Đang Chạy ...");
        }

        private void rtbStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            mouseX = Cursor.Position.X;
            mouseY = Cursor.Position.Y;
            lbMousePos.ForeColor = Color.BlueViolet;
            lbMousePos.Text = ("Mouse Posision:\r\n" +mouseX.ToString() + "x" + mouseY.ToString());
        }
    }

    public class StepData              // khai báo các thành phần trong lớp StepData trong bảng dữ liệu view1
    {
        public int No { get; set; }
        public int Pos_X { get; set; }
        public int Pos_Y { get; set; }
        public string Click_Mode { get; set; }
        public int Delay { get; set; }
    }
}

