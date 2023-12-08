using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.parrotfly;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DinlenecekTuslariAyarla();
            InitializeComponent();
            this.TopMost = true;
        }

        globalKeyboardHook klavye = new globalKeyboardHook(); //hooker tanımlıyorum
        int tıksay;  //uygulamadan çıkış sağlamak için

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
           
        }


        public void DinlenecekTuslariAyarla()
        {
            // hangi tuşları dinlemek istiyorsak burada ekliyoruz

            klavye.HookedKeys.Add(Keys.A);
            klavye.HookedKeys.Add(Keys.S);
            klavye.HookedKeys.Add(Keys.D);
            klavye.HookedKeys.Add(Keys.F);
            klavye.HookedKeys.Add(Keys.G);
            klavye.HookedKeys.Add(Keys.H);
            klavye.HookedKeys.Add(Keys.J);
            klavye.HookedKeys.Add(Keys.K);
            klavye.HookedKeys.Add(Keys.L);
            klavye.HookedKeys.Add(Keys.Z);
            klavye.HookedKeys.Add(Keys.X);
            klavye.HookedKeys.Add(Keys.C);
            klavye.HookedKeys.Add(Keys.V);
            klavye.HookedKeys.Add(Keys.B);
            klavye.HookedKeys.Add(Keys.N);
            klavye.HookedKeys.Add(Keys.M);
            klavye.HookedKeys.Add(Keys.Q);
            klavye.HookedKeys.Add(Keys.W);
            klavye.HookedKeys.Add(Keys.E);
            klavye.HookedKeys.Add(Keys.R);
            klavye.HookedKeys.Add(Keys.T);
            klavye.HookedKeys.Add(Keys.Y);
            klavye.HookedKeys.Add(Keys.U);
            klavye.HookedKeys.Add(Keys.I);
            klavye.HookedKeys.Add(Keys.O);
            klavye.HookedKeys.Add(Keys.P);

            //Türkçe Karekterler 

            klavye.HookedKeys.Add(Keys.OemOpenBrackets);
            klavye.HookedKeys.Add(Keys.Oem6);
            klavye.HookedKeys.Add(Keys.Oem1);
            klavye.HookedKeys.Add(Keys.Oem7);
            klavye.HookedKeys.Add(Keys.OemQuestion);
            klavye.HookedKeys.Add(Keys.Oem5);

            //Rakamlar

            klavye.HookedKeys.Add(Keys.NumPad0);
            klavye.HookedKeys.Add(Keys.NumPad1);
            klavye.HookedKeys.Add(Keys.NumPad2);
            klavye.HookedKeys.Add(Keys.NumPad3);
            klavye.HookedKeys.Add(Keys.NumPad4);
            klavye.HookedKeys.Add(Keys.NumPad5);
            klavye.HookedKeys.Add(Keys.NumPad6);
            klavye.HookedKeys.Add(Keys.NumPad7);
            klavye.HookedKeys.Add(Keys.NumPad8);
            klavye.HookedKeys.Add(Keys.NumPad9);

            //Üst Rakamlar



            klavye.HookedKeys.Add(Keys.D0);
            klavye.HookedKeys.Add(Keys.D1);
            klavye.HookedKeys.Add(Keys.D2);
            klavye.HookedKeys.Add(Keys.D3);
            klavye.HookedKeys.Add(Keys.D4);
            klavye.HookedKeys.Add(Keys.D5);
            klavye.HookedKeys.Add(Keys.D6);
            klavye.HookedKeys.Add(Keys.D7);
            klavye.HookedKeys.Add(Keys.D8);
            klavye.HookedKeys.Add(Keys.D9);

            //nokta , backspace vs
            klavye.HookedKeys.Add(Keys.OemPeriod);
            klavye.HookedKeys.Add(Keys.Back);
            klavye.HookedKeys.Add(Keys.Tab);

            klavye.HookedKeys.Add(Keys.Control);
            klavye.HookedKeys.Add(Keys.ControlKey);
            klavye.HookedKeys.Add(Keys.LControlKey);
            klavye.HookedKeys.Add(Keys.RControlKey);

            klavye.HookedKeys.Add(Keys.LMenu);
            klavye.HookedKeys.Add(Keys.Menu);
            klavye.HookedKeys.Add(Keys.RMenu);
            klavye.HookedKeys.Add(Keys.RControlKey);


            klavye.HookedKeys.Add(Keys.Space);
            klavye.HookedKeys.Add(Keys.Enter);
            klavye.HookedKeys.Add(Keys.CapsLock);


            klavye.HookedKeys.Add(Keys.Return);
            klavye.HookedKeys.Add(Keys.Shift);
            klavye.HookedKeys.Add(Keys.RShiftKey);
            //fler 

            klavye.HookedKeys.Add(Keys.F1);
            klavye.HookedKeys.Add(Keys.F2);
            klavye.HookedKeys.Add(Keys.F3);
            klavye.HookedKeys.Add(Keys.F4);
            klavye.HookedKeys.Add(Keys.F5);
            klavye.HookedKeys.Add(Keys.F6);
            klavye.HookedKeys.Add(Keys.F7);
            klavye.HookedKeys.Add(Keys.F8);
            klavye.HookedKeys.Add(Keys.F9);
            klavye.HookedKeys.Add(Keys.F11);
            klavye.HookedKeys.Add(Keys.F12);
            klavye.HookedKeys.Add(Keys.PrintScreen);
            klavye.HookedKeys.Add(Keys.Insert);
            klavye.HookedKeys.Add(Keys.Delete);
            klavye.HookedKeys.Add(Keys.VolumeUp);
            klavye.HookedKeys.Add(Keys.VolumeMute);
            klavye.HookedKeys.Add(Keys.VolumeDown);
            klavye.HookedKeys.Add(Keys.LWin);
            klavye.HookedKeys.Add(Keys.Escape);

            klavye.HookedKeys.Add(Keys.RShiftKey);
            klavye.HookedKeys.Add(Keys.LShiftKey);

            klavye.HookedKeys.Add(Keys.Oem3);
            klavye.HookedKeys.Add(Keys.Oem8);
            klavye.HookedKeys.Add(Keys.OemMinus);
            klavye.HookedKeys.Add(Keys.Oemcomma);
            klavye.HookedKeys.Add(Keys.OemPeriod);

            klavye.HookedKeys.Add(Keys.Up);
            klavye.HookedKeys.Add(Keys.Left);
            klavye.HookedKeys.Add(Keys.Right);
            klavye.HookedKeys.Add(Keys.Down);


            klavye.HookedKeys.Add(Keys.OemBackslash);



                
           


            //basıldığında ilk burası çalışır
            klavye.KeyDown += new KeyEventHandler(islem1);
            //basıldıktan sonra ikinci olarak burası çalışır
            klavye.KeyUp += new KeyEventHandler(islem2);
        }

        #region ping
        void islem1(object sender, KeyEventArgs e)
        {

            //Burası tuşa basıldığı an çalışır

            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                label1.ForeColor = Color.Red;


            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                label2.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                label3.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                label4.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                label5.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                label6.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                label7.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                label8.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                label9.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                label10.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Oem8)
                labelstar.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.OemMinus)
                labelline.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Oem3)
                labeleline.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Up)
                labelUP.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Down)
                labelDOWN.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Right)
                labelRİGHT.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Left)
                labelLEFT.ForeColor = Color.Red;



            else if (e.KeyCode == Keys.F1)
                labelF1.ForeColor = Color.Red;


            else if (e.KeyCode == Keys.F2)
                labelF2.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F3)
                labelF3.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F4)
                labelF4.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F5)
                labelF5.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F6)
                labelF6.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F7)
                labelF7.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F8)
                labelF8.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F9)
                labelF9.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F10)
                labelF10.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F11)
                labelF11.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F12)
                labelF12.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Q)
                labelQ.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.W)
                labelW.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.E)
                labelE.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.R)
                labelR.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.T)
                labelT.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Y)
                labelY.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.U)
                labelU.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.I)
                labelı.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.O)
                labelO.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.P)
                labelP.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.OemOpenBrackets)
                labelG_TR.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.OemCloseBrackets)
                labelU_TR.ForeColor = Color.Red;


            else if (e.KeyCode == Keys.A)
                labelA.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.S)
                labelS.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.D)
                labelD.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.F)
                labelF.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.G)
                labelG.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.H)
                labelH.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.J)
                labelJ.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.K)
                labelK.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.L)
                labelL.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.OemSemicolon)
                labelS_TR.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.OemQuotes)
                labelI_TR.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Oemcomma)
                labelvirgül.ForeColor = Color.Red;


            else if (e.KeyCode == Keys.Z)
                labelZ.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.X)
                labelX.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.C)
                labelC.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.V)
                labelV.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.B)
                labelB.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.N)
                labelN.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.M)
                labelM.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Oem2)
                labelÖ.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Oem5)
                labelC_TR.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.OemPeriod)
                labelDOT.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Oem102)
                labelARROW.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Back)
                labelback.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Space)
                labelSPACE.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Enter)
                labelENTER.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Escape)
            {
                tıksay++;
                labelESC.ForeColor = Color.Red;

                if (tıksay == 2)
                {
                    Application.Exit();
                }
            }



            else if (e.KeyCode == Keys.Delete)
                labeldel.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.Tab)
                labelTAB.ForeColor = Color.Red;


            else if (e.KeyCode == Keys.ShiftKey)
                labelShift.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.RShiftKey)
                labelRshift.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.LWin)
                labelWİN.ForeColor = Color.Red;

            //ctrl tuşunun işlevleri yüzünden burası biraz karışık düzenleyeceğim


            else if (e.KeyCode == Keys.RControlKey)
                labelRCTRL.ForeColor = Color.Red;

            else if (e.KeyCode == Keys.LControlKey)
                labelCtrl.ForeColor = Color.Red;





            //Eğer buraya gelecek olan tuşa basıldığında
            //o tuşun normal işlevi yine çalışsın istiyorsanız
            //e.Handled değeri false olmalı
            //eğer ilgili tuşa basıldığında burada yakalansın
            // ve devamında tuş başka bir işlev gerçekleştirmesin
            //istiyorsanız bu değeri true yapmalısınız

            e.Handled = false;
        }
        #endregion

        #region ping2
        public void islem2(object sender, KeyEventArgs e)
        {

            // Burası ilgili tuşlara basılıp çekildikten sonra çalışır


            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                label1.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                label2.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                label3.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                label4.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                label5.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                label6.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                label7.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                label8.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                label9.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                label10.ForeColor = Color.Black;


            else if (e.KeyCode == Keys.Oem8)
                labelstar.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.OemMinus)
                labelline.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Oem3)
                labeleline.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F1)
                labelF1.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Up)
                labelUP.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Down)
                labelDOWN.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Right)
                labelRİGHT.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Left)
                labelLEFT.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F2)
                labelF2.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F3)
                labelF3.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F4)
                labelF4.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F5)
                labelF5.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F6)
                labelF6.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F7)
                labelF7.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F8)
                labelF8.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F9)
                labelF9.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F10)
                labelF10.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F11)
                labelF11.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F12)
                labelF12.ForeColor = Color.Black;


            else if (e.KeyCode == Keys.Q)
                labelQ.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.W)
                labelW.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.E)
                labelE.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.R)
                labelR.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.T)
                labelT.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Y)
                labelY.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.U)
                labelU.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.I)
                labelı.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.O)
                labelO.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.P)
                labelP.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.OemOpenBrackets)
                labelG_TR.ForeColor = Color.Black;


            else if (e.KeyCode == Keys.OemCloseBrackets)
                labelU_TR.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Space)
                labelSPACE.ForeColor = Color.Black;


            else if (e.KeyCode == Keys.A)
                labelA.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.S)
                labelS.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.D)
                labelD.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.F)
                labelF.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.G)
                labelG.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.H)
                labelH.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.J)
                labelJ.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.K)
                labelK.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.L)
                labelL.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.OemSemicolon)
                labelS_TR.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.OemQuotes)
                labelI_TR.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Oemcomma)
                labelvirgül.ForeColor = Color.Black;


            else if (e.KeyCode == Keys.LWin)
                labelWİN.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Z)
                labelZ.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.X)
                labelX.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.C)
                labelC.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.V)
                labelV.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.B)
                labelB.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.N)
                labelN.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.M)
                labelM.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Oem2)
                labelÖ.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Oem5)
                labelC_TR.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.OemPeriod)
                labelDOT.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Oem102)
                labelARROW.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Back)
                labelback.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Enter)
                labelENTER.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Escape)
                labelESC.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Delete)
                labeldel.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.Tab)
                labelTAB.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.ShiftKey)
                labelShift.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.RShiftKey)
                labelRshift.ForeColor = Color.Black;

            else if (e.KeyCode == Keys.LControlKey)
            {
                labelCtrl.ForeColor = Color.Black;
                labelALT.ForeColor = Color.Black;
            }

            else if (e.KeyCode == Keys.RControlKey)
            {
                labelRCTRL.ForeColor = Color.Black;
                labelALT.ForeColor = Color.Black;
            }

            else if (e.KeyCode == Keys.LControlKey)
            {
                labelCtrl.ForeColor = Color.Black;
                labelALT.ForeColor = Color.Black;

                labelALTGR.ForeColor = Color.Black;

            }



            else if (Control.IsKeyLocked(Keys.CapsLock))
            {
                labelCAPS.ForeColor = Color.Blue;
            }




            else if (Control.IsKeyLocked(Keys.Insert))
            {
                labelscr.ForeColor = Color.Blue;

            }








            else
            {
                labelCAPS.ForeColor = Color.Black;
                labelscr.ForeColor = Color.Black;
            }






            //Eğer buraya gelecek olan tuşa basıldığında
            //o tuşun normal işlevi yine çalışsın istiyorsanız
            //e.Handled değeri false olmalı
            //eğer ilgili tuşa basıldığında burada yakalansın
            // ve devamında tuş başka bir işlev gerçekleştirmesin
            //istiyorsanız bu değeri true yapmalısınız
            e.Handled = false;
        }









        #endregion

        private void labelF1_Click(object sender, EventArgs e)
        {

        }

        private void labelFN_Click(object sender, EventArgs e)
        {

        }
    }
}
