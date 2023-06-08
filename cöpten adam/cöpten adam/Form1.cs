using System.Diagnostics.Contracts;
using System.Windows.Forms.VisualStyles;

namespace cöpten_adam
{
    public partial class Form1 : Form
    {   
        
        string kelime = "ketçap";
        public Form1()
        {
            InitializeComponent();
            { 
                
            }  
                int sayi = kelime.Length;
                for (int i = 1; i < sayi*2; i+=2)
                {
                 kelime = kelime.Insert(i," ");
                }

            
                         
        }
          char[] cevap = {'_',' ','_',' ','_',' ','_',' ','_',' ','_'};
          int sayac = 0;
          int sayac2 = 0;


        int puan = 100;
        private void button2_Click(object sender, EventArgs e)
        {
            string newkelime = textBox2.Text;
            int kelimeUz = newkelime.Length;
            for (int i = 1; i < kelimeUz*2; i+=2)
            {
                 newkelime = newkelime.Insert(i," ");
            }
            kelime = newkelime;
            string newcevap = new string(cevap);
            newcevap=newkelime;
            kelimeUz=newkelime.Length;
            char[] newcevap2 = newcevap.ToCharArray();
            for (int i = 0 ; i < kelimeUz; i+=2 )
            {
                newcevap2[i] = '_'; 
            }
            cevap = newcevap2;
            string newcevap3 = new string(newcevap2);
            label1.Text = newcevap3;
            sayac = 0;
            sayac2 = 0;
            puan = 100;
            label6.Text = "puan = " + puan;
            label3.Text = "İpucu= " + textBox3.Text;
            textBox2.Text = "";
            textBox3.Text = "";
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string tahmin = textBox1.Text.ToLower();
            char[] tahmin2 = tahmin.ToCharArray();
            textBox1.Text = "";
            int sayi2 = 0;
            int yanlis = 0;
            
            int kelimeUz = kelime.Length;
            char[] new1 = kelime.ToCharArray();
            
            
            for (int i = 0; i < kelimeUz; i++)
            {
                if (new1[i].ToString() == tahmin)
                {
                    cevap[i] = tahmin2[0];
                    string true_cp = new string(cevap);
                   
                    label1.Text=true_cp.ToUpper();
                    sayac += 1;
                   
                    
                }
                else
                {
                    sayi2 +=1;
                   
                }



            }
            
            if (sayi2==kelime.Length)
            {
                sayac2 += 1;
            }
           
             if (kelimeUz/2==sayac)
             {
                MessageBox.Show("teprikler KAZANDİNİZZZ !!! \n              SKOR = " + puan );
               
             }
             else
             {
                
                switch (sayac2)
                {      
                    case 1 : 
                        pictureBox1.Visible = true;
                        yanlis += 1;
                        break;
                    case 2:
                        pictureBox2.Visible = true;
                        yanlis += 1;
                        break;
                    case 3:
                        pictureBox3.Visible = true;
                        yanlis += 1;
                        break;
                    case 4:
                        pictureBox4.Visible = true;
                        yanlis += 1;
                        break;
                    case 5:
                        pictureBox5.Visible = true;
                        yanlis += 1;
                        break;
                    case 6:
                        pictureBox6.Visible = true;
                        yanlis += 1;
                        break;
                    case 7:
                        pictureBox8.Visible = true;
                        yanlis += 1;
                        pictureBox8.BringToFront();
                        break;
                    case 8:
                        pictureBox9.Visible = true;
                        yanlis += 1;
                        pictureBox9.BringToFront() ;
                        break;
                }

                if (sayac2==8)
                {
                    MessageBox.Show("ADAM ÖLDÜ !!!!!!!");
                }
             }

            if (yanlis==1)
            {
                puan -= 10;
                label6.Text = "puan = " + puan;
                yanlis = 0;
            }













           
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}