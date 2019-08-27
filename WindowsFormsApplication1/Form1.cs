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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
           
           
        }

       
 private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string a = name.Text;
            string b = fatherName.Text;
  
            Double d = Convert.ToDouble(phoneNumber.Text);
            string c = textBox7.Text;
          
            string h = comboBox1.Text;
            double z = Convert.ToDouble(textBox6.Text);
           
            StreamWriter save = new StreamWriter("addmission form");
            save.WriteLine(a);
            save.WriteLine(b);
            Boolean isMale = radioButton1.Checked;
             if (isMale == true)save.WriteLine("male ");
             Boolean isFemale = radioButton2.Checked;
            if (isFemale == true) save.WriteLine("female ");
           
            save.WriteLine(c);
            save.WriteLine(d);
            save.WriteLine(h);
            save.WriteLine(z);
            save.Close();
            
           
           
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
