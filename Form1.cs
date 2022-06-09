using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppX2
{
    public partial class Form1 : Form
    {
        //private string Text2; //will be used later for checking changes
        private bool isChanged;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog() { Filter = "Text Files (*.txt)|*.txt| Batch Files (*.bat)|*.bat| Command Files (*.cmd)|*.cmd| All Files (*.*)|*.*" };
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(save.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
                

            }
            else
            {

            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog open = new OpenFileDialog() { Filter = "Text Files (*.txt)|*.txt| Batch Files (*.bat)|*.bat| Command Files (*.cmd)|*.cmd| All Files (*.*)|*.*" };
            if (open.ShowDialog() == DialogResult.OK)
            {
               System.IO.StreamReader reader = new System.IO.StreamReader(open.FileName);
                string i = reader.ReadToEnd();
                richTextBox1.Text = i;

            }
            else
            {

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
                        

            SaveFileDialog save = new SaveFileDialog() { Filter = "Text Files (*.txt)|*.txt| Batch Files (*.bat)|*.bat| Command Files (*.cmd)|*.cmd| All Files (*.*)|*.*" };
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(save.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();


            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.Font = font.Font;
                
            }
            else { }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new About();
            x.ShowDialog();
            
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if(isChanged)
            {
                DialogResult dialog = MessageBox.Show("Do you want to save this file?", "Save File", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    if(save.ShowDialog()==DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(save.FileName, richTextBox1.Text);
                        richTextBox1.Text = "";
                    }
                    
                    
                    else { }



                }
              else if (dialog == DialogResult.No)
                {
                richTextBox1.Text = "";
                   


                    



                }
                 else if (dialog == DialogResult.Cancel) { }
               

            }

           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
            //Text2 = richTextBox1.Text; //will be used later for checking changes

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            var x = new About();
            x.ShowDialog();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "Text Files (*.txt)|*.txt| Batch Files (*.bat)|*.bat| Command Files (*.cmd)|*.cmd| All Files (*.*)|*.*" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(open.FileName);
                string i = reader.ReadToEnd();
                richTextBox1.Text = i;

            }
            else
            {

            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog() { Filter = "Text Files (*.txt)|*.txt| Batch Files (*.bat)|*.bat| Command Files (*.cmd)|*.cmd| All Files (*.*)|*.*" };
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(save.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();


            }
            else
            {

            }
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
    }
}
