using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Binarymission.WPF.Controls.AdvancedInteractionControls;
using Binarymission.WPF.Controls.AdvancedInteractionControls.SlideShowConstants;
using Binarymission.WPF.Controls.WindowControls;
using Binarymission.WPF.Controls.WindowControls.Enums;

namespace BinarySlideShowDemo
{
    /// <summary>
    /// Interaction logic for SlideShowDemoWindow.xaml
    /// </summary>
    public partial class SlideShowDemoWindow
    {
        private List<BinarySlideShowItem> _items;
        private List<BitmapSource> _imageList;
        private string[] _fileNames;

        public SlideShowDemoWindow()
        {
            InitializeComponent();
            ConstructObjects();
            PrepareTransitionEffectsComboBox();
            LoadImages();
            SetupControlEventsHooks();
            BuildSlidesAndSetSlidesToControlExplicitly();
            Initialize();
        }

        public static readonly DependencyProperty SlideTransitionTimerIntervalProperty = DependencyProperty.Register(
            "SlideTransitionTimerInterval", typeof(double), typeof(SlideShowDemoWindow), new PropertyMetadata(3000d));

        public double SlideTransitionTimerInterval
        {
            get { return (double)GetValue(SlideTransitionTimerIntervalProperty); }
            set { SetValue(SlideTransitionTimerIntervalProperty, value); }
        }

        private void Initialize()
        {
            DataContext = this;
            SlideShow.GoToFirstSlide();
            SlideShow.IsPaused = false;
            SlideShow.Play();
        }

        private void ConstructObjects()
        {
            _items = new List<BinarySlideShowItem>();
            _imageList = new List<BitmapSource>();
        }

        private void HandleAboutToStopSlideShow(object sender, Binarymission.WPF.Controls.AdvancedInteractionControls.SlideShowEvents.SlideShowEventArgs e)
        {
            PlayOrPause.Content = null;
            var panel = new StackPanel();
            panel.Children.Add(new Image
            {
                Width = 16,
                Height = 16,
                Source = new BitmapImage(new Uri("pack://application:,,,/;component/binarymissionImages/buttonImages/play.png"))
            });
            PlayOrPause.Content = panel;
        }

        private void HandleAboutToResumeSlideShow(object sender, Binarymission.WPF.Controls.AdvancedInteractionControls.SlideShowEvents.SlideShowEventArgs e)
        {
            PlayOrPause.Content = null;
            var panel = new StackPanel();
            panel.Children.Add(new Image
            {
                Width = 16,
                Height = 16,
                Source = new BitmapImage(new Uri("pack://application:,,,/;component/binarymissionImages/buttonImages/pause.png"))
            });
            PlayOrPause.Content = panel;
        }

        private void HandleAboutToPauseSlideShow(object sender, Binarymission.WPF.Controls.AdvancedInteractionControls.SlideShowEvents.SlideShowEventArgs e)
        {
            PlayOrPause.Content = null;
            var p = new StackPanel();
            p.Children.Add(new Image
            {
                Width = 16,
                Height = 16,
                Source = new BitmapImage(new Uri("pack://application:,,,/;component/binarymissionImages/buttonImages/play.png"))
            });
            PlayOrPause.Content = p;
        }

        private void HandleAboutToPlaySlideShow(object sender, Binarymission.WPF.Controls.AdvancedInteractionControls.SlideShowEvents.SlideShowEventArgs e)
        {
            PlayOrPause.Content = null;
            var p = new StackPanel();
            p.Children.Add(new Image
            {
                Width = 16,
                Height = 16,
                Source = new BitmapImage(new Uri("pack://application:,,,/;component/binarymissionImages/buttonImages/pause.png"))
            });
            PlayOrPause.Content = p;
            PlayOrPause.InvalidateVisual();
        }

        private void BuildSlidesAndSetSlidesToControlExplicitly()
        {
            _items.Clear();
            foreach (var t in _imageList)
            {
                var item = new BinarySlideShowItem();
                var panel = new DockPanel();
                var image = new Image { Stretch = Stretch.Fill, Source = t };
                panel.Children.Add(image);
                panel.LastChildFill = true;
                item.Content = panel;
                _items.Add(item);
            }

            SlideShow.Slides = _items;
        }

        private void SetupControlEventsHooks()
        {
            SlideShow.AboutToGoToNextSlide += HandleAboutToExecuteProgressToNextSlide;
            SlideShow.AboutToPlay += HandleAboutToPlaySlideShow;
            SlideShow.AboutToPause += HandleAboutToPauseSlideShow;
            SlideShow.AboutToResume += HandleAboutToResumeSlideShow;
            SlideShow.AboutToStop += HandleAboutToStopSlideShow;

            KeyUp += HandleSlideShowProgressRequest;
            MouseUp += HandleContinueSlideShow;
        }

        private void PrepareTransitionEffectsComboBox()
        {
            BinaryRibbonBuiltInSkinController.Skin = RibbonSkin.OfficeBlack;

            var transitions = Enum.GetNames(typeof(SlideTransitionEffect));

            foreach (var item in transitions.Select(s => new BinaryRibbonComboBoxItem
            {
                Image =
                    new BitmapImage(
                        new Uri("pack://application:,,,/;Component/binarymissionImages/16x16/gallary.png")),
                Content = s
            }))
            {
                SlideShowTransitionEffects.Items.Add(item);
            }
        }

        private static void HandleAboutToExecuteProgressToNextSlide(object sender, 
            Binarymission.WPF.Controls.AdvancedInteractionControls.SlideShowEvents.SlideShowEventArgs e)
        {
            // Do whatever you want here, before the Next() logic is executed.
            // The eventargs e gives you the currently active slide index as an extra information.
            // The SlideShowEventArgs is of type CancelEventArgs... so as part of your logic, if you wish you have a chance to cancel the about to be executed "Next" method.            
        }

