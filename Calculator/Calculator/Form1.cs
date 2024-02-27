using Sunny.UI.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //Biến kiểm tra đã ấn nút toán tử chưa
        int toanTu;
        string pheptinh;
        bool equal = false;
        //Khởi giá trị tính toán  A ,B
        float A, B;

        //Tọa độ của textbox panel history
        int xTxt = 5, yTxt = 25;

        public Form1()
        {
            InitializeComponent();
            toanTu = 0;
            //Giới hạn chữ số
            txtResult.MaxLength = 15;

            // Tạo một danh sách để lưu trữ các số tự nhiên từ 1 đến 10
            List<int> numberList = new List<int>();
            int x = 234, y = 278;

            // Sử dụng vòng lặp để thêm các số từ 1 đến 10 vào danh sách
            for (int i = 0; i <= 9; i++)
            {
                numberList.Add(i);
            }
            // Đảo ngược danh sách
            numberList.Reverse();
            int count = 0;
            //Duyệt từng phần tử trong danh sách để thêm vào panel
            foreach (int i in numberList)
            {
                //Kiểm tra nếu là nút ở vị trí hàng ngang thứ 3 thì, tăng biến y và reset biến x và count
                if (count == 3)
                {
                    y += 70;
                    x = 234;
                    count = 0;
                }
                //Thêm button vào panel
                addButtonToPanelMenu(i, x, y, panelMenu);
                x -= 106;
                count++;
            }
        }

        //Hàm thêm button vào panel
        private void addButtonToPanelMenu(int number, int xBtn, int yBtn, Panel panel)
        {

            Button btn = new Button();
            btn.Text = number.ToString();
            btn.Name = number.ToString();
            btn.Width = 100;
            btn.Height = 60;
            btn.Location = new Point(xBtn, yBtn);
            panel.Controls.Add(btn);

            //Thêm sự kiện cho từng button
            btn.Click += (sender, e) =>
            {
                if (equal == false)
                {
                    if (txtResult.TextLength < 12)
                    {
                        txtResult.Text += btn.Text;
                    }
                }
                else
                {
                    equal = false;
                    txtResult.Clear();
                    txtResult.Text += btn.Text;
                }

            };
        }

        private void addTextBoxToPanelHistory(string Result, int xTxt, int yTxt, TabPage tabPage)
        {
            TextBox txtResult = new TextBox();
            txtResult.Text = Result;
            txtResult.Width = 230;
            txtResult.Height = 29;
            txtResult.ReadOnly = true;
            txtResult.TextAlign = HorizontalAlignment.Right;
            txtResult.Location = new Point(xTxt, yTxt);
            tabPage.Controls.Add(txtResult);
        }

        private void bttPercent_Click(object sender, EventArgs e)
        {
            //Phần trăm
            if (toanTu >= 1 && txtResult.Text != "" && txtAns.Text != "")
            {
                float a = Convert.ToSingle(txtAns.Text);
                float b = Convert.ToSingle(txtResult.Text);
                float c = Convert.ToSingle((b * a) / 100);
                txtResult.Text = Convert.ToString(c);
            }
        }

        private void bttClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtAns.Clear();
            toanTu = 0;
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtAns.Clear();
            toanTu = 0;

            //Tọa độ của textbox panel history
            int xTxt = 5, yTxt = 25;
            List<TextBox> textBoxesToRemove = tabHistory.Controls.OfType<TextBox>().ToList();

            foreach (TextBox textBox in textBoxesToRemove)
            {
                // Giải phóng tài nguyên của TextBox
                textBox.Dispose();
                // Xóa TextBox khỏi Panel
                tabHistory.Controls.Remove(textBox);
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem textBox có dữ liệu không
            if (txtResult.Text != "")
            {
                // Lấy chuỗi từ textBox
                string soBanDau = txtResult.Text;
                string soMoi;

                // Kiểm tra xem chuỗi có ít nhất 2 ký tự không (để có thể xóa ký tự cuối cùng)
                if (soBanDau.Length >= 2)
                {
                    // Kiểm tra xem ký tự cuối cùng có phải là dấu phẩy không
                    //ví dụ a[1]
                    if (soBanDau[soBanDau.Length - 2] == ',')
                    {
                        // Nếu là dấu phẩy, xóa cả ký tự số và dấu phẩy
                        soMoi = soBanDau.Substring(0, soBanDau.Length - 2);
                    }
                    else
                    {
                        // Nếu không phải là dấu phẩy, chỉ xóa ký tự cuối cùng
                        soMoi = soBanDau.Substring(0, soBanDau.Length - 1);
                    }
                    // Hiển thị chuỗi mới trong textBox
                    txtResult.Text = soMoi;
                }
                else
                {
                    // Nếu chuỗi chỉ chứa 1 ký tự, xóa hết nó
                    txtResult.Clear();
                }
            }
        }

        private void bttDivide_Click(object sender, EventArgs e)
        {
            pheptinh = "Chia";
            //Kiểm tra xem đã ấn nút toán tử lần nào chưa
            if (toanTu == 0)
            {
                if (txtResult.Text != "")
                {
                    A = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = txtResult.Text;
                    txtResult.Clear();
                    toanTu += 1;
                    return;
                }
            }
            if (toanTu == 1)
            {
                if (txtResult.Text != "")
                {
                    B = Convert.ToSingle(txtResult.Text);
                    if(B == 0)
                    {
                        return;
                    }
                    txtAns.Text = Convert.ToString(A / B);
                    string history = Convert.ToString(A) + " / " + Convert.ToString(B) + " = " + Convert.ToString(A / B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                    txtResult.Clear();
                    toanTu += 1;
                    return;
                }
            }
            if (toanTu > 1)
            {
                if (txtResult.Text != "")
                {
                    A = A = Convert.ToSingle(txtAns.Text);
                    B = Convert.ToSingle(txtResult.Text);
                    if(B == 0)
                    {
                        return;
                    }
                    txtAns.Text = Convert.ToString(A / B);
                    string history = Convert.ToString(A) + " / " + Convert.ToString(B) + " = " + Convert.ToString(A / B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                    txtResult.Clear();
                    return;
                }
            }
        }

        private void bttMultip_Click(object sender, EventArgs e)
        {
            pheptinh = "Nhân";
            //Kiểm tra xem đã ấn nút toán tử lần nào chưa
            if (toanTu == 0)
            {
                if (txtResult.Text != "")
                {
                    A = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = txtResult.Text;
                    txtResult.Clear();
                    toanTu += 1;
                    return;
                }
            }
            if (toanTu == 1)
            {
                if (txtResult.Text != "")
                {
                    B = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = Convert.ToString(A * B);
                    string history = Convert.ToString(A) + " * " + Convert.ToString(B) + " = " + Convert.ToString(A * B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                    txtResult.Clear();
                    toanTu += 1;
                    return;
                }
            }
            if (toanTu > 1)
            {
                if (txtResult.Text != "")
                {
                    A = A = Convert.ToSingle(txtAns.Text);
                    B = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = Convert.ToString(A * B);
                    string history = Convert.ToString(A) + " * " + Convert.ToString(B) + " = " + Convert.ToString(A * B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                    txtResult.Clear();
                    return;
                }
            }
        }

        private void bttMinus_Click(object sender, EventArgs e)
        {
            pheptinh = "Trừ";
            //Kiểm tra xem đã ấn nút toán tử lần nào chưa
            if (toanTu == 0)
            {
                if (txtResult.Text != "")
                {
                    A = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = txtResult.Text;
                    txtResult.Clear();
                    toanTu += 1;
                    return;
                }
            }
            if (toanTu == 1)
            {
                if (txtResult.Text != "")
                {
                    B = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = Convert.ToString(A + B);
                    string history = Convert.ToString(A) + " - " + Convert.ToString(B) + " = " + Convert.ToString(A - B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                    txtResult.Clear();
                    toanTu += 1;
                    return;
                }
            }
            if (toanTu > 1)
            {
                if (txtResult.Text != "")
                {
                    A = A = Convert.ToSingle(txtAns.Text);
                    B = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = Convert.ToString(A + B);
                    string history = Convert.ToString(A) + " - " + Convert.ToString(B) + " = " + Convert.ToString(A - B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                    txtResult.Clear();
                    return;
                }
            }
        }

        private void bttPlus_Click(object sender, EventArgs e)
        {
            pheptinh = "Cộng";
            //Kiểm tra xem đã ấn nút toán tử lần nào chưa
            if (toanTu == 0)
            {
                if (txtResult.Text != "")
                {
                    A = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = txtResult.Text;
                    txtResult.Clear();
                    toanTu += 1;
                    return;
                }
            }
            if (toanTu == 1)
            {
                if (txtResult.Text != "")
                {
                    B = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = Convert.ToString(A + B);
                    string history = Convert.ToString(A) + " + " + Convert.ToString(B) + " = " + Convert.ToString(A + B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                    txtResult.Clear();
                    toanTu += 1;
                    return;
                }
            }
            if (toanTu > 1)
            {
                if (txtResult.Text != "")
                {
                    A = Convert.ToSingle(txtAns.Text);
                    B = Convert.ToSingle(txtResult.Text);
                    txtAns.Text = Convert.ToString(A + B);
                    string history = Convert.ToString(A) + " + " + Convert.ToString(B) + " = " + Convert.ToString(A + B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                    txtResult.Clear();
                    return;
                }
            }
        }

        private void bttFraction_Click(object sender, EventArgs e)
        {
            //Phân số với tử là 1
            if (txtResult.Text != "")
            {
                float a = Convert.ToSingle(txtResult.Text);
                if(a == 0)
                {
                    return;
                }
                txtResult.Text = Convert.ToString(1 / a);
            }
        }

        private void bttSquare_Click(object sender, EventArgs e)
        {
            //Mũ 2
            if (txtResult.Text != "")
            {
                float a = Convert.ToSingle(txtResult.Text);
                double b = Math.Pow(Convert.ToDouble(a), 2);
                txtResult.Text = Convert.ToString(b);
                string history = Convert.ToString(a) + " ^ 2 = " + Convert.ToString(b);
                addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                yTxt += 35;
                equal = true;
            }

        }

        private void bttSquareRoot_Click(object sender, EventArgs e)
        {
            //Căn bậc 2
            if (txtResult.Text != "")
            {
                float a = Convert.ToSingle(txtResult.Text);
                if (a < 0)
                {
                    return;
                }
                double b = Math.Sqrt(Convert.ToDouble(a));
                txtResult.Text = Convert.ToString(b);
                string history = "√(" + Convert.ToString(a) + ") = " + Convert.ToString(b);
                addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                yTxt += 35;
                equal = true;
            }
        }

        private void bttConvert_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                float a = Convert.ToSingle(txtResult.Text);
                a = -a;
                txtResult.Text = a.ToString();
            }
        }

        private void bttPoint_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains(","))
            {
                return;
            }
            else
            {
                if (txtResult.Text == "")
                {
                    txtResult.Text = "0.";
                }
                else
                {
                    txtResult.Text += ".";
                }
            }
        }

        private void bttEqual_Click(object sender, EventArgs e)
        {
            equal = true;
            //NaN = Not a Number
            //!float.IsNaN(A) được sử dụng để kiểm tra xem A đã được gán giá trị hay không. Nếu A không phải là NaN, điều kiện này sẽ đúng.
            if (!float.IsNaN(A) && toanTu != 0 && txtResult.Text != "")
            {
                A = Convert.ToSingle(txtAns.Text);
                B = Convert.ToSingle(txtResult.Text);
                if (pheptinh == "Cộng")
                {
                    txtResult.Text = Convert.ToString(A + B);
                    string history = Convert.ToString(A) + " + " + Convert.ToString(B) + " = " + Convert.ToString(A + B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                }
                else if (pheptinh == "Trừ")
                {
                    txtResult.Text = Convert.ToString(A - B);
                    string history = Convert.ToString(A) + " - " + Convert.ToString(B) + " = " + Convert.ToString(A - B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                }
                else if (pheptinh == "Nhân")
                {
                    txtResult.Text = Convert.ToString(A * B);
                    string history = Convert.ToString(A) + " * " + Convert.ToString(B) + " = " + Convert.ToString(A * B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                }
                else if (pheptinh == "Chia")
                {
                    if(B == 0)
                    {
                        return;
                    }
                    txtResult.Text = Convert.ToString(A / B);
                    string history = Convert.ToString(A) + " / " + Convert.ToString(B) + " = " + Convert.ToString(A / B);
                    addTextBoxToPanelHistory(history, xTxt, yTxt, tabHistory);
                    yTxt += 35;
                }
            }
            toanTu = 0;
            txtAns.Clear();
        }


    }
}
