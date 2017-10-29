using System.ComponentModel;

namespace Strikeometer_Upload
{
    public class UploadDetails : INotifyPropertyChanged
    {
        private string _touchName;
        private string _touchURL;

        public string TouchName
        {
            get => _touchName;
            set
            {
                _touchName = value;
                RaisePropertyChanged("TouchName");
            }
        }

        public string TouchURL
        {
            get => _touchURL;
            set
            {
                _touchURL = value;
                RaisePropertyChanged("TouchURL");
            }
        }

        public UploadDetails(string touchName, string touchUrl)
        {
            TouchName = touchName;
            TouchURL = touchUrl;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}