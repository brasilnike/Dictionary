using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dictionar.Models
{
    public class Cuvant : INotifyPropertyChanged
    {
        private int id;
        private string nume;
        private string descriere;
        private string categorie;
        private string imagine;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public void CopyWord(Cuvant input)
        {
            Id = input.Id;
            Nume = input.Nume;
            Descriere = input.Descriere;
            Categorie = input.Categorie;
            Imagine = input.Imagine;
        }

        public Cuvant(Cuvant input)
        {
            Id = input.Id;
            Nume = input.Nume;
            Descriere = input.Descriere;
            Categorie = input.Categorie;
            Imagine = input.Imagine;
         
        }

        public Cuvant()
        {
           
        }

        public void initializareCuvant()
        {
            Id = 0;
            Nume = "";
            Descriere = "";
            Categorie = "";
            Imagine = "";
        }

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; OnPropertyChanged("Nume"); }
        }
        public string Descriere
        {
            get { return descriere; }
            set { descriere = value; OnPropertyChanged("Descriere"); }
        }
        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; OnPropertyChanged("Categorie"); }
        }
        public string Imagine
        {
            get { return imagine; }
            set { imagine = value; OnPropertyChanged("Imagine"); }
        }
    }
}
