using System;
using System.ComponentModel;

namespace game_engine.Models
{
    public class Player : BaseNotificationClass
    {
        private string? _name, _characterClass;
        private int _hitPoints, _experiencePoints, _level, _gold;
        public string? Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string? CharacterClass
        {
            get
            {
                return _characterClass;
            }
            set
            {
                _characterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            }
        }
        public int HitPoints
        {
            get
            {
                return _hitPoints;
            }
            set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int ExperiencePoints
        {
            get
            {
                return _experiencePoints;
            }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }
        public int Gold 
        {
            get
            {
                return _gold;
            }
            set
            {
                _gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }


    }
}



