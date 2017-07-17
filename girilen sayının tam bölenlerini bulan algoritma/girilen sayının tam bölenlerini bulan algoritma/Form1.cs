using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace girilen_sayının_tam_bölenlerini_bulan_algoritma
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı; // kulanıcağımız sayı'yı int olarak belitiyoruz.
             
            sayı = Convert.ToInt32(textBox1.Text); // Burda sayı yı int değer olarak textbox olarak tanıtıyoruz 

            for (int i = 1; i <= sayı; i++) // eğer i sayıdan küçük ve eşit ise i ye 1 ekle
            { 
           
                if (sayı % i == 0) //sayı i'ye tam bölünüyorsa yani sayının i'ye modu 0 ise;
                {
                  listBox1.Items.Add(i); //sayının i'ye modu 0 ise i yi listbox a yazdır.
                }
            }
        }
            
            }
        }
    

