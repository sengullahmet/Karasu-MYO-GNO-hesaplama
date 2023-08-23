using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

        }


    




        public static double hesapla(string harf,double akts)
        {
            if (harf == "AA")
                return akts * 4.00;
            else if (harf == "BA")
                return akts * 3.50;
            else if (harf == "BB")
                return akts * 3.00;
            else if (harf == "CB")
                return akts * 2.50;
            else if (harf == "CC")
                return akts * 2.00;
            else if (harf == "DC")
                return akts * 1.50;
            else if (harf == "DD")
                return akts * 1.00;
            else if (harf == "FD")
                return akts * 0.50;
            else if (harf == "FF")
                return akts * 0;
            else if (harf == "GR")
                return akts * 0;
            else if (harf == "DZ")
                return akts * 0;
            else if (harf == "YT")
                return akts * 0;
            else if (harf == "YZ")
                return akts * 0;
            else
                return akts ;
            




        }

        double genelorttop = 0;
        double aktstoplam = 0;
        public void button1_Click(object sender, EventArgs e)
        {
            //1. Dönem//
            double puan1, puan2, puan3, puan4, puan5, puan6, puan7;
            double toplam = 0, ortalama = 0, genelortalama=0,akts=0 ;


            puan1 = hesapla(comboBox1.Text, 5); 
            puan2 = hesapla(comboBox2.Text, 4);
            puan3 = hesapla(comboBox3.Text, 4);
            puan4 = hesapla(comboBox4.Text, 5); 
            puan5 = hesapla(comboBox5.Text, 5); 
            puan6 = hesapla(comboBox6.Text, 3);
            puan7 = hesapla(comboBox7.Text, 4);


            akts = (5 + 4 + 4 + 5 + 5 + 3 + 4);
            aktstoplam = aktstoplam + akts;
            toplam =  toplam+puan1 + puan2 + puan3 + puan4 + puan5 + puan6 + puan7;
            ortalama = toplam / akts;
            genelorttop=genelorttop+toplam;
            genelortalama = genelorttop/ 30;

            textBox1.Text = toplam.ToString();
            textBox4.Text = ortalama.ToString();
            textBox5.Text = genelortalama.ToString();
            textBox3.Text = genelorttop.ToString();
            textBox2.Text = akts.ToString();
            textBox21.Text = aktstoplam.ToString();

             

            
            // 2.Dönem Hesaplama//
           
            double puan9, puan10, puan11, puan12, puan13, puan14, puan15;
            double toplam1 = 0, ortalama1 = 0, genelortalama1 = 0, akts1 = 0;


            puan9 = hesapla(comboBox12.Text, 4);
            puan10 = hesapla(comboBox11.Text, 6);
            puan11= hesapla(comboBox10.Text, 4);
            puan12 = hesapla(comboBox9.Text, 4);
            puan13 = hesapla(comboBox8.Text, 5);
            puan14 = hesapla(comboBox25.Text, 4);
            puan15 = hesapla(comboBox26.Text, 3);


            akts1 = (4 + 6 + 4 + 4 + 5 + 4 + 3);
            aktstoplam = aktstoplam + akts1;
            toplam1 = puan9 + puan10 + puan11 + puan12 + puan13 + puan14 + puan15;
            ortalama1 = toplam1 / akts;
            genelorttop = genelorttop + toplam1;
            genelortalama1 = genelorttop / 60;
            
            textBox11.Text = toplam1.ToString();
            textBox7.Text = ortalama1.ToString();
            textBox6.Text = genelortalama1.ToString();
            textBox8.Text = genelorttop.ToString();
            textBox9.Text = aktstoplam.ToString();
            textBox10.Text = akts1.ToString();


            // 3.Dönem Hesaplama//

            double puan16, puan17, puan18, puan19, puan20, puan21, puan22;
            double toplam2 = 0, ortalama2 = 0, genelortalama2 = 0, akts2 = 0 ;


            puan16 = hesapla(comboBox18.Text, 4);
            puan17 = hesapla(comboBox17.Text, 4);
            puan18 = hesapla(comboBox16.Text, 4);
            puan19 = hesapla(comboBox15.Text, 5);
            puan20 = hesapla(comboBox14.Text, 5);
            puan21 = hesapla(comboBox13.Text, 4);
            puan22 = hesapla(comboBox28.Text, 4);


            akts2 = (4 + 6 + 4 + 4 + 5 + 4 + 3);
            aktstoplam = aktstoplam + akts2;
            toplam2 = puan16 + puan17 + puan18 + puan19 + puan20 + puan21 + puan22;
            ortalama2 = toplam2 / akts2;
            genelorttop = genelorttop + toplam2;
            genelortalama2 = genelorttop / 90;

            textBox14.Text = genelorttop.ToString();
            textBox13.Text = ortalama2.ToString();
            textBox12.Text = genelortalama2.ToString();
            textBox17.Text = toplam2.ToString();
            textBox16.Text = akts2.ToString();
            textBox15.Text = aktstoplam.ToString();



            //4.Dönem Hesaplama

            double puan23, puan24, puan25;
            double toplam3 = 0, ortalama3 = 0, genelortalama3 = 0, akts3 = 0;

            puan23 = hesapla(comboBox24.Text, 4);
            puan24 = hesapla(comboBox23.Text, 21);
            puan25 = hesapla(comboBox22.Text, 5);

            akts3 = (4 + 21);
            aktstoplam = aktstoplam + akts3 ; 
            toplam3 = puan23 + puan24+puan25;
            ortalama3 = toplam3 / akts3;
            genelorttop = genelorttop + toplam3;
            genelortalama3 = genelorttop / 115;
            akts3 += 5;
            

            textBox20.Text = genelorttop.ToString();
            textBox19.Text = ortalama3.ToString();
            textBox18.Text= genelortalama3.ToString();
            textBox24.Text = toplam3.ToString();
            textBox23.Text=akts3.ToString();
            textBox22.Text=aktstoplam.ToString();






        }
    }

    
}

