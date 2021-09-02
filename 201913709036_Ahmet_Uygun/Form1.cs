using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201913709036_Ahmet_Uygun
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// form1 in build edilmesi anında yapılacak işlemler tanımlanır
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();//form başlangıcında panelin gizlenmesini sağlar.
        }

        /// <summary>
        /// button un tıklanması durumunda yapılacak işlemler tanımlanır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();//butona basıldığı anda panelin gösterilmesini sağlar bu sayede özellikler kullanılabilir hale gelir
        }

        /// <summary>
        /// tarckbar1 in scroll durumunda yapılacak işlemler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value); /*trackbar1 scroll hareketinde gelen 
            değer ve ayrıca diğer trackbarlardan gelen değerleri argb renk kodlamasına atayarak panelin arkaplan rengine eşitliyor*/
            label1.ForeColor = Color.FromArgb(trackBar1.Value,0,0); //trackbar1 den gelen veriyi argb koduna dönüştürerek label1 in forecolor özelliğine atar
            this.Text = Convert.ToString(Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value));//trackbar1 den gelen veriyi form1 in text kısmına yazmaya yarayan kod. istenilen şekilde olmadı ancak temel anlamda renk kodlarını gösteriyor denilebilir.
        }

        /// <summary>
        /// tarckbar2 nin scroll durumunda yapılacak işlemler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);/*trackbar2 scroll hareketinde gelen 
            değer ve ayrıca diğer trackbarlardan gelen değerleri argb renk kodlamasına atayarak panelin arkaplan rengine eşitliyor*/
            label2.ForeColor = Color.FromArgb(0,trackBar1.Value,0); //trackbar2 den gelen veriyi argb koduna dönüştürerek label2 nin forecolor özelliğine atar
            this.Text = Convert.ToString(Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value));//trackbar2 den gelen veriyi form1 in text kısmına yazmaya yarayan kod. istenilen şekilde olmadı ancak temel anlamda renk kodlarını gösteriyor denilebilir.

        }
        /// <summary>
        /// tarckbar3 ün scroll durumunda yapılacak işlemler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);/*trackbar3 scroll hareketinde gelen 
            değer ve ayrıca diğer trackbarlardan gelen değerleri argb renk kodlamasına atayarak panelin arkaplan rengine eşitliyor*/
            label3.ForeColor = Color.FromArgb(0,0,trackBar1.Value); //trackbar3 den gelen veriyi argb koduna dönüştürerek label3 ün forecolor özelliğine atar
            this.Text = Convert.ToString(Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value));//trackbar3 den gelen veriyi form1 in text kısmına yazmaya yarayan kod. istenilen şekilde olmadı ancak temel anlamda renk kodlarını gösteriyor denilebilir.
        }
    }
}
