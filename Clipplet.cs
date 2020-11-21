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
        //Register as a clipboard viewer
        //Receive messages when the clipboard is updated
        //Copy the contents of the clipboard into clipplet
        //Display the contents of the clipboard, if they are text

        //Get and display the current contents of the clipboard
        private void showClipboard()
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                lblViewer.Text = (String)iData.GetData(DataFormats.Text);
            }
        }

        public frmClippletMain()
        {
            InitializeComponent();
        }

        //Event handlers

        private void frmClippletMain_Load(object sender, EventArgs e)
        {
            //showClipboard();
        }

        public static event System.EventHandler<object> ContentChanged;


    }


}


