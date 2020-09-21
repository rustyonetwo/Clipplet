using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipplet
{
    public partial class frmClippletMain : Form
    {
        //When there is a cut or copy event
        //Copy the contents of the clipboard into clipplet
        //Display the contents of the clipboard, if they are text

        //Unit testing
        //Get and display the current contents of the clipboard
        private void showClipboard()
        {
            IDataObject iData = Clipboard.GetDataObject();
            if(iData.GetDataPresent(DataFormats.Text))
            {
                lblViewer.Text = (String)iData.GetData(DataFormats.Text);
            }
        }

        public frmClippletMain()
        {
            InitializeComponent();
        }

        private void frmClippletMain_Load(object sender, EventArgs e)
        {
            showClipboard();
        }
    }
}


