﻿
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using Zoople;

namespace Winforms_Example_11___Email_Message
{
    public partial class Form1 : Form
    {

        Zoople.HTMLEditControl oEdit;

        public Form1()
        {
            InitializeComponent();

            oEdit = new HTMLEditControl
            {
                Dock = DockStyle.Fill,
                DocumentHTML = "<img align='right' src='images/anna2.jpg' width='200px'/><h2>Saving as an Email with inline images.</h2><p>This example shows how to save an eml file containing inline (embedded) images</p>",
                ShowPropertyGrid = false,
                CSSText = "BODY {font-family: times new roman;}",
                LicenceKey = "YourLicenseKey",
                LicenceKeyInlineSpelling = "YourInlineSpellingLicenseKey",
                EnableInlineSpelling = true,
                BaseURL = Application.StartupPath.Replace("\\", "/"),
                UseRelativeURLs = true,
                ImageStorageLocation = Path.Combine(Application.StartupPath, "images")
            };

            Controls.Add(oEdit);

            var oButton = oEdit.ToolStripItems.Add("Save As Email");
            oButton.Click += AsEmail_Click;
            oButton.Padding = new Padding(3);

            var oButtonSpell = oEdit.ToolStripItems.Add("Check Spelling");
            oButtonSpell.Click += OButtonSpell_Click;
            oButtonSpell.Padding = new Padding(3);

            oEdit.SpellCheckComplete += OEdit_SpellCheckComplete;

            oEdit.DocumentLoadComplete += OEdit_DocumentLoadComplete;

            oEdit.CommandsToolbarButtonClicked += OEdit_CommandsToolbarButtonClicked;
            oEdit.CancellableUserInteraction += OEdit_CancellableUserInteraction;
        }

        private void OEdit_CancellableUserInteraction(object sender, CancellableUserInteractionEventsArgs e)
        {
            if (e.InteractionType == Zoople.EditorUIEvents.ondblclick)
            {
                if (oEdit.CurrentWindowsFormsElement != null && oEdit.CurrentWindowsFormsElement.TagName.ToLower() == "img")
                {
                    ImageForm oImgF = new ImageForm();
                    oImgF.txtSource.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("src");
                    oImgF.txtAltText.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("alt");
                    oImgF.txtBorder.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("border");
                    oImgF.txtBorder.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("border");
                    oImgF.txtWidth.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("width");
                    oImgF.txtHeight.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("height");

                    oImgF.ShowDialog(this);

                    if (!oImgF.Cancelled)
                    {
                        HtmlElement oImg = oEdit.CurrentWindowsFormsElement;
                        oImg.SetAttribute("src", oImgF.txtSource.Text);

                        if (oImgF.txtAltText.Text != "")
                            oEdit.CurrentWindowsFormsElement.SetAttribute("alt", oImgF.txtAltText.Text);
                        else
                            ((dynamic)oEdit.CurrentElement).RemoveAttribute("alt");

                        if (oImgF.txtBorder.Text != "")
                            oEdit.CurrentWindowsFormsElement.SetAttribute("border", oImgF.txtBorder.Text);
                        else
                            ((dynamic)oEdit.CurrentElement).RemoveAttribute("border");

                        if (oImgF.txtWidth.Text != "")
                            oEdit.CurrentWindowsFormsElement.SetAttribute("width", oImgF.txtWidth.Text);
                        else
                            ((dynamic)oEdit.CurrentElement).RemoveAttribute("width");

                        if (oImgF.txtHeight.Text != "")
                            oEdit.CurrentWindowsFormsElement.SetAttribute("height", oImgF.txtHeight.Text);
                        else
                            ((dynamic)oEdit.CurrentElement).RemoveAttribute("height");

                    }

                    e.Cancel = true;
                }
            }
        }

