using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Task2 : Form
    {
        string selectedFileName;
        List<Image> colorImages;
        List<Image> barCharts;

        void GetColorImagesAndBarCharts(Image source, out List<Image> colorImages, out List<Image> barCharts)
        {
            Bitmap sourceBitmap = new Bitmap(source);

            Bitmap redBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            Bitmap greenBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            Bitmap blueBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            int[] redColors = new int[256];
            int[] greenColors = new int[256];
            int[] blueColors = new int[256];

            for (int i = 0; i < 256; i++)
            {
                redColors[i] = 0;
                greenColors[i] = 0;
                blueColors[i] = 0;
            }

            for (int x = 0; x < sourceBitmap.Width; x++)
            {
                for (int y = 0; y < sourceBitmap.Height; y++)
                {
                    Color color = sourceBitmap.GetPixel(x, y);

                    //данные для гистограммы
                    redColors[color.R]++;
                    greenColors[color.G]++;
                    blueColors[color.B]++;

                    //пиксели результирующих картинок R,G,B
                    redBitmap.SetPixel(x, y, Color.FromArgb(color.R, 0, 0));
                    greenBitmap.SetPixel(x, y, Color.FromArgb(0, color.G, 0));
                    blueBitmap.SetPixel(x, y, Color.FromArgb(0, 0, color.B));
                }
            }
            
            sourceBitmap.Dispose();

            colorImages = new List<Image> { redBitmap, greenBitmap, blueBitmap };

            int maxR = redColors.Max();
            int maxG = greenColors.Max();
            int maxB = blueColors.Max();

            Bitmap redBarChart = new Bitmap(512, 200);
            Bitmap greenBarChart = new Bitmap(512, 200);
            Bitmap blueBarChart = new Bitmap(512, 200);

            Graphics graphicsR = Graphics.FromImage(redBarChart);
            Graphics graphicsG = Graphics.FromImage(greenBarChart);
            Graphics graphicsB = Graphics.FromImage(blueBarChart);

            Pen penR = new Pen(Color.Red, 2);
            Pen penG = new Pen(Color.Green, 2);
            Pen penB = new Pen(Color.Blue, 2);

            for (int x = 0; x < 512; x += 2)
            {
                int heightR = (int)(200.0 * redColors[x / 2] / maxR);
                int heightG = (int)(200.0 * greenColors[x / 2] / maxG);
                int heightB = (int)(200.0 * blueColors[x / 2] / maxB);

                graphicsR.DrawRectangle(penR, x, 200 - heightR, 2, heightR);
                graphicsG.DrawRectangle(penG, x, 200 - heightG, 2, heightG);
                graphicsB.DrawRectangle(penB, x, 200 - heightB, 2, heightB);
            }

            //освобождаем ресурсы
            penR.Dispose();
            penG.Dispose();
            penB.Dispose();
            graphicsR.Dispose();
            graphicsG.Dispose();
            graphicsB.Dispose();

            barCharts = new List<Image> { redBarChart, greenBarChart, blueBarChart };
        }

        void ShowSourceImage()
        {
            if (selectedFileName != null)
            {
                Image sourceImage = Image.FromFile(selectedFileName);
                sourcePictureBox.Image = sourceImage;
                resultPictureBox.Image = null;
                barChartPictureBox.Image = null;
                //сохраняем в памяти все цветные изображения и гистограммы
                GetColorImagesAndBarCharts(sourceImage, out colorImages, out barCharts); 
            }
            else
            {
                sourcePictureBox.Image = null;
                resultPictureBox.Image = null;
                barChartPictureBox.Image = null;
                colorImages = null;
                barCharts = null;
            }
        }

        public Task2()
        {
            InitializeComponent();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedFileName = dialog.FileName;
                filePathLabel.Text = selectedFileName;
                colorComboBox.SelectedIndex = 0;
            }
            else
            {
                selectedFileName = null;
            }
            dialog.Dispose();
            ShowSourceImage();
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorImages == null) return;
            if (colorComboBox.SelectedIndex == 0)
            {
                resultPictureBox.Image = null;
                barChartPictureBox.Image = null;
            }
            else
            {
                resultPictureBox.Image = colorImages[colorComboBox.SelectedIndex - 1];
                barChartPictureBox.Image = barCharts[colorComboBox.SelectedIndex - 1];
            }
        }
    }
}
