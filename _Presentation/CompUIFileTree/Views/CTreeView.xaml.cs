using System.Windows;
using System.Windows.Controls;
using CompUIInterfaces;

namespace CompUIFileTree.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class CUITreeView : UserControl, IUIFileTree
    {
        public CUITreeView()
        {
            InitializeComponent();
        }

        public void Func1()
        {
            MessageBox.Show("³ª´Â ºýºýÀÌ´Ù.");
        }
    }
}