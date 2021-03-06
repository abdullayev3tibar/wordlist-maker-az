using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private void button1_Click(object sender, EventArgs e)
        {
            String txt = textBox1.Text;
            String[] parcala = txt.Split(' ');
           // int baslangic = Convert.ToInt32(textBox2.Text);
            try{
            int son = Convert.ToInt32(textBox3.Text);
            for (int i = 0; i < parcala.Count(); i++)
            {
                for (int a = 0; a < parcala.Count(); a++)                  
                {
                    FileStream fayl = new FileStream("wordlist.txt", FileMode.Append);
                    StreamWriter yaz = new StreamWriter(fayl);
                    yaz.WriteLine(parcala[i] + parcala[a]);
                    yaz.Close();
                }
                string sira = parcala[i];
                FileStream fayl1 = new FileStream("wordlist.txt", FileMode.Append);   
                StreamWriter yaz1 = new StreamWriter(fayl1);
                yaz1.WriteLine(sira + "qwerty");
                yaz1.WriteLine(sira + "admin");
                yaz1.WriteLine(sira + "1234");
                yaz1.WriteLine(sira + "12345");
                yaz1.WriteLine(sira + "123456");
                yaz1.WriteLine(sira + "1234567");
                yaz1.WriteLine(sira + "12345678");
                yaz1.WriteLine(sira + "123456789");
                yaz1.WriteLine(sira + "001");
                yaz1.WriteLine(sira + "002");
                yaz1.WriteLine(sira + "003");
                yaz1.WriteLine(sira + "004");
                yaz1.WriteLine(sira + "005");
                yaz1.WriteLine(sira + "006");
                yaz1.WriteLine(sira + "007");
                yaz1.WriteLine(sira + "008");
                yaz1.WriteLine(sira + "009");
                yaz1.WriteLine("001" + sira);
                yaz1.WriteLine("002" + sira);
                yaz1.WriteLine("003" + sira);
                yaz1.WriteLine("004" + sira);
                yaz1.WriteLine("005" + sira);
                yaz1.WriteLine("006" + sira);
                yaz1.WriteLine("007" + sira);
                yaz1.WriteLine("008" + sira);
                yaz1.WriteLine("009" + sira);
                yaz1.WriteLine(sira + "01");
                yaz1.WriteLine(sira + "02");
                yaz1.WriteLine(sira + "03");
                yaz1.WriteLine(sira + "04");
                yaz1.WriteLine(sira + "05");
                yaz1.WriteLine(sira + "06");
                yaz1.WriteLine(sira + "07");
                yaz1.WriteLine(sira + "08");
                yaz1.WriteLine(sira + "09");
                yaz1.WriteLine("01" + sira);
                yaz1.WriteLine("02" + sira);
                yaz1.WriteLine("03" + sira);
                yaz1.WriteLine("04" + sira);
                yaz1.WriteLine("05" + sira);
                yaz1.WriteLine("06" + sira);
                yaz1.WriteLine("07" + sira);
                yaz1.WriteLine("08" + sira);
                yaz1.WriteLine("09" + sira);
                yaz1.WriteLine(sira + "1111");
                yaz1.WriteLine(sira + "2222");
                yaz1.WriteLine(sira + "3333");
                yaz1.WriteLine(sira + "4444");
                yaz1.WriteLine(sira + "5555");
                yaz1.WriteLine(sira + "6666");
                yaz1.WriteLine(sira + "7777");
                yaz1.WriteLine(sira + "8888");
                yaz1.WriteLine(sira + "9999");
                yaz1.WriteLine(sira + "0101");
                yaz1.WriteLine(sira + "0202");
                yaz1.WriteLine(sira + "0303");
                yaz1.WriteLine(sira + "0404");
                yaz1.WriteLine(sira + "0505");
                yaz1.WriteLine(sira + "0606");
                yaz1.WriteLine(sira + "0707");
                yaz1.WriteLine(sira + "0808");
                yaz1.WriteLine(sira + "0909");
                yaz1.WriteLine("0101" + sira);
                yaz1.WriteLine("0202" + sira);
                yaz1.WriteLine("0303" + sira);
                yaz1.WriteLine("0404" + sira);
                yaz1.WriteLine("0505" + sira);
                yaz1.WriteLine("0606" + sira);
                yaz1.WriteLine("0707" + sira);
                yaz1.WriteLine("0808" + sira);
                yaz1.WriteLine("0909" + sira);
                yaz1.WriteLine("001001" + sira);
                yaz1.WriteLine("002002" + sira);
                yaz1.WriteLine("003003" + sira);
                yaz1.WriteLine("004004" + sira);
                yaz1.WriteLine("005005" + sira);
                yaz1.WriteLine("006006" + sira);
                yaz1.WriteLine("007007" + sira);
                yaz1.WriteLine("008008" + sira);
                yaz1.WriteLine("009009" + sira);
                yaz1.WriteLine("001001" + sira);
                yaz1.WriteLine("002002" + sira);
                yaz1.WriteLine("003003" + sira);
                yaz1.WriteLine("004004" + sira);
                yaz1.WriteLine("005005" + sira);
                yaz1.WriteLine("006006" + sira);
                yaz1.WriteLine("007007" + sira);
                yaz1.WriteLine("008008" + sira);
                yaz1.WriteLine("009009" + sira);
                yaz1.Close();
                for (int baslangic = Convert.ToInt32(textBox2.Text); baslangic < son; baslangic++)  //sayi araligi duzeldir(birlesdirir)
                {
                    String soz = sira + baslangic;
                    String soz2 = baslangic + sira;
                    FileStream fayl = new FileStream("wordlist.txt", FileMode.Append);
                    StreamWriter yaz = new StreamWriter(fayl);
                    yaz.WriteLine(soz);
                    yaz.WriteLine(soz2);
                    yaz.Close();
                }
                progressBar1.Maximum = parcala.Count() -1;

                progressBar1.Value = i;
            }
            }
            catch {
                MessageBox.Show("Sayilar Daxil Edin Meselen 0 dan 999 kimi");
            }
            if (progressBar1.Value == parcala.Count() - 1)
            {
                MessageBox.Show("Wordlist Hazırdır");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
