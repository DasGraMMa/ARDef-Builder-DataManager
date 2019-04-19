using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    public class StructureData : INotifyPropertyChanged
    {
        [JsonProperty("offensive")]
        public ObservableCollection<Structure> Offensive { get => mOffensive; set => SetField(ref mOffensive, value); }
        private ObservableCollection<Structure> mOffensive;

        [JsonProperty("defensive")]
        public ObservableCollection<Structure> Defensive { get => mDefensive; set => SetField(ref mDefensive, value); }
        private ObservableCollection<Structure> mDefensive;

        [JsonProperty("traps")]
        public ObservableCollection<Structure> Traps { get => mTraps; set => SetField(ref mTraps, value); }
        private ObservableCollection<Structure> mTraps;

        [JsonProperty("ornaments")]
        public ObservableCollection<Structure> Ornaments { get => mOrnaments; set => SetField(ref mOrnaments, value); }
        private ObservableCollection<Structure> mOrnaments;

        [JsonProperty("resources")]
        public ObservableCollection<Structure> Resources { get => mResources; set => SetField(ref mResources, value); }
        private ObservableCollection<Structure> mResources;

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
    }

    public class Structure : INotifyPropertyChanged
    {
        [JsonProperty("name")]
        public string Name { get => mName; set => SetField(ref mName, value); }
        private string mName;

        [JsonProperty("levels", NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<StructureLevel> Levels { get => mLevels; set => SetField(ref mLevels, value); }
        private ObservableCollection<StructureLevel> mLevels;

        [JsonProperty("removable")]
        public bool Removable { get => mRemovable; set => SetField(ref mRemovable, value); }
        private bool mRemovable;

        [JsonProperty("costType", NullValueHandling = NullValueHandling.Ignore)]
        public CostType? CostType { get => mCostType; set => SetField(ref mCostType, value); }
        private CostType? mCostType;

        [JsonProperty("exclusive", NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<string> Exclusive { get => mExclusive; set => SetField(ref mExclusive, value); }
        private ObservableCollection<string> mExclusive;

        [JsonProperty("tierLock", NullValueHandling = NullValueHandling.Ignore)]
        public int? TierLock { get => mTierLock; set => SetField(ref mTierLock, value); }
        private int? mTierLock;

        [JsonProperty("effect", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect { get => mEffect; set => SetField(ref mEffect, value); }
        private string mEffect;

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
    }

    public class StructureLevel : INotifyPropertyChanged
    {
        [JsonProperty("level")]
        public int Level { get => mLevel; set => SetField(ref mLevel, value); }
        private int mLevel;

        [JsonProperty("cost")]
        public int Cost { get => mCost; set => SetField(ref mCost, value); }
        private int mCost;

        [JsonProperty("effect")]
        public string Effect { get => mEffect; set => SetField(ref mEffect, value); }
        private string mEffect;

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion
    }
}
