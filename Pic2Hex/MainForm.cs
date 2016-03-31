using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pic2Hex
{
    public partial class MainForm : Form
    {
        Random rnd;
        Image image;

        public MainForm()
        {
            InitializeComponent();

            rnd = new Random((int)DateTime.Now.Ticks);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openImageFileDialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Height = image.Height;
                pictureBox1.Width = image.Width;

                numericUpDownX.Minimum = 0;
                numericUpDownX.Maximum = image.Width * 2;
                numericUpDownX.Value = image.Width;

                numericUpDownY.Minimum = 0;
                numericUpDownY.Maximum = image.Height * 2;
                numericUpDownY.Value = image.Height;

                Conversion2BW((float)numericUpDownContrast.Value);
            }
        }

        private void Conversion2BW(float threshold)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap b1 = new Bitmap(pictureBox1.Image);
                Bitmap b2 = new Bitmap(pictureBox1.Image);

                for (int x = 0; x < b1.Size.Width; x++)
                {
                    for (int y = 0; y < b1.Size.Height; y++)
                    {
                        Color color = b1.GetPixel(x, y);
                        float col = color.GetBrightness();
                        Color newColor;
                        if (col < threshold)
                        {
                            if (col > (threshold / 2))
                            {
                                newColor = rnd.Next(0, 2) == 0 ? Color.Black : Color.White;
                            }
                            else
                            {
                                newColor = Color.Black;
                            }
                        }
                        else
                        {
                            newColor = Color.White;
                        }

                        b2.SetPixel(x, y, newColor);
                    }
                }
                pictureBox2.Image = (Image)b2;
                pictureBox2.Height = b2.Size.Height;
                pictureBox2.Width = b2.Size.Width;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                return null;
            }
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public void DoResizeImage(int width, int height)
        {
            Bitmap bmp = ResizeImage(image, width, height);
            if (bmp != null)
            {
                pictureBox1.Image = bmp;
                pictureBox1.Height = bmp.Height;
                pictureBox1.Width = bmp.Width;
                Conversion2BW((float)numericUpDownContrast.Value);
            }
        }

        private void numericUpDownContrast_ValueChanged(object sender, EventArgs e)
        {
            Conversion2BW((float)numericUpDownContrast.Value);
        }

        private void buttonGenerateHexCode_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Image);
                String str_gen = "";
                byte byt;
                int idx = 8;

                textHexCodeOutputBox.Clear();
                textHexCodeOutputBox.AppendText("Generating code...");

                for (int x = 0; x < bmp.Width; x++)
                {
                    byt = 0;
                    idx = 0;
                    for (int y = bmp.Height - 1; y >= 0; y--)
                    {
                        Color color = bmp.GetPixel(x, y);
                        if (color.GetBrightness() == 0)
                        {
                            byt |= (byte)(1 << idx);
                        }
                        idx++;
                        if (idx == 8)
                        {
                            str_gen += String.Format("0x{0:x2},", byt);
                            byt = 0;
                            idx = 0;
                        }
                    }
                    str_gen += "\n";
                }

                str_gen = str_gen.Substring(0, str_gen.LastIndexOf("\n"));
                str_gen = str_gen.Substring(0, str_gen.LastIndexOf(","));

                textHexCodeOutputBox.Clear();
                textHexCodeOutputBox.AppendText(String.Format("// Width  X:{0}\n", bmp.Width));
                textHexCodeOutputBox.AppendText(String.Format("// Height Y:{0}\n", bmp.Height));
                textHexCodeOutputBox.AppendText("static uint8_t hex_img[] = {\n");
                textHexCodeOutputBox.AppendText(str_gen);
                textHexCodeOutputBox.AppendText("\n");
                textHexCodeOutputBox.AppendText("};\n");
            }
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            DoResizeImage((int)numericUpDownX.Value, (int)numericUpDownY.Value);
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            DoResizeImage((int)numericUpDownX.Value, (int)numericUpDownY.Value);
        }
    }
}
