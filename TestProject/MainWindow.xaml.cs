using System.Windows;
using CompUIInterfaces;
using CompUIFileTree;
using CompUIFileTree.Views;

namespace TestProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IUIFileTree ifsFileTree = null;

        public MainWindow()
        {
            InitializeComponent();

            ifsFileTree = new CUITreeView();
            MainWindowGrid.Children.Add((UIElement)ifsFileTree);

            ifsFileTree.Func1();
        }
    }
}
