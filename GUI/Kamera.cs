﻿using System;
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
    public partial class Kamera : Form
    {
        /// <summary>
        /// Creates job for capture of live source
        /// </summary>
        private LiveJob _job;
        Clan c;
        Uposlenik o;
        /// <summary>
        /// Device for live source
        /// </summary>
        private LiveDeviceSource _deviceSource;

        private bool _bStartedRecording = false;

        public Kamera(Clan dc,Uposlenik up)
        {
            c = dc;
            o = up;
            InitializeComponent();
        }

        private void Kamera_Load(object sender, EventArgs e)
        {
            lstVideoDevices.ClearSelected();
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                lstVideoDevices.Items.Add(edv.Name);
            }
            lblVideoDeviceSelectedForPreview.Text = "";

            lstAudioDevices.ClearSelected();
            foreach (EncoderDevice eda in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                lstAudioDevices.Items.Add(eda.Name);
            }
            lblAudioDeviceSelectedForPreview.Text = "";
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            EncoderDevice video = null;
            EncoderDevice audio = null;

            GetSelectedVideoAndAudioDevices(out video, out audio);
            StopJob();

            if (video == null)
            {
                return;
            }

            // Starts new job for preview window
            _job = new LiveJob();

            // Checks for a/v devices
            if (video != null && audio != null)
            {
                // Create a new device source. We use the first audio and video devices on the system
                _deviceSource = _job.AddDeviceSource(video, audio);

                // Is it required to show the configuration dialogs ?
                if(1==2)
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

                // Display the video device properties set
                toolStripStatusLabel1.Text = sp.Size.Width.ToString() + "x" + sp.Size.Height.ToString() + "  " + sp.FrameRate.ToString() + " fps";

                // Sets preview window to winform panel hosted by xaml window
                _deviceSource.PreviewWindow = new PreviewWindow(new HandleRef(panelVideoPreview, panelVideoPreview.Handle));

                // Make this source the active one
                _job.ActivateSource(_deviceSource);

              
                btnGrabImage.Enabled = true;

                toolStripStatusLabel1.Text = "Preview activated";
            }
            else
            {
                // Gives error message as no audio and/or video devices found
                MessageBox.Show("No Video/Audio capture devices have been found.", "Warning");
                toolStripStatusLabel1.Text = "No Video/Audio capture devices have been found.";
            }
        }

        private void cmdGrabImage_Click(object sender, EventArgs e)
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
                    toolStripStatusLabel1.Text = strGrabFileName;
                    bitmap.Save(strGrabFileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    if (c.ImePrezime!="NijeClan")
                    c.Picpath = strGrabFileName;
                    if (o.ImePrezime != "NijeUposlenik")
                    o.Picpath = strGrabFileName;
                    this.Close();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Broadcast_Click(object sender, EventArgs e)
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

            _deviceSource = _job.AddDeviceSource(video, audio);
            _job.ActivateSource(_deviceSource);

            // Finds and applys a smooth streaming preset        
            _job.ApplyPreset(LivePresets.VC1256kDSL16x9);

            // Creates the publishing format for the job
            PullBroadcastPublishFormat format = new PullBroadcastPublishFormat();
            format.BroadcastPort = 8080;
            format.MaximumNumberOfConnections = 2;

            // Adds the publishing format to the job
            _job.PublishFormats.Add(format);

            // Starts encoding
            _job.StartEncoding();

            toolStripStatusLabel1.Text = "Broadcast started on localhost at port 8080, run WpfShowBroadcast.exe now to see it";
        }

        private void GetSelectedVideoAndAudioDevices(out EncoderDevice video, out EncoderDevice audio)
        {
            video = null;
            audio = null;

            lblVideoDeviceSelectedForPreview.Text = "";
            lblAudioDeviceSelectedForPreview.Text = "";

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
                    lblVideoDeviceSelectedForPreview.Text = edv.Name;
                    break;
                }
            }

            // Get the selected audio device            
            foreach (EncoderDevice eda in EncoderDevices.FindDevices(EncoderDeviceType.Audio))
            {
                if (String.Compare(eda.Name, lstAudioDevices.SelectedItem.ToString()) == 0)
                {
                    audio = eda;
                    lblAudioDeviceSelectedForPreview.Text = eda.Name;
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

        private void Kamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopJob();
        }

        private void checkBoxShowConfigDialog_CheckedChanged(object sender, EventArgs e)
        {
                    }
    }
}
