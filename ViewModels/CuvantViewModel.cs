using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Dictionar.Models;

namespace Dictionar.ViewModels
{
    class CuvantViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Cuvant cuvant;

        public Cuvant cuvantProperty
        {
            get { return cuvant; }
            set { cuvant = value; OnPropertyChanged("cuvantProperty"); }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public void Afisare()
        {
            try
            {
                Console.WriteLine(cuvant);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