        private void HandleContinueSlideShow(object sender, MouseButtonEventArgs e)
        {
            if (PlayAfterResuming.IsChecked != null && (e.LeftButton == MouseButtonState.Released && PlayAfterResuming.IsChecked.Value))
                ContinueSlideShow();
            else
                SlideShow.Next();
        }

        private void ContinueSlideShow()
        {
            if (SlideShow.IsPaused)
            {
                if (!SlideShow.IsStopped)
                    SlideShow.Resume();
            }

            if (SlideShow.IsStopped)
                SlideShow.Play();
        }

        private void HandleSlideShowProgressRequest(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:

                    if (PlayAfterResuming.IsChecked != null && PlayAfterResuming.IsChecked.Value)
                        ContinueSlideShow();
                    else
                    {
                        SlideShow.Stop();
                        SlideShow.Next();
                    }

                    break;

                case Key.Right:

                    if (PlayAfterResuming.IsChecked != null && PlayAfterResuming.IsChecked.Value)
                        SlideShow.Play();
                    else
                    {
                        SlideShow.Stop();
                        SlideShow.Next();
                    }

                    break;

                case Key.Escape:
                    SlideShow.Stop(); break;

                case Key.Up:
                case Key.Left:

                    if (PlayAfterResuming.IsChecked != null && PlayAfterResuming.IsChecked.Value)
                        SlideShow.Play();
                    else
                    {
                        SlideShow.Stop();
                        SlideShow.Previous();
                    }

                    break;

                case Key.Down:

                    if (PlayAfterResuming.IsChecked != null && PlayAfterResuming.IsChecked.Value)
                        SlideShow.Play();
                    else
                    {
                        SlideShow.Stop();
                        SlideShow.Next();
                    }

                    break;

                case Key.Space:
                    SlideShow.Pause(); break;
            }

            if (!SlideShow.IsStopped) return;

            SlideShow.Pause();
            if (MessageBoxResult.Yes == MessageBox.Show("Are you sure you want to exit the slideshow?", "Exit slideshow!", MessageBoxButton.YesNo, MessageBoxImage.Question))
                Close();
            else
                SlideShow.Resume();
        }

        private void LoadImages()
        {
            _imageList.Clear();

            if (_fileNames != null && _fileNames.Length > 0)
            {
                foreach (var item in _fileNames.Select(filename => new Uri(filename)).Select(uriSrc => new BitmapImage(uriSrc)))
                {
                    _imageList.Add(item);
                }
            }
            else
            {
                for (var i = 1; i <= 8; i++)
                {
                    var uriSrc = new Uri("pack://application:,,,/;Component/binarymissionImages/slideImages/" + i.ToString() + ".jpg");
                    var item = new BitmapImage(uriSrc);
                    _imageList.Add(item);
                }
            }
        }

        private void HandleChangeToTransitionEffectChosen(object sender, SelectionChangedEventArgs e)
        {
            var content = ((BinaryRibbonComboBoxItem)e.AddedItems[0]).Content.ToString();
            var effect =
                (SlideTransitionEffect)Enum.Parse(typeof(SlideTransitionEffect), content);

            SlideShow.SlideTransitionEffect = effect;
        }

        private void HandleOwnSlidesContentSetupRequested(object sender, RoutedEventArgs e)
        {
            var o = new Microsoft.Win32.OpenFileDialog
            {
                Title = "Choose your own images for the slide show...",
                Multiselect = true,
                Filter = "Image files (*.bmp, *.jpg, *.jpeg, *.gif, *.png)|*.bmp;*.jpg, *.jpeg, *.gif, *.png"
            };
            var result = (bool)o.ShowDialog(this);

            if (result)
            {
                _fileNames = o.FileNames;
            }

            LoadImages();
            BuildSlidesAndSetSlidesToControlExplicitly();
        }

        private void HandleTimerUsageChecked(object sender, RoutedEventArgs e)
        {
            if (SlideShow == null) return;
            SlideShow.Stop();
            PlayOrPause.IsEnabled = Stop.IsEnabled = true;
            PlayOrPause.Visibility = Stop.Visibility = Visibility.Visible;
            SlideShow.Play();
        }

        private void HandleTimerUsageUnchecked(object sender, RoutedEventArgs e)
        {
            if (SlideShow == null) return;
            SlideShow.Stop();
            PlayOrPause.IsEnabled = Stop.IsEnabled = false;
            PlayOrPause.Visibility = Stop.Visibility = Visibility.Collapsed;
        }

        private void GoToFirstSlideInvoked(object sender, EventArgs e)
        {
            SlideShow?.GoToFirstSlide();
        }

        private void GoToPreviousSlideInvoked(object sender, EventArgs e)
        {
            SlideShow?.Previous();
        }

        private void PlayOrPauseSlideInvoked(object sender, EventArgs e)
        {
            if (SlideShow == null) return;
            if (SlideShow.IsStopped || SlideShow.IsPaused)
            {
                ContinueSlideShow();
                if (SlideShow.IsStopped)
                    SlideShow.IsStopped = false;
                if (SlideShow.IsPaused)
                    SlideShow.IsPaused = false;
            }
            else
            {
                SlideShow.Pause();
            }
        }

        private void StopSlideShowInvoked(object sender, EventArgs e)
        {
            if (SlideShow == null) return;
            if (SlideShow.IsPaused || !SlideShow.IsStopped)
                SlideShow.Stop();
        }

        private void GoToNextSlideInvoked(object sender, EventArgs e)
        {
            SlideShow?.Next();
        }

        private void GoToLastSlideInvoked(object sender, EventArgs e)
        {
            SlideShow?.GoToLastSlide();
        }
    }
}
