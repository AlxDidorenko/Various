using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class Workspace : Form
    {
        ClassHash Table = new ClassHash();
       
        public Workspace()
        {
            InitializeComponent();
            Table.Load();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                HashNode kv = new HashNode();
                kv.key = Convert.ToInt32(keybox.Text);
                kv.value = valuebox.Text;
                Table.Addition(kv);
                ShowNum();
            }
            catch
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(findbutton, "Искать только по ключу!");
            try
            {
                HashNode kv = Table.Find(Convert.ToInt32(keybox.Text));
                foundedkey.Text = kv.key.ToString();
                foundedfalue.Text = kv.value;
            }
            catch
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Table.Deletion(Convert.ToInt32(keybox.Text));
                ShowNum();
            }
            catch
            {
                MessageBox.Show("Введите данные!");
            }
        }

        public void ShowNum()
        {
            string s = "";
            List<HashNode>[] arr = Table.Retarray();
            shownumofelements.Items.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                s = arr[i].ToString();
                shownumofelements.Items.Add(s);
            }
        }
    }
}
