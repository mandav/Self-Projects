using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;
using System.Data;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;

namespace Watermark_POC
{
    /// <summary>
    /// Interaction logic for WatermarkManager.xaml
    /// </summary>
    public partial class WatermarkManager : Window
    {
        string watermarkText, color, orientation,typeface,currentFile;
        int fontsize,count1,count2;
        decimal opacity;
        Image im = new Image();
        Brush foregroundColor, foreground;
        Point point;
        SaveFileDialog SaveFileDialog1 = new SaveFileDialog();

        public WatermarkManager(ImageDb img)
        {
            InitializeComponent();
            currentFile = img.Title;
            ImgWm.Source = img.picture;
            List<int> size=new List<int>();
            for(int i=0;i<100;i++)
            {
                size.Add(i);
            }
            cmbFontSize.ItemsSource = size;
            System.Windows.MessageBox.Show("Kindly use preview button to show the watermark on the Image");
        }

//Getting Orientation

        public void rdbtn_Checked(object sender, RoutedEventArgs e)
        {
            var button = sender as System.Windows.Controls.RadioButton;
            orientation = button.Content.ToString();
        }

//Setting up the Preview

        private void btnPreview_Click(object sender, RoutedEventArgs e)
        {

            if (count2 == 0)
            {
                im.Source = ImgWm.Source;
                ImgWm.Source = drawWatermark(im);
                count2++;
            }
            else
            {
                ImgWm.Source = drawWatermark(im);
            }

        }
        public DrawingImage drawWatermark(Image img)
        {
            Image im = img;
            typeface = cmbFontFamily.SelectedItem.ToString();
            watermarkText = txtWaterMarkText.Text;
            color = Font_Color.SelectedColorText.ToString();
            fontsize = Convert.ToInt32(cmbFontSize.SelectedValue.ToString()) * 3;
            opacity = decimal.Round((Convert.ToDecimal(slider_Opacity.Value.ToString()) / 100), 2);
            foregroundColor = new BrushConverter().ConvertFromString(color) as SolidColorBrush;
            foreground = foregroundColor.Clone();
            foreground.Opacity = (double)opacity;
            switch (orientation)
            {
                case "Top":
                    point = new Point(im.Source.Width / 2 - fontsize, 0);
                    break;
                case "Top Left":
                    point = new Point(0, 0);
                    break;
                case "Top Right":
                    point = new Point(im.Source.Width, 0);
                    break;
                case "Left":
                    point = new Point(0, im.Source.Height / 2 - fontsize);
                    break;
                case "Center":
                    point = new Point(im.Source.Width / 2 - fontsize, im.Source.Height / 2 - fontsize);
                    break;
                case "Right":
                    point = new Point(im.Source.Width, im.Source.Height / 2 - fontsize);
                    break;
                case "Bottom Left":
                    point = new Point(0, im.Source.Height - fontsize * 1.2);
                    break;
                case "Bottom":
                    point = new Point(im.Source.Width / 2 - fontsize, im.Source.Height - fontsize * 1.2);
                    break;
                case "Bottom Right":
                    point = new Point(im.Source.Width, im.Source.Height - fontsize * 1.2);
                    break;
                default:
                    point = new Point(0, 0);
                    break;
            }
            var visual = new DrawingVisual();
            if (orientation.Equals("Bottom Right") || orientation.Equals("Right") || orientation.Equals("Top Right"))
            {
                using (DrawingContext drawingContext = visual.RenderOpen())
                {
                    drawingContext.DrawImage(im.Source, new Rect(0, 0, im.Source.Width, im.Source.Height));
                    drawingContext.DrawText(new FormattedText(watermarkText, CultureInfo.InvariantCulture, System.Windows.FlowDirection.RightToLeft, new Typeface(typeface), fontsize, foreground), point);
                }
            }
            else
            {
                using (DrawingContext drawingContext = visual.RenderOpen())
                {
                    drawingContext.DrawImage(im.Source, new Rect(0, 0, im.Source.Width, im.Source.Height));
                    drawingContext.DrawText(new FormattedText(watermarkText, CultureInfo.InvariantCulture, System.Windows.FlowDirection.LeftToRight, new Typeface(typeface), fontsize, foreground), point);
                    drawingContext.Close();
                }
            }
            var image = new DrawingImage(visual.Drawing);
            return image;
        }

       
//Saving the File

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // get the extension to figure out how to limit the save
                // option to the current image file type
                btnPreview_Click(sender, e);
                string strExt;
                strExt = System.IO.Path.GetExtension(currentFile);
                strExt = strExt.ToUpper();
                strExt = strExt.Remove(0, 1);
                SaveFileDialog1.Title = "Save File";
                SaveFileDialog1.DefaultExt = strExt;
                SaveFileDialog1.Filter = "Bitmap Files|*.bmp"+
                "|Gif Files|*.gif|"+"Jpeg Files|*.jpg" +
                "|Png Files|*.png";
                if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (SaveFileDialog1.FileName == "")
                    {
                        return;
                    }
                    else
                    {
                        // save the file with the name supplied by the user
                         
                         switch (SaveFileDialog1.FilterIndex)
                         {
                             case 1:
                                 SaveToBmp(ImgWm, SaveFileDialog1.FileName);
                                 break;
                             case 2:
                                 SaveToGif(ImgWm, SaveFileDialog1.FileName);
                                 break;
                             case 3:
                                 SaveToJpg(ImgWm, SaveFileDialog1.FileName);
                                 break;
                             case 4:
                                 SaveToPng(ImgWm, SaveFileDialog1.FileName);
                                 break;
                         }
                    }

                    // update the current image file to point to the newly saved
                    // image
                    currentFile = SaveFileDialog1.FileName;
                    System.Windows.MessageBox.Show(currentFile.ToString() + " saved. ", " File Save ");
                }
                else
                {
                    System.Windows.MessageBox.Show("The save file request was cancelled by user.", "Save Cancelled");
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message.ToString(), "Image Save Error");
            }
        }

        private void slider_Opacity_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (count1!=0)
            {
                lblOpacityValue.Content = slider_Opacity.Value.ToString();
            }
            count1++;
        }
        
//Saving to different Formats
        void SaveToBmp(Image visual, string fileName)
        {
            var encoder = new BmpBitmapEncoder();
            SaveUsingEncoder(visual, fileName, encoder);
        }

        void SaveToPng(Image visual, string fileName)
        {
            var encoder = new PngBitmapEncoder();
            SaveUsingEncoder(visual, fileName, encoder);
        }
        void SaveToJpg(Image visual, string fileName)
        {
            var encoder = new JpegBitmapEncoder();
            SaveUsingEncoder(visual, fileName, encoder);
        }

        void SaveToGif(Image visual, string fileName)
        {
            var encoder = new GifBitmapEncoder();
            SaveUsingEncoder(visual, fileName, encoder);
        }

        void SaveUsingEncoder(Image image, string fileName, BitmapEncoder encoder)
        {
            Grid r = new Grid();
            r.Background = new ImageBrush(image.Source);

            Size sz = new Size(image.Source.Width, image.Source.Height);
            r.Measure(sz);
            r.Arrange(new Rect(sz));

            RenderTargetBitmap rtb = new RenderTargetBitmap((int)image.Source.Width, (int)image.Source.Height, 96d, 96d, PixelFormats.Default);
            rtb.Render(r);

            BitmapFrame frame = BitmapFrame.Create(rtb);
            encoder.Frames.Add(frame);

            using (var stream = File.Create(fileName))
            {
                encoder.Save(stream);
            }
           
        }
    }
}

