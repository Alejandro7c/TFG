﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PlantaPiloto
{
    public class Proyect
    {
        #region Properties

        private CultureInfo _cul;

        public CultureInfo Cul
        {
            get { return _cul; }
            set
            {
                _cul = value; OnPropertyChangedProyect("Cul");
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChangedProyect("Name"); }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChangedProyect("Description"); }
        }

        private string _imagePath;

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; OnPropertyChangedProyect("ImagePath"); }
        }

        private ObservableCollection<Variable> _variables;

        public ObservableCollection<Variable> Variables
        {
            get { return _variables; }
            set { _variables = value; OnPropertyChangedProyect("Variables"); }
        }

        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; OnPropertyChangedProyect("Error"); }
        }

        #endregion

        #region Constructor

        public Proyect()
        {
            Variables = new ObservableCollection<Variable>();
        }

        public Proyect(string name, string desc, string imgPath, CultureInfo cul)
        {
            Name = name;
            Description = desc;
            ImagePath = imgPath;
            Variables = new ObservableCollection<Variable>();
            Cul = cul;
        }

        #endregion

        #region Methods

        #endregion

        #region Miembros de INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Método que actualiza la propiedad cuando esta cambia
        /// </summary>
        /// <param name="name">Propiedad a actualizar</param>
        protected void OnPropertyChangedProyect(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
