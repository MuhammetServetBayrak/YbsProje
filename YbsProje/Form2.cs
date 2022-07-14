using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YbsProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // form yüklenirken koltuk no'larını gösteren buttonların kırmızı olması için gerekli komutlar.

            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
            button10.BackColor = Color.Red;
            button11.BackColor = Color.Red;
            button12.BackColor = Color.Red;
            button13.BackColor = Color.Red;
            button14.BackColor = Color.Red;
            button15.BackColor = Color.Red;
            button16.BackColor = Color.Red;
            button17.BackColor = Color.Red;
            button18.BackColor = Color.Red;
            button19.BackColor = Color.Red;
            button20.BackColor = Color.Red;
            button21.BackColor = Color.Red;
            button22.BackColor = Color.Red;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

            //textBoxlara girilen değerlerin kontrolünü sağlayan komutlar.

            int tc = textBox3.TextLength;
            int tel = textBox4.TextLength;

            if (textBox1.Text=="")
            {
                MessageBox.Show("Adınızı giriniz!");
                
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Soyadınızı giriniz!");
                
            }
            else if (tc > 11)
            {
                MessageBox.Show("TC Kimlik No 11 karakter olmalı!");
            }
            else if (textBox3.Text=="")
            {
                MessageBox.Show("TC Kimlik No giriniz!");
        
            }
            else if (tel>11)
            {
                MessageBox.Show("Telefon No 11 karakter olmalı!");
            }
            else if (textBox4.Text=="")
            {
                MessageBox.Show("Telefon No sunu giriniz!");
                
            }
            else if (textBox5.Text=="")
            {
                MessageBox.Show("Koltuk NO sunu giriniz!");
                
            }
            else if (listBox8.Text=="")
            {
                MessageBox.Show("Kalkış noktası seçiniz!");
                
            }
            else if (listBox9.Text=="")
            {
                MessageBox.Show("Varış noktasını seçiniz");
                
            }
            else if (listBox10.Text=="")
            {
                MessageBox.Show("Firma seçiniz!");
                
            }

            //eğer üstteki koşullar içine girmez ise else komutu ile listboxlara ekleme işlemi için komutlar.

            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(textBox2.Text);
                listBox3.Items.Add(textBox3.Text);
                listBox4.Items.Add(textBox4.Text);
                listBox5.Items.Add(textBox5.Text);

                listBox6.Items.Add(listBox8.Text + "-->" + listBox9.Text);
                listBox7.Items.Add(listBox10.Text);

                listBox11.Items.Add(dateTimePicker1.Text);
            }

            
            // seçilen butonun bilet al'a tıkladıkdan sonra yeşile dönemesini sağlayan komutlar.

            if (button1.Text==textBox5.Text)
            {
                button1.BackColor = Color.Green;
            }

            if (button2.Text == textBox5.Text)
            {
                button2.BackColor = Color.Green;
            }

            if (button3.Text == textBox5.Text)
            {
                button3.BackColor = Color.Green;
            }

            if (button4.Text == textBox5.Text)
            {
                button4.BackColor = Color.Green;
            }

            if (button5.Text == textBox5.Text)
            {
                button5.BackColor = Color.Green;
            }

            if (button6.Text == textBox5.Text)
            {
                button6.BackColor = Color.Green;
            }

            if (button7.Text == textBox5.Text)
            {
                button7.BackColor = Color.Green;
            }

            if (button8.Text == textBox5.Text)
            {
                button8.BackColor = Color.Green;
            }
            
            if (button9.Text == textBox5.Text)
            {
                button9.BackColor = Color.Green;
            }

            if (button10.Text == textBox5.Text)
            {
                button10.BackColor = Color.Green;
            }
            
            if (button11.Text == textBox5.Text)
            {
                button11.BackColor = Color.Green;
            }
            
            if (button12.Text == textBox5.Text)
            {
                button12.BackColor = Color.Green;
            }
            
            if (button13.Text == textBox5.Text)
            {
                button13.BackColor = Color.Green;
            }
            
            if (button14.Text == textBox5.Text)
            {
                button14.BackColor = Color.Green;
            }
            
            if (button15.Text == textBox5.Text)
            {
                button15.BackColor = Color.Green;
            }

            if (button16.Text == textBox5.Text)
            {
                button16.BackColor = Color.Green;
            }

            if (button17.Text == textBox5.Text)
            {
                button17.BackColor = Color.Green;
            }
            
            if (button18.Text == textBox5.Text)
            {
                button18.BackColor = Color.Green;
            }

            if (button19.Text == textBox5.Text)
            {
                button19.BackColor = Color.Green;
            }

            if (button20.Text == textBox5.Text)
            {
                button20.BackColor = Color.Green;
            }

            if (button21.Text == textBox5.Text)
            {
                button21.BackColor = Color.Green;
            }

            if (button22.Text == textBox5.Text)
            {
                button22.BackColor = Color.Green;
            }

            
        }



            

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // seçilen button içindeki text in textbox5'e yazılmasını sağlayan ve buttonların backcolor'unun gri renkte olmasını sağlayan komutlar.

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            textBox5.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
            textBox5.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gray;
            textBox5.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gray;
            textBox5.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Gray;
            textBox5.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Gray;
            textBox5.Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Gray;
            textBox5.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Gray;
            textBox5.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Gray;
            textBox5.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Gray;
            textBox5.Text = button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Gray;
            textBox5.Text = button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Gray;
            textBox5.Text = button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Gray;
            textBox5.Text = button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Gray;
            textBox5.Text = button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Gray;
            textBox5.Text = button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Gray;
            textBox5.Text = button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Gray;
            textBox5.Text = button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Gray;
            textBox5.Text = button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Gray;
            textBox5.Text = button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.Gray;
            textBox5.Text = button20.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Gray;
            textBox5.Text = button21.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.Gray;
            textBox5.Text = button22.Text;
        }


        // listboxlara eklenen verilerin textboxlardan silinmesi için gerekli komutlar. 

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            listBox8.ClearSelected();
            listBox9.ClearSelected();
            listBox10.ClearSelected();
        }

        // listboxlardaki verileri silmek için kullanılır.
        private void button27_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            listBox3.ClearSelected();
            listBox4.ClearSelected();
            listBox5.ClearSelected();
            listBox6.ClearSelected();
            listBox7.ClearSelected();
            listBox11.ClearSelected();

        }
    }
    }

