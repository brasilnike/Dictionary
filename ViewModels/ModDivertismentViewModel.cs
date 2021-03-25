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
using StatsdClient;
using System.Windows;
namespace Dictionar.ViewModels
{
    class ModDivertismentViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        static private ObservableCollection<Cuvant> _listaCuvinte;
        static string filePath = @"D:\Cursuri\Anul 2\Semestrul II\Medii Vizuale de Programare\Tema 1\Dictionar\Dictionar\Resources\lista.json";
        static string text = File.ReadAllText(filePath);
        private static ObservableCollection<Cuvant> ObjCuvantList = JsonConvert.DeserializeObject<ObservableCollection<Cuvant>>(text);
        private Cuvant cuvantCurent = new Cuvant();
        private List<Cuvant> lista5Cuvinte;
        private int index = 0;
        private Visibility ascundeStart;
        private List<string> nume;
        private string scris;
        private int raspunsuriCorecte = 0;

        public string Scris
        {
            get { return scris; }
            set { scris = value; OnPropertyChanged("Scris"); }
        }


        public List<string> Nume
        {
            get { return nume; }
            set { nume = value; OnPropertyChanged("Nume"); }
        }


        public Visibility AscundeStart
        {
            get { return ascundeStart; }
            set { ascundeStart = value; OnPropertyChanged("AscundeStart"); }
        }

        public Cuvant CuvantCurent
        {
            get { return cuvantCurent; }
            set
            {
                if (index == 5)
                {
                    Console.WriteLine("ok");
                }
                cuvantCurent = value; OnPropertyChanged("CuvantCurent");
            }
        }

        public List<Cuvant> Lista5Cuvinte
        {
            get { return lista5Cuvinte; }
            set { lista5Cuvinte = value; OnPropertyChanged("Lista5Cuvinte"); }
        }

        public ModDivertismentViewModel()
        {
            lista5Cuvinte = new List<Cuvant>();
            _listaCuvinte = ObjCuvantList;
            nume = new List<string>();
            cuvantCurent = new Cuvant();
            comStart = new Comenzi(Upd);
            comNext = new Comenzi(Next);
            comFinish = new Comenzi(Finish);
        }

        public ObservableCollection<Cuvant> Cuvintele
        {
            get { return _listaCuvinte; }
            set { _listaCuvinte = value; }
        }

        private Comenzi comStart;

        public Comenzi ComStart
        {
            get { return comStart; }
            set { comStart = value; }
        }
        private Comenzi comNext;

        public Comenzi ComNext
        {
            get { return comNext; }
        }

        private Comenzi comFinish;

        public Comenzi ComFinish
        {
            get { return comFinish; }
            set { comFinish = value; }
        }

        public void Upd()
        {
            var rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                int aux = rand.Next(_listaCuvinte.Count);
                int imgStr = rand.Next(5);
                Cuvant c = new Cuvant(_listaCuvinte[aux]);
                if (imgStr % 2 == 0)
                {
                    c.Descriere = "";
                }
                else
                {
                    c.Imagine = ""; 
                }
                lista5Cuvinte.Add(c);
                nume.Add(c.Nume);
            }
            foreach (Cuvant elem in lista5Cuvinte)
            {
                Console.WriteLine(elem.Nume);
            }
            cuvantCurent.CopyWord(lista5Cuvinte[index++]);

            AscundeStart = Visibility.Hidden;
        }

        public void Next()
        {
            if (scris == cuvantCurent.Nume)
            {
                MessageBox.Show("Corect!");
                raspunsuriCorecte++;
            }
            else
            {
                MessageBox.Show(string.Format("Raspunsul corect este: {0}", cuvantCurent.Nume));
            }
            if (index < 5)
            {
                cuvantCurent.CopyWord(lista5Cuvinte[index++]);
            }
        }

        public void Finish()
        {
            cuvantCurent = new Cuvant();
            MessageBox.Show(string.Format("Ati raspuns corect la {0} intrebari.", raspunsuriCorecte));
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
