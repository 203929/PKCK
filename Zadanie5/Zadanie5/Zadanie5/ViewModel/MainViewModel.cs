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
                    RaisePropertyChanged("SelectedCar");
                }
            }
        }

        public int SelectedRental
        {
            get { return _selectedRental; }
            set
            {
                if (value != _selectedRental)
                {
                    _selectedRental = value;
                    RaisePropertyChanged("SelectedCar");
                }
            }
        }

        public int SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                if (value != _selectedEmployee)
                {
                    _selectedEmployee = value;
                    RaisePropertyChanged("SelectedCar");
                }
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
            SelectedEmployee = -1;
            SelectedRental = -1;
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        public ICommand DeleteCarCommand => _deleteCarCommand ?? (_deleteCarCommand = new RelayCommand(() => 
        {
            if(SelectedCar > -1)
                RentalCars.samochody.RemoveAt(SelectedCar);
        }));

        public ICommand AddCarCommand => _addCarCommand ?? (_addCarCommand = new RelayCommand(() =>
        {
            //
        }));
        
        public ICommand DeleteRentalCommand => _deleteRentalCommand ?? (_deleteRentalCommand = new RelayCommand(() =>
        {
            if (SelectedRental > -1)
                RentalCars.us³ugi.wypo¿yczenia.RemoveAt(SelectedRental);
        }));
        
        public ICommand AddRentalCommand => _addRentalCommand ?? (_addRentalCommand = new RelayCommand(() =>
        {
            //
        }));
        
        public ICommand DeleteEmployeeCommand => _deleteEmployeeCommand ?? (_deleteEmployeeCommand = new RelayCommand(() =>
        {
            if (SelectedEmployee > -1)
                RentalCars.us³ugi.pracownicy.RemoveAt(SelectedEmployee);
        }));
        
        public ICommand AddEmployeeCommand => _addEmployeeCommand ?? (_addEmployeeCommand = new RelayCommand(() =>
        {
            //
        }));

        private ICommand _deleteCarCommand;
        private ICommand _addCarCommand;
        private ICommand _deleteRentalCommand;
        private ICommand _addRentalCommand;
        private ICommand _deleteEmployeeCommand;
        private ICommand _addEmployeeCommand;

        private wypo¿yczalnia _rentalCars;

        private int _selectedCar;
        private int _selectedRental;
        private int _selectedEmployee;
    }
}