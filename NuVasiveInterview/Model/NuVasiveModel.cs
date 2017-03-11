using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuVasiveInterview.Model
{
    public class NuVasiveModel
    {
        private readonly ObservableCollection<Person> _observableCollection;
        private readonly ReadOnlyObservableCollection<Person> _observableCollectionReadOnly; // Do not allow users of this class to add or subtract from our collection except through our method(s)
       
        
        public NuVasiveModel()
        {
            _observableCollection = new ObservableCollection<Person>();
            _observableCollectionReadOnly = new ReadOnlyObservableCollection<Person>(_observableCollection);
        }

        #region Properties
        public ReadOnlyObservableCollection<Person> ObservableCollectionReadOnly
        {
            get { return _observableCollectionReadOnly; }  // make it return a readonly collection

        }
        #endregion Properties

        public void AddPersonToCollection(Person person)
        {
            _observableCollection.Add(person);
        }


    }
}
