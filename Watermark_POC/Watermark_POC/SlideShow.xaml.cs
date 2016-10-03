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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Collections.Specialized;
using System.Configuration;
using System.Collections.ObjectModel;

namespace Watermark_POC
{
    /// <summary>
    /// Interaction logic for SlideShow.xaml
    /// </summary>
    public partial class SlideShow : Window
    {
        private DispatcherTimer timerImageChange;
        private Image[] ImageControls;
        private List<ImageSource> Images = new List<ImageSource>();
        private static string[] TransitionEffects = new[] { "Fade" };
        private string TransitionType;
        private int CurrentSourceIndex, CurrentCtrlIndex, EffectIndex = 0, IntervalTimer = 1;

        public SlideShow(List<ImageSource> listImg)
        {
            InitializeComponent();
            IntervalTimer = Convert.ToInt32(ConfigurationManager.AppSettings["IntervalTime"]);
            ImageControls = new[] { myImage, myImage2 };

            LoadImage(listImg);

            timerImageChange = new DispatcherTimer();
            timerImageChange.Interval = new TimeSpan(0, 0, IntervalTimer);
            timerImageChange.Tick += new EventHandler(timerImageChange_Tick);
            PlaySlideShow();
            timerImageChange.IsEnabled = true;
        }


        private void LoadImage(List<ImageSource> imageSource)
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();

            Random r = new Random();

            Images.Clear();
            Images.AddRange(imageSource);
            sw.Stop();
            Console.WriteLine("Total time to load {0} images: {1}ms", Images.Count, sw.ElapsedMilliseconds);
        }


        private void timerImageChange_Tick(object sender, EventArgs e)
        {
            PlaySlideShow();
        }

        private void PlaySlideShow()
        {
            try
            {
                if (Images.Count == 0)
                    return;
                var oldCtrlIndex = CurrentCtrlIndex;
                CurrentCtrlIndex = (CurrentCtrlIndex + 1) % 2;
                CurrentSourceIndex = (CurrentSourceIndex + 1) % Images.Count;

                Image imgFadeOut = ImageControls[oldCtrlIndex];
                Image imgFadeIn = ImageControls[CurrentCtrlIndex];
                ImageSource newSource = Images[CurrentSourceIndex];
                imgFadeIn.Source = newSource;

                TransitionType = TransitionEffects[EffectIndex].ToString();

                Storyboard StboardFadeOut = (Resources[string.Format("{0}Out", TransitionType.ToString())] as Storyboard).Clone();
                StboardFadeOut.Begin(imgFadeOut);
                Storyboard StboardFadeIn = Resources[string.Format("{0}In", TransitionType.ToString())] as Storyboard;
                StboardFadeIn.Begin(imgFadeIn);
            }
            catch (Exception ex) { }
        }
    }
}
