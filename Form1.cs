using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btapBuoi2
{
    public partial class listview : Form
    {
        public listview()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem(txtLastName.Text);
            it.SubItems.Add(txtFirstName.Text);
            it.SubItems.Add(txtPhone.Text);
            lvStudent.Items.Add(it);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                ListViewItem item = lvStudent.SelectedItems[0];
                item.SubItems[0].Text = txtLastName.Text;
                item.SubItems[1].Text = txtFirstName.Text;
                item.SubItems[2].Text = txtPhone.Text;

            }
            else
            {
                MessageBox.Show("Chọn tên bạn muốn sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                lvStudent.Items.RemoveAt(lvStudent.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Chọn tên bạn muốn xóa!");
            }
        }
    }
}
