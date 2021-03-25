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
using Dictionar.Views;
using System.Windows.Interactivity;
namespace Dictionar.ViewModels
{
    class ModCautareCuvinteViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        static private ObservableCollection<Cuvant> _listaCuvinte;
        static string filePath = @"D:\Cursuri\Anul 2\Semestrul II\Medii Vizuale de Programare\Tema 1\Dictionar\Dictionar\Resources\lista.json";
        static string text = File.ReadAllText(filePath);
        private static ObservableCollection<Cuvant> ObjCuvantList = JsonConvert.DeserializeObject<ObservableCollection<Cuvant>>(text);
        private Cuvant cuvantCurent;
        private List<Cuvant> listaCuvantDinCategorie;
        private ObservableCollection<Cuvant> listaCuvinteScrise = new ObservableCollection<Cuvant>();
        private string textScris;
        private Cuvant cuvantAles = new Cuvant();

        public ObservableCollection<Cuvant> ListaCuvinteScrise
        {
            get { return listaCuvinteScrise; }
            set { listaCuvinteScrise = value;
                foreach (Cuvant i in ListaCuvinteScrise)
                {
                    Console.WriteLine(i.Nume);
                }
            }
        }

        public Cuvant CuvantAles
        {
            set { cuvantAles = value; OnPropertyChanged("CuvantAlex"); Console.WriteLine(cuvantAles.Nume); }
            get { return cuvantAles; }
        }

        public string TextScris
        {
            get { return textScris; }
            set 
            { textScris = value; 
              OnPropertyChanged("TextScris");
                listaCuvinteScrise.Clear();
                foreach(Cuvant item in listaCuvantDinCategorie)
                {
                    bool ok = true;
                    for(int i = 0; i < textScris.Length; i++)
                    {
                        if (textScris.Length <= item.Nume.Length)
                        {
                            if (textScris[i] != item.Nume[i])
                            {
                                ok = false;
                            }
                        }
                        else 
                        {
                            ok = false;
                        }
                    }
                    if(ok==true)
                    {
                        listaCuvinteScrise.Add(item);
                    }                 
                }
                foreach (Cuvant item in listaCuvinteScrise) 
                {
                    Console.WriteLine(item.Nume);
                }
            }
        }




        public List<Cuvant> ListaCuvantDinCategorie
        {
            get { return listaCuvantDinCategorie; }
        }



        public Cuvant cuvantCurentProperty
        {
            get { return cuvantCurent; }
            set { cuvantCurent = value; OnPropertyChanged("cuvantCurentProperty"); }
        }

        private string categorieSelectata;

        public string CategorieSelectata
        {
            get { return categorieSelectata; }
            set { categorieSelectata = value;
                listaCuvantDinCategorie = new List<Cuvant>();
                foreach (Cuvant item in _listaCuvinte)
                {
                    if(item.Categorie == categorieSelectata)
                    {
                        listaCuvantDinCategorie.Add(item);
                    }
                }

                OnPropertyChanged("CategorieSelectata"); }
        }


        public List<string> categorieProprietate
        {
            get
            {
                List<string> aux = new List<string>();
                foreach (Cuvant i in _listaCuvinte)
                {
                    aux.Add(i.Categorie);
                }
                return aux.Distinct().ToList(); 
            }
        }

        public ModCautareCuvinteViewModel()
        {
            cuvantCurent = new Cuvant();
            _listaCuvinte = ObjCuvantList;
            //comUpdate = new Comenzi(Upd);
            //comAdauga = new Comenzi(adauga);
            //comStergere = new Comenzi(sterge);
        }

        public ObservableCollection<Cuvant> Cuvintele
        {
            get { return _listaCuvinte; }
            set { _listaCuvinte = value; }
        }

        /*private Comenzi comUpdate;

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
        */
        /*public void Upd()
        {
            foreach (Cuvant cuvant in listaCuvinteScrise)
            {
                Console.WriteLine(cuvant.Nume);
            }

        }

        public void adauga()
        {
            Console.WriteLine("DA");
            _listaCuvinte.Add(cuvantCurent);
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
        }*/

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
