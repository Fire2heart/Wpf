using Microsoft.Win32;
using System;
using System.Windows;

namespace AudioVideoPlayer
{
    /*
     *       _____ _____ _____                _       _
     *      |_   _/  __ \_   _|              (_)     | |
     *        | | | /  \/ | |  ___  ___   ___ _  __ _| |
     *        | | ||      | | / __|/ _ \ / __| |/ _` | |
     *       _| |_| \__/\ | |_\__ \ (_) | (__| | (_| | |
     *      |_____\_____/ |_(_)___/\___/ \___|_|\__,_|_|
     *                   ___
     *                  |  _|___ ___ ___
     *                  |  _|  _| -_| -_|  LICENSE
     *                  |_| |_| |___|___|
     *
     * IT NEWS  <>  PROGRAMMING  <>  HW & SW  <>  COMMUNITY
     *
     * This source code is a part of online courses at IT social
     * network WWW.ICT.SOCIAL
     *
     * Feel free to use it for whatever you want, modify it and share it but
     * don't forget to keep this link in your code.
     *
     * Visit http://www.ict.social/licenses for more information
     */

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Video selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mpg; *.mpeg; *.avi; *.mp4)| *.mpg; *.mpeg; *.avi; *.mp4";
            if (openFileDialog.ShowDialog() == true)
            {
                avPlayer.Source = new Uri(openFileDialog.FileName);
            }
        }


        /// <summary>
        /// Window closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            wdwPlayer.Close();
        }


        /// <summary>
        /// Playing video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlay(object sender, RoutedEventArgs e)
        {
            avPlayer.Play();
        }


        /// <summary>
        /// Pausing video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPause(object sender, RoutedEventArgs e)
        {
            avPlayer.Pause();
        }


        /// <summary>
        /// Closing video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose(object sender, RoutedEventArgs e)
        {
            avPlayer.Close();
        }
    }
}
