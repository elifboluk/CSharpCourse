using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 11_RecapDemo-Dama Tahtası Yapmak
// Uygulama ilk açıldığında tam olarak çalışacak kod burasıdır.
// Aynı işlemden farklı nesneler oluşturup onları daha sonra kontrol altında tutmak istiyorsak arraylerden yararlanabiliriz.
namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8]; // 8*8'lik bir buton array'i oluşturuldu.
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) // 8 satır için bir değer oluşturduk.
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++) // sıfırıncı satırın sıfırıncı butonu oluşturuldu.
                {
                    buttons[i, j] = new Button();// her butonu newlememiz gerekir çünkü her buton yeni bir butondur.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left; // soldan uzaklığı başlangıç değerine göre 0'dır.
                    buttons[i, j].Top = top;
                    left += 50; // Sonraki butonları her seferinde +50 uzaklığında koyacaktır.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0; // ikinci satıra geçtiğinde left'i sıfır yapmalı.

            }
        }
    }
    
}
