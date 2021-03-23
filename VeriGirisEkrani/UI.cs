using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriGirisEkrani
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UI_Load(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yazdir_button_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            Font font = new Font("Arial", 14);
            SolidBrush firca = new SolidBrush(Color.Black);
            e.Graphics.DrawString($"Tarih = {DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss")}", font, firca, 50, 25);


            ///////////////////////////////////

            font = new Font("Arial", 11, FontStyle.Regular);
            e.Graphics.DrawString("Kayıt No: ", font, firca, 100, 70);

            e.Graphics.DrawString("Tc No: ", font, firca, 100, 150);
            e.Graphics.DrawString(tc_giris.Text, font, firca, 200, 150);

            e.Graphics.DrawString("Adres: ", font, firca, 100, 230);
            e.Graphics.DrawString(textBox1.Text, font, firca, 200, 230);


            e.Graphics.DrawString("Müşteri Tc No: ", font, firca, 100, 350);
            e.Graphics.DrawString(textBox2.Text, font, firca, 210, 350);

            e.Graphics.DrawString("Müşteri Adresi: ", font, firca, 100, 430);
            e.Graphics.DrawString(textBox3.Text, font, firca, 210, 430);
            //////

            e.Graphics.DrawString("Telefon No: ", font, firca, 450, 150);
            e.Graphics.DrawString(textBox4.Text, font, firca, 550, 150);

            e.Graphics.DrawString("İl: ", font, firca, 450, 200);
            e.Graphics.DrawString(il_giris.Text, font, firca, 550, 200);

            e.Graphics.DrawString("İlçe: ", font, firca, 450, 250);
            e.Graphics.DrawString(ilce_giris.Text, font, firca, 550, 250);

            e.Graphics.DrawString("Posta Kodu: ", font, firca, 450, 300);
            

            e.Graphics.DrawString("Müşteri Tel No: ", font, firca, 450, 350);
            e.Graphics.DrawString(musteri_tel_no_giris.Text, font, firca, 560, 350);

            e.Graphics.DrawString("Müşteri İl: ", font, firca, 450, 400);
            e.Graphics.DrawString(musteri_il_giris.Text, font, firca, 550, 400);

            e.Graphics.DrawString("Müşteri ilçe: ", font, firca, 450, 450);
            e.Graphics.DrawString(musteri_ilce_giris.Text, font, firca, 550, 450);

            e.Graphics.DrawString("Müşteri Posta Kodu: ", font, firca, 450, 500);
            
        }

        private void tc_giris_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void il_giris_TextChanged(object sender, EventArgs e)
        {

        }

        private void ilce_giris_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteri_tel_no_giris_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteri_il_giris_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteri_ilce_giris_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           // PaperSize CustomSize1 = new PaperSize("Benim sayfam", 250, 100);
        }
      
    }
}
