using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using Dictionar.Models;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows;
using Newtonsoft.Json;
using System.IO;
using Dictionar.Commands;
using System.Collections.ObjectModel;
using System.Windows;
using Microsoft.Win32;

namespace Dictionar.ViewModels
{
    class ModAdministrativViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static ObservableCollection<Cuvant> _listaCuvinte;
        static string filePath = @"D:\Cursuri\Anul 2\Semestrul II\Medii Vizuale de Programare\Tema 1\Dictionar\Dictionar\Resources\lista.json";
        static string text = File.ReadAllText(filePath);
        private static ObservableCollection<Cuvant> ObjCuvantList = JsonConvert.DeserializeObject<ObservableCollection<Cuvant>>(text);
        private Cuvant cuvantCurent;
        int index = 1;

        public Cuvant cuvantCurentProperty
        {
            get { return cuvantCurent; }
            set { cuvantCurent = value; OnPropertyChanged("cuvantCurentProperty"); }
        }


        public ModAdministrativViewModel()
        {
            cuvantCurent = new Cuvant();
            _listaCuvinte = ObjCuvantList;
            comUpdate = new Comenzi(Upd);
            comAdauga = new Comenzi(adauga);
            comStergere = new Comenzi(sterge);
        }

        public ObservableCollection<Cuvant> Cuvintele
        {
            get { return _listaCuvinte; }
            set { _listaCuvinte = value; OnPropertyChanged("Cuvintele"); }
        }

        private Comenzi comUpdate;

        public Comenzi ComUpdate
        {
            get { return comUpdate; }
            set { comUpdate = value; }
        }
        private Comenzi comStergere;

        public Comenzi ComStergere
        {
            get { return comStergere; }
            set { comStergere = value; }
        }

        private Comenzi comAdauga;

        public Comenzi ComAdauga
        {
            get { return comAdauga; }
            set { comAdauga = value; }
        }

        public void Upd()
        {
            
            Console.WriteLine("DA");
            foreach (Cuvant cuvant in _listaCuvinte)
            {
                if(cuvantCurent.Id == cuvant.Id)
                {
                    cuvant.Descriere = cuvantCurent.Descriere;
                    cuvant.Nume = cuvantCurent.Nume;
                    cuvant.Categorie = cuvantCurent.Categorie;
                    cuvant.Imagine = cuvantCurent.Imagine;       
                    if(cuvantCurent.Imagine==null)
                    {
                        cuvant.Imagine = "C:\\Users\\dany_\\Downloads\\no.jpg";
                    }
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(_listaCuvinte, Newtonsoft.Json.Formatting.Indented);
                    Console.WriteLine(output);
                    File.WriteAllText(filePath, output);
                    cuvantCurentProperty.initializareCuvant();
                    break;
                }
            }
            
        }
 
        public void adauga()
        {
            if (cuvantCurent.Imagine == null)
            {
                cuvantCurent.Imagine = "C:\\Users\\dany_\\Downloads\\no.jpg";
            }
            _listaCuvinte.Add(new Cuvant(cuvantCurent));
            cuvantCurentProperty.initializareCuvant();
            //List<Cuvant> aux = new List<Cuvant>();
            //aux = _listaCuvinte.OrderBy(o => o.Id).ToList();
            //aux.Sort();
            //Console.WriteLine(aux[0].Id);

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(_listaCuvinte, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(output);
            File.WriteAllText(filePath, output);
        }

        public void sterge()
        {
            Console.WriteLine("DA");
            foreach (Cuvant cuvant in _listaCuvinte)
            {
                if (cuvantCurent.Id == cuvant.Id)
                {
                    _listaCuvinte.Remove(cuvant);
                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(_listaCuvinte, Newtonsoft.Json.Formatting.Indented);
                    Console.WriteLine(output);
                    File.WriteAllText(filePath, output);
                    break;
                }
            }
        }

         ICommand _loadImageCommand;
    public ICommand LoadImageCommand
    {
        get
        {
            if (_loadImageCommand == null)
            {
                _loadImageCommand = new RelayCommand(param => LoadImage());
            }
            return _loadImageCommand;
        }
    }

    private void LoadImage()
    {
        OpenFileDialog open = new OpenFileDialog();
        open.DefaultExt = (".png");
        open.Filter = "Pictures (*.jpg;*.gif;*.png)|*.jpg;*.gif;*.png";

        if (open.ShowDialog() == true)
            cuvantCurent.Imagine = open.FileName;
    }


        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
