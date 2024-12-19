using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKtraWF
{
    public partial class Form1 : Form
    {

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có sản phẩm nào được chọn
            if (dataGridView1.SelectedRows.Count == 0)
            {
                // Nếu không có sản phẩm nào được chọn, vô hiệu hóa nút Lưu và Không Lưu
                SAVE.Enabled = false;
                NOTSAVE.Enabled = false;
            }
            else
            {
                // Nếu có sản phẩm được chọn, kích hoạt nút Lưu và Không Lưu
                SAVE.Enabled = true;
                NOTSAVE.Enabled = true;
            }
        }


        private void LoadSanpham()
        {
            try
            {
                using (var context = new Model1())
                {
                    var data = from sp in context.Sanphams
                               select new
                               {
                                   sp.MaSP,
                                   sp.TenSP,
                                   sp.Ngaynhap,
                                   TenLoai = sp.LoaiSP.TenLoai
                               };

                    dataGridView1.DataSource = data.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải sản phẩm: " + ex.Message);
            }
        }

        private void LoadLoaiSP()
        {
            try
            {
                using (var context = new Model1())
                {
                    var loaiSP = context.LoaiSPs.ToList();

                    comboBox1.DataSource = loaiSP;
                    comboBox1.DisplayMember = "TenLoai";
                    comboBox1.ValueMember = "MaLoai";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại sản phẩm: " + ex.Message);
            }
        }
        public class LoaiSP
        {
            [Key]
            [StringLength(2)]
            public string MaLoai { get; set; }

            [StringLength(30)]
            public string TenLoai { get; set; }

            public virtual ICollection<Sanpham> Sanphams { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void FIND_Click(object sender, EventArgs e)
        {
            string searchText = timtheotenSP.Text.Trim().ToLower(); 
            
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm!", "Thông báo");
                return;
            }

          
            using (var context = new Model1())
            {
                var filteredData = from sp in context.Sanphams
                                   where sp.TenSP.ToLower().Contains(searchText) 
                                   select new
                                   {
                                       sp.MaSP,
                                       sp.TenSP,
                                       sp.Ngaynhap,
                                       TenLoai = sp.LoaiSP.TenLoai
                                   };

                var resultList = filteredData.ToList();

                
                if (resultList.Any())
                {
                    
                    dataGridView1.DataSource = resultList;
                    MessageBox.Show("Đã tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void timtheotenSP_TextChanged(object sender, EventArgs e)
        {
            string searchText = timtheotenSP.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadSanpham(); 
            }
            else
            {
                
                using (var context = new Model1())
                {
                    var filteredData = from sp in context.Sanphams
                                       where sp.TenSP.ToLower().Contains(searchText) 
                                       select new
                                       {
                                           sp.MaSP,
                                           sp.TenSP,
                                           sp.Ngaynhap,
                                           TenLoai = sp.LoaiSP.TenLoai
                                       };

                    
                    dataGridView1.DataSource = filteredData.ToList();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
              
                var selectedRow = dataGridView1.Rows[e.RowIndex];

               
                IDsp.Text = selectedRow.Cells["MaSP"].Value.ToString(); 
                NAMEsp.Text = selectedRow.Cells["TenSP"].Value.ToString(); 
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["Ngaynhap"].Value); 

               
                var maLoai = selectedRow.Cells["TenLoai"].Value.ToString();
             

               
            }
        }

        private void IDsp_TextChanged(object sender, EventArgs e)
        {

        }

        private void NAMEsp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private List<Sanpham> tempSanphams = new List<Sanpham>();
        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
              
                var newSanpham = new Sanpham
                {
                    MaSP = IDsp.Text.Trim(),
                    TenSP = NAMEsp.Text.Trim(),
                    Ngaynhap = dateTimePicker1.Value,
                    MaLoai = comboBox1.SelectedValue.ToString()
                };

               
                tempSanphams.Add(newSanpham);

                
                dataGridView1.DataSource = tempSanphams.ToList();

                
                MessageBox.Show("Sản phẩm đã được thêm vào danh sách, nhưng chưa lưu vào cơ sở dữ liệu.", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        private void FIX_Click(object sender, EventArgs e)
        {
            try
            {
                var maSP = IDsp.Text.Trim();
                var tenSP = NAMEsp.Text.Trim();
                var ngayNhap = dateTimePicker1.Value;
                var maLoai = comboBox1.SelectedValue?.ToString();

                if (string.IsNullOrEmpty(maSP))
                {
                    MessageBox.Show("Vui lòng nhập Mã Sản Phẩm để sửa!", "Thông báo");
                    return;
                }

                using (var context = new Model1())
                {
                    var sanpham = context.Sanphams.SingleOrDefault(sp => sp.MaSP == maSP);
                    if (sanpham != null)
                    {
                        sanpham.TenSP = tenSP;
                        sanpham.Ngaynhap = ngayNhap;
                        sanpham.MaLoai = maLoai;

                        context.SaveChanges(); 

                        MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo");
                        LoadSanpham(); 
                       
                        IDsp.Clear();
                        NAMEsp.Clear();
                        dateTimePicker1.Value = DateTime.Now;
                        comboBox1.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để sửa!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa sản phẩm: " + ex.Message, "Lỗi");
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {

            // Kiểm tra nếu có sản phẩm được chọn trong DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo");
                return;
            }

            // Lấy mã sản phẩm từ dòng được chọn trong DataGridView
            var maSP = dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString();

            // Hiển thị hộp thoại xác nhận xóa
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Nếu người dùng chọn "Yes", thực hiện xóa
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new Model1())
                    {
                   
                        var sanpham = context.Sanphams.SingleOrDefault(sp => sp.MaSP == maSP);
                        if (sanpham != null)
                        {

                            context.Sanphams.Remove(sanpham);
                            context.SaveChanges(); 

                         
                            MessageBox.Show("Xóa sản phẩm thành công khỏi cơ sở dữ liệu!", "Thông báo");

                        
                            LoadSanpham();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm cần xóa trong cơ sở dữ liệu.", "Thông báo");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm trong SQL: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Hủy thao tác xóa.", "Thông báo");
            }
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    foreach (var sanpham in tempSanphams)
                    {
                        context.Sanphams.Add(sanpham);
                    }

                    context.SaveChanges();

                    MessageBox.Show("Sản phẩm đã được lưu vào cơ sở dữ liệu!", "Thông báo");

               
                    LoadSanpham();

             
                    tempSanphams.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu sản phẩm: " + ex.Message);
            }
        }

        private void NOTSAVE_Click(object sender, EventArgs e)
        {
            
            tempSanphams.Clear();

           
            LoadSanpham();

          
            MessageBox.Show("Thao tác thêm sản phẩm đã bị hủy, không lưu vào cơ sở dữ liệu.", "Thông báo");
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSanpham();
            LoadLoaiSP();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.ClearSelection();
            SAVE.Enabled = false;
            NOTSAVE.Enabled = false;

        }





    }

}
