using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIFFRecompressor 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            compressionMethodComboBox.SelectedItem = Properties.Settings.Default.CompressionMethod;
        }

        private EncoderValue getCompressionMethod(string method)
        {
            switch (method)
            {
                case "CCITT3":
                    return EncoderValue.CompressionCCITT3;
                case "CCITT4":
                    return EncoderValue.CompressionCCITT4;
                case "LZW":
                    return EncoderValue.CompressionLZW;
                case "RLE":
                    return EncoderValue.CompressionRle;
                case "Uncompressed":
                    return EncoderValue.CompressionNone;
                default:
                    return EncoderValue.CompressionLZW;
            }
        }

        private void recompress(string input, string output, ImageCodecInfo codecInfo, EncoderValue compressionMethod)
        {
            FileStream filestream = new FileStream(input, FileMode.Open, FileAccess.Read);
            Bitmap bitmap = new Bitmap(filestream);
            FileStream filestream2 = new FileStream(output, FileMode.Create, FileAccess.Write);
            EncoderParameter encoderParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (long)compressionMethod);
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = encoderParameter;
            bitmap.Save(filestream2, codecInfo, encoderParameters);
            filestream2.Close();
            progressBar1.BeginInvoke(new MethodInvoker(() => progressBar1.PerformStep()));
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.ShowDialog();
            inputTextbox.Text = folderBrowserDialog.SelectedPath;
        }

        private void browseOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            folderBrowserDialog.ShowDialog();
            outputTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void RecompressButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Enabled = false;
            outputTextBox.Enabled = false;
            browseInput.Enabled = false;
            browseOutput.Enabled = false;
            compressionMethodComboBox.Enabled = false;
            RecompressButton.Enabled = false;
            Directory.CreateDirectory(outputTextBox.Text);
            EncoderValue compressionMethod = getCompressionMethod(compressionMethodComboBox.SelectedItem.ToString());
            System.Threading.Thread thread = new System.Threading.Thread(() => threadCode(compressionMethod));
            thread.Start();
        }
        private void threadCode(EncoderValue compressionMethod)
        {
            List<string> ItemsToProcess = new List<string>();
            
            ImageCodecInfo codecInfo = GetEncoderInfo("image/tiff");
            if (Directory.Exists(inputTextbox.Text))
            {
                foreach (string file in Directory.GetFiles(inputTextbox.Text))
                {
                    if (Path.GetExtension(file) == ".tiff" || Path.GetExtension(file) == ".tif")
                        ItemsToProcess.Add(file);
                }

                progressBar1.BeginInvoke(new MethodInvoker(() =>
                {
                    progressBar1.Maximum = ItemsToProcess.Count();
                    progressBar1.Value = 0;
                }));

                List<Action> tasks = new List<Action>();
                for (int i = 0; i <= ItemsToProcess.Count() - 1; i++)
                {
                    string inputPath = ItemsToProcess[i];
                    string OutputPath = outputTextBox.Text + @"\" + Path.GetFileName(ItemsToProcess[i]);
                    if (!File.Exists(OutputPath))
                    {
                        tasks.Add(() => recompress(inputPath, OutputPath, codecInfo, compressionMethod));
                    }
                }
                Parallel.Invoke(new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, tasks.ToArray());
                RecompressButton.BeginInvoke(new MethodInvoker(() =>
                {
                    RecompressButton.Enabled = true;
                    inputTextbox.Enabled = true;
                    outputTextBox.Enabled = true;
                    browseInput.Enabled = true;
                    browseOutput.Enabled = true;
                    compressionMethodComboBox.Enabled = true;
                }));
                MessageBox.Show("Recompression finished!");
            }
        }

        private void compressionMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CompressionMethod = compressionMethodComboBox.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
