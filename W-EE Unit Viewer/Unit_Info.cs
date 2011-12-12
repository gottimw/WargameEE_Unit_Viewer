using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;

namespace W_EE_Unit_Viewer
{
    class Unit_Info
    {
        private bool doubleName;                /* true if image of unit contains 2 lines */
        private int top, bottom, left, right;   /* margin distances*/
        private Image unitImage;                /* image handler*/
        private BitmapImage bitMap;             /* raw bitmap used for image generation from given uri */
        private string fileUri;                    /* path to file */
        private int zIndex;

        public Unit_Info(string pathToFile, bool isDoubleName, int z, int topMargin, StackPanel imageStackHolder)
        {
            unitImage = new Image();               
            bitMap = new BitmapImage();
            bitMap.BeginInit();
            bitMap.UriSource = new Uri(pathToFile, UriKind.RelativeOrAbsolute);
            bitMap.CacheOption = BitmapCacheOption.OnLoad;
            bitMap.EndInit();
            unitImage.Source = bitMap;
            unitImage.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            unitImage.Margin = new Thickness(0, topMargin, 0, 0);
            imageStackHolder.Children.Add(unitImage);
            Grid.SetColumn(unitImage, 1);
            Grid.SetRow(unitImage, 1);
            Canvas.SetZIndex(unitImage, z);
        }

        //SETS AND GETS
        public void setZIndex(int val){ zIndex = val;}
        public int getZIndex(){ return zIndex;}

        public void setUri(string newUri){
            bitMap.BeginInit();
            bitMap.UriSource = new Uri(@newUri);
            bitMap.CacheOption = BitmapCacheOption.OnLoad;
            bitMap.EndInit();
        }
        public Image getImage(){ return unitImage;}
    }
}
