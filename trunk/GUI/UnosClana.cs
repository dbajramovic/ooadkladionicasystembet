using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using Microsoft.Expression.Encoder;
using DAL.Entiteti;

namespace GUI
{
    public partial class UnosClana : Form
    {
        string slika;
        private LiveJob _job;
        private LiveDeviceSource _deviceSource;
        private bool _bStartedRecording = false;

        public UnosClana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clan c = new Clan(t_ime.Text + " " + t_prezime.Text, t_jmbg.Text, slika);
            DAL.DAL d = DAL.DAL.Instanca;
            d.kreirajKonekciju("localhost", "kladionica", "root", "");
            DAL.DAL.ClanDAO cd = new DAL.DAL.ClanDAO();
            c.DajIDClana = cd.create(c);
            d.terminirajKonekciju();
            MessageBox.Show("Član uspješno dodan!");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a Bitmap of the same dimension of panelVideoPreview (Width x Height)
                using (Bitmap bitmap = new Bitmap(panelVideoPreview.Width, panelVideoPreview.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        // Get the paramters to call g.CopyFromScreen and get the image
                        Rectangle rectanglePanelVideoPreview = panelVideoPreview.Bounds;
                        Point sourcePoints = panelVideoPreview.PointToScreen(new Point(panelVideoPreview.ClientRectangle.X, panelVideoPreview.ClientRectangle.Y));
                        g.CopyFromScreen(sourcePoints, Point.Empty, rectanglePanelVideoPreview.Size);
                    }

                    string strGrabFileName = String.Format("C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Snapshot_{0:yyyyMMdd_hhmmss}.jpg", DateTime.Now);
                    bitmap.Save(strGrabFileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    slika = strGrabFileName;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            } 
        }

        private void UnosClana_Enter(object sender, EventArgs e)
        {
            
        }

        private void UnosClana_Load(object sender, EventArgs e)
        {
            lstVideoDevices.ClearSelected();
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                lstVideoDevices.Items.Add(edv.Name);
            }


            lstAudioDevices.ClearSelected();
            foreach (EncoderDevice eda in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                lstAudioDevices.Items.Add(eda.Name);
            }
        }
        private void GetSelectedVideoAndAudioDevices(out EncoderDevice video, out EncoderDevice audio)
        {
            video = null;
            audio = null;



            if (lstVideoDevices.SelectedIndex < 0 || lstAudioDevices.SelectedIndex < 0)
            {
                MessageBox.Show("No Video and Audio capture devices have been selected.\nSelect an audio and video devices from the listboxes and try again.", "Warning");
                return;
            }

            // Get the selected video device            
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                if (String.Compare(edv.Name, lstVideoDevices.SelectedItem.ToString()) == 0)
                {
                    video = edv;

                    break;
                }
            }

