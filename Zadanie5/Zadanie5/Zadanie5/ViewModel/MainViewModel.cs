using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Xml;
using System.Xml.Serialization;

namespace Zadanie5.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public wypo¿yczalnia RentalCars
        {
            get { return _rentalCars; }
            set
            {
                if(value != _rentalCars)
                {
                    _rentalCars = value;
                    RaisePropertyChanged("RentalCars");
                }
            }
        }

        public int SelectedCar
        {
            get { return _selectedCar; }
            set
            {
                if(value != _selectedCar)
                {
                    _selectedCar = value;
                    RaisePropertyChanged("SelectedCar")
;                }
            }
        }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(wypo¿yczalnia));
            RentalCars = (wypo¿yczalnia)serializer.Deserialize(new XmlTextReader("../../Documents/zadanie5.xml"));

            SelectedCar = -1;
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        public ICommand DeleteCar => _deleteCar ?? (_deleteCar = new RelayCommand(() => 
        {
            //TODO: zamieniæ tablice na jak¹œ sensown¹ liste a nie jakieœ gunwo
        }));

        private ICommand _deleteCar;

        private wypo¿yczalnia _rentalCars;

        private int _selectedCar;
    }
}