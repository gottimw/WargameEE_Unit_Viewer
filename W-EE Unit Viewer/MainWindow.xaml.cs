using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace W_EE_Unit_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(){
            InitializeComponent();
            initalGridLayout();
        }
        //      @"\Images\decks\polishGroup\logistic\BROM-ZU.png"
        //      @"/Images/decks/polishGroup/logistic/BROM-ZU.png"
        //      
        public void initalGridLayout(){
            Unit_Info unit_image = new Unit_Info(@"..\..\Images\decks\polishGroup\logistic\BROM-ZU.png",
                                                 false,
                                                 0,
                                                 0,
                                                 unitImagesStackPanel);

        }

        private void deck1_Click(object sender, RoutedEventArgs e){

        }

        private void btn_log_1_Click(object sender, RoutedEventArgs e){

        }

    }
}
