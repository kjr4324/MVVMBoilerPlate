using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System;

namespace CompUIFileTree.ViewModels
{
    public class CListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string? _message;
        public string? Message
        {
            get => _message;
            set
            {
                _message = value;
                OnProertyChanged();
            }
        }

        private string? _message2;
        public string? Message2
        {
            get => _message2;
            set
            {
                _message2 = value;
                OnProertyChanged();
            }
        }

        private void OnProertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int m_nCount;

        public CListViewModel()
        {
            m_nCount = 0;
            _message = "Text";
            _message2 = "Text2";
            BtnClickCommand = new RelayCommand(OnBtnClick, CanBtnClick);
            Btn2ClickCommand = new RelayCommand(OnBtn2Click, CanBtn2Click);
        }

        public ICommand? BtnClickCommand { get; }

        private void OnBtnClick()
        {
            m_nCount++;
            Message = "Clicked" + m_nCount.ToString();
        }

        private bool CanBtnClick()
        {
            return true;
        }

        public ICommand? Btn2ClickCommand { get; }

        private void OnBtn2Click()
        {
            m_nCount++;
            Message2 = "Clicked" + m_nCount.ToString();
        }

        private bool CanBtn2Click()
        {
            return true;
        }
    }
}
