using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_6
{
    public partial class HashTBL : Form
    {
        ClassHash<string> Table = new ClassHash<string>();
        public HashTBL()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //Table.Addition(Convert.ToInt32(keyenteradd.Text), valenteradd.Text);// добавить элемент типа HashNode<string>?
            hashelem.Items.Add(Table.HashFunc(Convert.ToInt32(keyenteradd.Text)) + "   " + keyenteradd.Text + "   " + valenteradd.Text);
        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            findres.Items.Add(findres.Items.Add(Table.Find(Convert.ToInt32(keyenterfind.Text))));
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            Table.Deletion(Convert.ToInt32(keyenterdel.Text));
        }
    }
}
