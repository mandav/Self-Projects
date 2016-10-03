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
using System.Data;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Watermark_POC
{
    /// <summary>
    /// Interaction logic for ImageManager.xaml
    /// </summary>
    public partial class ImageManager : Window
    {
        string CurrentFile;
        ObservableCollection<ImageDb> listImg=new ObservableCollection<ImageDb>();
        List<ImageSource> images = new List<ImageSource>();
        ImageSourceConverter converter = new ImageSourceConverter();
        public ImageManager()
        {
            InitializeComponent();
            System.Windows.MessageBox.Show("Welcome to Carnival Studios-Mark it!");
        }

        private void btnAddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open Image File";
            openFileDialog1.Filter = "Bitmap Files|*.bmp" +
                "|Enhanced Windows MetaFile|*.emf" +
                "|Exchangeable Image File|*.exif" +
                "|Gif Files|*.gif|JPEG Files|*.jpg" +
                "|PNG Files|*.png|TIFF Files|*.tif|Windows MetaFile|*.wmf";
            openFileDialog1.DefaultExt = "jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            // if the user did not select a file, return
            if (openFileDialog1.FileName == "")
                return;

            // update the current file and form caption text
            CurrentFile = openFileDialog1.FileName.ToString();
            try
            {
                ImageSource imgsrc = (ImageSource)converter.ConvertFromString(CurrentFile);
                images.Add(imgsrc);
                listImg.Add(new ImageDb { Title=CurrentFile, picture=imgsrc});
                ImageListBox.ItemsSource = listImg;
               
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "File Open Error");
            }
         
        }

        private void btnAddWatermark_Click(object sender, RoutedEventArgs e)
        {
            if (ImageListBox.SelectedItem == null)
            {
                System.Windows.MessageBox.Show("Please Add Images to Continue");
            }
            else
            {
                ImageDb img = (ImageDb)ImageListBox.SelectedItem;
                WatermarkManager wm = new WatermarkManager(img);
                var newWindow = wm;
                wm.ShowDialog();
            }
        }

        private void btnSlideShow_Click(object sender, RoutedEventArgs e)
        {
            if (images.Count != 0)
            {
                SlideShow sl = new SlideShow(images);
                var newWindow = sl;
                sl.ShowDialog();
            }
            else
                System.Windows.MessageBox.Show("Add Images for SlideShow");
        }

        private void btnDeleteImage_Click(object sender, RoutedEventArgs e)
        {
            if (ImageListBox.SelectedIndex != -1)
            {
                images.RemoveAt(ImageListBox.SelectedIndex);
                listImg.RemoveAt(ImageListBox.SelectedIndex);
                
            }
            else
                System.Windows.MessageBox.Show("Kindly select an Image to delete");
        }
    }
}
