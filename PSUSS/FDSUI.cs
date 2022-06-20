using MissionPlanner.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace PSUSS
{
    public partial class FDSUI : MyUserControl
    {
        public string path = @"C:\Users\asata\Documents\swd-repos\dummy photos";

        public FDSUI()
        {
            InitializeComponent();
        }

        private void FDSUI_Load(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(path);
            int numberOfFiles = files.Length;
            ListView listView1 = new ListView();
            listView1.Scrollable = true;
            listView1.VirtualMode = true;
            listView1.Sorting = SortOrder.Ascending;
            listView1.VirtualListSize = numberOfFiles;
            listView1.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(listView1_RetrieveVirtualItem);


            /* ListBox mylist = new ListBox();
             foreach (var image in files)
             {
                 listBox1.Items.Add(Path.GetFileName(image));
             }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

   /*     private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedImage = listBox1.SelectedItem.ToString();
            var fullPath = Path.Combine(path,selectedImage);
            pictureBox1.Image = Image.FromFile(fullPath);
            pictureBox1.Show();
        }*/
   
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }
        void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
          
        }

    }
}
