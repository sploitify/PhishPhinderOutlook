using System;
using System.IO;
using System.Windows.Forms;
using Meziantou.Framework.Win32;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Tools.Ribbon;
using MsgReader;
using MsgReader.Outlook;
using RQReporter.Properties;
using WinSCP;

namespace RQReporter
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }
        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            var m = e.Control.Context as Inspector;
            var mailitem = m.CurrentItem as MailItem;
            if (mailitem != null)
            {
                if (mailitem.Attachments.Count > 0)
                {
                    try
                    {
                        string socServer = Settings1.Default.server;
                        var cred = CredentialManager.ReadCredential("PhishPhinder Outlook");
                        string socUser = cred.UserName;
                        string socPass = cred.Password;
                        //Configure session options
                        SessionOptions sessionOptions = new SessionOptions
                        {
                            Protocol = Protocol.Ftp,
                            HostName = socServer,
                            PortNumber = 990,
                            UserName = socUser,
                            Password = socPass,
                            FtpSecure = FtpSecure.Implicit,
                        };
                        using (Session session = new Session())
                        {
                            try
                            {
                                // Connect
                                session.Open(sessionOptions);

                                // Upload files
                                foreach (Microsoft.Office.Interop.Outlook.Attachment item in mailitem.Attachments)
                                {
                                    item.SaveAsFile(Path.Combine(@"c:\temp", item.FileName));
                                    var uploadFile = (Path.Combine(@"c:\temp", item.FileName));
                                    TransferOptions transferOptions = new TransferOptions();
                                    transferOptions.TransferMode = TransferMode.Binary;
                                    TransferOperationResult transferResult;
                                    session.PutFiles(uploadFile, "/", false, transferOptions);
                                    using (var msg = new MsgReader.Outlook.Storage.Message(Path.Combine(@"c:\temp", item.FileName)))
                                    {
                                        var from = msg.Sender;
                                        var sentOn = msg.SentOn;
                                        string subject = msg.Subject;
                                        Microsoft.Office.Interop.Outlook.Application cApp = new Microsoft.Office.Interop.Outlook.Application();
                                        Microsoft.Office.Interop.Outlook.MailItem SOCemail = cApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                                        SOCemail.Subject = "Phish reported to SOC";
                                        SOCemail.Body = $"The following message has been uploaded to the SOC FTPS server for review:\n\nSubject: \"{subject}\"\nSent On: \"{sentOn}\"".Replace("\n", Environment.NewLine);
                                        SOCemail.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceHigh;
                                        Microsoft.Office.Interop.Outlook.AddressEntry cUser = cApp.Session.CurrentUser.AddressEntry;
                                        Microsoft.Office.Interop.Outlook.ExchangeUser cmanager = cUser.GetExchangeUser().GetExchangeUserManager();
                                        SOCemail.Recipients.Add("soc@yourcompany.com");
                                        SOCemail.Recipients.Add("otherrecipients@yourcompany.com");
                                        SOCemail.Recipients.ResolveAll();
                                        SOCemail.Send();
                                    }
                                    File.Delete(Path.Combine(@"c:\temp", item.FileName));

                                }
                                MessageBox.Show("This phish has been reported to the SOC");
                                session.Close();
                            }
                            //Catch connection failures
                            catch (System.Exception ex)
                            {
                                MessageBox.Show("Connection failed. Please check your username and password.");
                            }
                        }
                    }
                    catch (System.NullReferenceException ex1)
                    {
                        MessageBox.Show("Please populate your settings before continuing.");
                    }
                }
                else
                {
                    //Thrown if there are no attachments
                    MessageBox.Show("This ain't no phish!");
                }
            }
        }

        private void configButton_Click(object sender, RibbonControlEventArgs e)
        {
            settingsForm confset = new settingsForm();
            confset.ShowDialog();
        }

        private void bassButton_Click(object sender, RibbonControlEventArgs e)
        {
            //If you want to add a bass sound effect
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Program Files (x86)\PhishPhinder\PhishPhinder Outlook\bass.wav");
            //player.Play();
            bassForm bassDrop = new bassForm();
            bassDrop.ShowDialog();
            
        }
    }
}