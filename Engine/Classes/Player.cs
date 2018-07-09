﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine.Classes
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _characterClass;
        private int _hitpoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        public string CharacterClass { get { return _characterClass; } set { _characterClass = value; OnPropertyChanged(nameof(CharacterClass)); } }
        public int Hitpoints { get { return _hitpoints; } set { _hitpoints = value; OnPropertyChanged(nameof(Hitpoints)); } }
        public int ExperiencePoints { get { return _experiencePoints; } set { _experiencePoints = value; OnPropertyChanged(nameof(ExperiencePoints)); } }
        public int Level { get { return _level; } set { _level = value; OnPropertyChanged(nameof(Level)); } }
        public int Gold { get { return _gold; } set { _gold = value; OnPropertyChanged(nameof(Gold)); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