            // Get the selected audio device            
            foreach (EncoderDevice eda in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                if (String.Compare(eda.Name, lstAudioDevices.SelectedItem.ToString()) == 0)
                {
                    audio = eda;

                    break;
                }
            }
        }

        void StopJob()
        {
            // Has the Job already been created ?
            if (_job != null)
            {
                // Yes
                // Is it capturing ?
                //if (_job.IsCapturing)
                if (_bStartedRecording)
                {
                    // Yes
                    // Stop Capturing

                }

                _job.StopEncoding();

                // Remove the Device Source and destroy the job
                _job.RemoveDeviceSource(_deviceSource);

                // Destroy the device source
                _deviceSource.PreviewWindow = null;
                _deviceSource = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EncoderDevice video = null;
            EncoderDevice audio = null;

            GetSelectedVideoAndAudioDevices(out video, out audio);
            StopJob();

            if (video == null)
            {
                return;
            }

            _job = new LiveJob();
            if (video != null && audio != null)
            {
                // Create a new device source. We use the first audio and video devices on the system
                _deviceSource = _job.AddDeviceSource(video, audio);

                // Is it required to show the configuration dialogs ?
                if (1 == 2)
                {
                    // Yes
                    // VFW video device ?
                    if (lstVideoDevices.SelectedItem.ToString().EndsWith("(VFW)", StringComparison.OrdinalIgnoreCase))
                    {
                        // Yes
                        if (_deviceSource.IsDialogSupported(ConfigurationDialog.VfwFormatDialog))
                        {
                            _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VfwFormatDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                        }

                        if (_deviceSource.IsDialogSupported(ConfigurationDialog.VfwSourceDialog))
                        {
                            _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VfwSourceDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                        }

                        if (_deviceSource.IsDialogSupported(ConfigurationDialog.VfwDisplayDialog))
                        {
                            _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VfwDisplayDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                        }

                    }
                    else
                    {
                        // No
                        if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoCapturePinDialog))
                        {
                            _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoCapturePinDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                        }

                        if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoCaptureDialog))
                        {
                            _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoCaptureDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                        }

                        if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoCrossbarDialog))
                        {
                            _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoCrossbarDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                        }

                        if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoPreviewPinDialog))
                        {
                            _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoPreviewPinDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                        }

                        if (_deviceSource.IsDialogSupported(ConfigurationDialog.VideoSecondCrossbarDialog))
                        {
                            _deviceSource.ShowConfigurationDialog(ConfigurationDialog.VideoSecondCrossbarDialog, (new HandleRef(panelVideoPreview, panelVideoPreview.Handle)));
                        }
                    }
                }
                else
                {
                    // No
                    // Setup the video resolution and frame rate of the video device
                    // NOTE: Of course, the resolution and frame rate you specify must be supported by the device!
                    // NOTE2: May be not all video devices support this call, and so it just doesn't work, as if you don't call it (no error is raised)
                    // NOTE3: As a workaround, if the .PickBestVideoFormat method doesn't work, you could force the resolution in the 
                    //        following instructions (called few lines belows): 'panelVideoPreview.Size=' and '_job.OutputFormat.VideoProfile.Size=' 
                    //        to be the one you choosed (640, 480).
                    _deviceSource.PickBestVideoFormat(new Size(640, 480), 15);
                }

                // Get the properties of the device video
                SourceProperties sp = _deviceSource.SourcePropertiesSnapshot();

                // Resize the preview panel to match the video device resolution set
                panelVideoPreview.Size = new Size(sp.Size.Width, sp.Size.Height);

                // Setup the output video resolution file as the preview
                _job.OutputFormat.VideoProfile.Size = new Size(sp.Size.Width, sp.Size.Height);



                // Sets preview window to winform panel hosted by xaml window
                _deviceSource.PreviewWindow = new PreviewWindow(new HandleRef(panelVideoPreview, panelVideoPreview.Handle));

                // Make this source the active one
                _job.ActivateSource(_deviceSource);


                button3.Enabled = true;


            }
        }
        private void Uslikaj_Click(object sender, EventArgs e)
        {
            lstAudioDevices.Visible = true;
            lstVideoDevices.Visible = true;
            panelVideoPreview.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Create a Bitmap of the same dimension of panelVideoPreview (Width x Height)
                using (Bitmap bitmap = new Bitmap(panelVideoPreview.Width, panelVideoPreview.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        // Get the paramters to call g.CopyFromScreen and get the image
                        Rectangle rectanglePanelVideoPreview = panelVideoPreview.Bounds;
                        Point sourcePoints = panelVideoPreview.PointToScreen(new Point(panelVideoPreview.ClientRectangle.X, panelVideoPreview.ClientRectangle.Y));
                        g.CopyFromScreen(sourcePoints, Point.Empty, rectanglePanelVideoPreview.Size);
                    }

                    string strGrabFileName = String.Format("C:\\Users\\DebilMC\\Desktop\\SystemBetSlike\\Snapshot_{0:yyyyMMdd_hhmmss}.jpg", DateTime.Now);
                    bitmap.Save(strGrabFileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    slika = strGrabFileName;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
