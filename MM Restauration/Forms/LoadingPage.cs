using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_Restauration
{
    public partial class LoadingPage : Form
    {
        private PrivateFontCollection pfc = new PrivateFontCollection();
        
        public LoadingPage()
        {
         
            InitializeComponent();
            
            //embed fonts ///////////////////
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("MM_Restauration.PrestigeEliteStd.otf");
            byte[] fontdata = new byte[fontStream.Length];
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            fontStream.Close();
            unsafe
            {
                fixed (byte* pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                }
            }
            Font font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            label1.Font = font;
            //////////////////////////
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;
            if (panelSlide.Left > 300)
            {
                panelSlide.Left = 10;
            }
      
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