        private void OEdit_CommandsToolbarButtonClicked(object sender, Zoople.CommandsToolbarButtonClickedEventArgs e)
        {
            if (e.ButtonIdentifier == "InsertImageToolStripButton")
            {
                e.Cancelled = true;

                ImageForm oImgF = new ImageForm();

                if (oEdit.CurrentWindowsFormsElement != null && oEdit.CurrentWindowsFormsElement.TagName.ToLower() == "img")
                {
                    oImgF.txtSource.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("src");
                    oImgF.txtAltText.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("alt");
                    oImgF.txtBorder.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("border");
                    oImgF.txtWidth.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("width");
                    oImgF.txtHeight.Text = oEdit.CurrentWindowsFormsElement.GetAttribute("height");
                }

                oImgF.ShowDialog(this);

                if (!oImgF.Cancelled)
                {
                    if (oEdit.CurrentWindowsFormsElement != null && oEdit.CurrentWindowsFormsElement.TagName.ToLower() == "img")
                    {
                        oEdit.CurrentWindowsFormsElement.SetAttribute("src", oImgF.txtSource.Text);

                        if (oImgF.txtAltText.Text != "")
                            oEdit.CurrentWindowsFormsElement.SetAttribute("alt", oImgF.txtAltText.Text);
                        else
                            ((dynamic)oEdit.CurrentElement).RemoveAttribute("alt");

                        if (oImgF.txtBorder.Text != "")
                            oEdit.CurrentWindowsFormsElement.SetAttribute("border", oImgF.txtBorder.Text);
                        else
                            ((dynamic)oEdit.CurrentElement).RemoveAttribute("border");

                        if (oImgF.txtWidth.Text != "")
                            oEdit.CurrentWindowsFormsElement.SetAttribute("width", oImgF.txtWidth.Text);
                        else
                            ((dynamic)oEdit.CurrentElement).RemoveAttribute("width");

                        if (oImgF.txtHeight.Text != "")
                            oEdit.CurrentWindowsFormsElement.SetAttribute("height", oImgF.txtHeight.Text);
                        else
                            ((dynamic)oEdit.CurrentElement).RemoveAttribute("height");

                    }
                    else
                    {
                        HtmlElement oImg;
                        oImg = oEdit.Insert_Image(oImgF.txtSource.Text);
                        oImg.SetAttribute("src", oImgF.txtSource.Text);
                        if (oImgF.txtAltText.Text != "") oEdit.CurrentWindowsFormsElement.SetAttribute("alt", oImgF.txtAltText.Text);
                        if (oImgF.txtBorder.Text != "") oEdit.CurrentWindowsFormsElement.SetAttribute("border", oImgF.txtBorder.Text);
                        if (oImgF.txtWidth.Text != "") oEdit.CurrentWindowsFormsElement.SetAttribute("width", oImgF.txtWidth.Text);
                        if (oImgF.txtHeight.Text != "") oEdit.CurrentWindowsFormsElement.SetAttribute("height", oImgF.txtHeight.Text);
                    }
                }
                oImgF.Close();
            }
        }

        private void OEdit_DocumentLoadComplete(object sender, EventArgs e)
        {
            //AsEmail_Click(null, null); 
        }

        private void OEdit_SpellCheckComplete(object sender, EventArgs e)
        {
            MessageBox.Show("Spelling Check Completed");
        }

        private void OButtonSpell_Click(object sender, EventArgs e)
        {
            oEdit.SpellCheckDocument(true);
        }

        private void AsEmail_Click(object sender, EventArgs e)
        {

            // string EditorHTML = oEdit.DocumentHTML;
            HtmlDocument oDoc = oEdit.DocumentClone;

            MailMessage newMail = new MailMessage();
            newMail.To.Add(new MailAddress("you@your.address"));
            newMail.From = (new MailAddress("someone@their.address"));
            newMail.Subject = "Test Subject";
            newMail.IsBodyHtml = true;

            //List<LinkedResource> inlineLogoList = new List<LinkedResource>();
            var attachments = newMail.Attachments;

            foreach (HtmlElement oImage in oDoc.GetElementsByTagName("img"))
            {
                Uri oUri = new Uri(oImage.GetAttribute("src"));
                if (oUri.IsFile)
                {
                    var inlineLogo = new Attachment(oUri.LocalPath, "image/" + new FileInfo(oUri.LocalPath).Extension.Substring(1))
                    {
                        ContentId = Guid.NewGuid().ToString(),
                    };

                    inlineLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;

                    oImage.SetAttribute("src", "cid:" + inlineLogo.ContentId);
                    attachments.Add(inlineLogo);
                }
            }

            var view = AlternateView.CreateAlternateViewFromString(oDoc.GetElementsByTagName("html")[0].OuterHtml, null, "text/html");

            newMail.AlternateViews.Add(view);

            var view2 = AlternateView.CreateAlternateViewFromString(oDoc.GetElementsByTagName("body")[0].InnerText, Encoding.ASCII, "text/plain");
            newMail.AlternateViews.Add(view2);

            SmtpClient client = new SmtpClient("mysmtphost")
            {
                DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                PickupDirectoryLocation = Application.StartupPath + "/SMTPPickupFolder"
            };
            client.Send(newMail);

            // oEdit.DocumentHTML = EditorHTML;

            MessageBox.Show("Successfully saved to \r\n\r\n " + Application.StartupPath + "/SMTPPickupFolder");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
