using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_Restauration
{
    public partial class CustomizedErrorMessage : Form
    {
        public static bool closeProgram = false;
        public CustomizedErrorMessage()
        {
            InitializeComponent();
        }
        static CustomizedErrorMessage MsgBox;
        static DialogResult result = DialogResult.No;

        public static DialogResult Show(string Text, string Caption, string btnOk)
        {
            MsgBox = new CustomizedErrorMessage();
            MsgBox.errorMsg.Text = Text;
            MsgBox.wrongBtn.Text = btnOk;
            MsgBox.caption.Text = Caption;
            MsgBox.ShowDialog();
            return result;
        }



        private void cancelBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            MsgBox.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
            closeProgram = true;
        }
    }
}
