using System;
using System.Drawing;
using System.Windows.Forms;

namespace Winforms_Example_11___Email_Message
{
    public partial class ImageForm : Form
    {
        public bool Cancelled;

        public ImageForm()
        {
            InitializeComponent();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Cancelled = true;
            this.Hide();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Cancelled = false;
            this.Hide();
        }

        private void cmdBrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog oDialog = new OpenFileDialog();
            DialogResult oResult;
            Image oImage;

            oDialog.CheckFileExists = true;
            oDialog.AutoUpgradeEnabled = true;
            oDialog.FilterIndex = 1;
            oDialog.FileName = "";
            oDialog.Multiselect = false;
            oDialog.Title = "Select an Image file.";
            oDialog.Filter = ("All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.svg)|*.png;*.jpeg;*.gif;*.jpg;*.svg" + ("|PNG Portable Network Graphics (*.png)|*.png" + ("|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" + ("|GIF Graphics Interchange Format (*.gif)|*.gif" + "|SVG Scalable Vector Graphics Format (*.svg)|*.svg"))));
            oResult = oDialog.ShowDialog(this);

            try
            {
                if (oResult == DialogResult.OK)
                {
                    this.txtSource.Text = oDialog.FileName;
                    oImage = Image.FromFile(oDialog.FileName);
                    // etc
                }
            }
            catch
            {
            }
        }
    }
}