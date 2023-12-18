using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CompUIFileTree.ViewModels
{
    public class CTreeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        //private string? _message;
        //public string? Message
        //{
        //    get => _message;
        //    set
        //    {
        //        _message = value;
        //        OnProertyChanged();
        //    }
        //}

        //private string? _message2;
        //public string? Message2
        //{
        //    get => _message2;
        //    set
        //    {
        //        _message2 = value;
        //        OnProertyChanged();
        //    }
        //}

        private void OnProertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public CTreeViewModel()
        {
            //_message = "Text";
            //_message2 = "Text2";
            BtnClickCommand = new RelayCommand(OnBtnClick, CanBtnClick);
            //Btn2ClickCommand = new RelayCommand(OnBtn2Click, CanBtn2Click);
        }

        public ICommand? BtnClickCommand { get; }

        private void OnBtnClick()
        {
            // System.Windows.Forms.dll의 Namespace System.Windows.Forms의 FolderBrowserDialog() 사용 불가 
            // PresentationFramework.dll의 Namespace Microsoft.Win32의 OpenFolderDialog() 사용 불가
            // OpenFileDialog는 사용가능하나 FileDialog이므로 기각
            // var RootFolderSelector = new OpenFileDialog();
            var RootFolderSelector = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
            RootFolderSelector.ShowDialog();
        }

        private bool CanBtnClick()
        {
            return true;
        }
    }
}
