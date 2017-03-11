using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NuVasiveInterview.Model;

namespace NuVasiveInterview.ViewModel
{
    public class NuVasiveViewModel : ViewModelBase
    {
        #region Fields
        private ICommand _addPersonToCollection = null;
        private NuVasiveModel _model = new NuVasiveModel();
        private String _name;
        #endregion Fields

        #region Properties
        public String Name {
            get{
                return _name;
            }
            set {
                _name = value;
                // supply a new Person for use in Preview label and (possibly) to add to collection
                Person = new Person(_name, DateTime.Now);
                OnPropertyChanged("Name");
                OnPropertyChanged("Person");
                
            }
        }
       
        public Person Person { get; private set; }
       
        public ReadOnlyObservableCollection<Person> PeopleCollection
        {
            get
            {
                return _model.ObservableCollectionReadOnly;
            }
        }

        
        #endregion Properties

        #region Commands
        
        public ICommand AddPersonToCollection 
        {
            get
            {
                if (_addPersonToCollection == null)
                {
                    _addPersonToCollection = new RelayCommand(param => AddPersonToCollectionImplementation());
                }
                return _addPersonToCollection;
            }
        }
        #endregion Commands

        #region Private Methods
        private void AddPersonToCollectionImplementation()
        {
            if (Person != null)
            {
                _model.AddPersonToCollection(Person);
                OnPropertyChanged("PeopleCollection");  // force GUI to update anything that uses the collection
            }
        }
        #endregion 
    }
}
