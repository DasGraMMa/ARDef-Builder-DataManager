using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ARDefBuilderDataManager.DataObjects
{
    public class SkillData : INotifyPropertyChanged
    {
        [JsonProperty("name")]
        public string Name { get => mName; set => SetField(ref mName, value); }
        private string mName;

        [JsonProperty("spCost")]
        public int SpCost { get => mSpCost; set => SetField(ref mSpCost, value); }
        private int mSpCost;

        [JsonProperty("cooldown", NullValueHandling = NullValueHandling.Ignore)]
        public int Cooldown { get => mCooldown; set => SetField(ref mCooldown, value); }
        private int mCooldown;

        [JsonProperty("range", NullValueHandling = NullValueHandling.Ignore)]
        public int Range { get => mRange; set => SetField(ref mRange, value); }
        private int mRange;

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get => mIcon; set => SetField(ref mIcon, value); }
        private string mIcon;

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public SkillStats Stats { get => mStats; set => SetField(ref mStats, value); }
        private SkillStats mStats;

        [JsonProperty("prev")]
        public ObservableCollection<string> Prev { get => mPrev; set => SetField(ref mPrev, value); }
        private ObservableCollection<string> mPrev;

        [JsonProperty("last")]
        public bool Last { get => mLast; set => SetField(ref mLast, value); }
        private bool mLast;

        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<SkillRestrictor> Include { get => mInclude; set => SetField(ref mInclude, value); }
        private ObservableCollection<SkillRestrictor> mInclude;

        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<SkillRestrictor> Exclude { get => mExclude; set => SetField(ref mExclude, value); }
        private ObservableCollection<SkillRestrictor> mExclude;

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

    public class SkillSealData : INotifyPropertyChanged
    {
        [JsonProperty("name")]
        public string Name { get => mName; set => SetField(ref mName, value); }
        private string mName;

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get => mIcon; set => SetField(ref mIcon, value); }
        private string mIcon;

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public SkillStats Stats { get => mStats; set => SetField(ref mStats, value); }
        private SkillStats mStats;

        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<SkillRestrictor> Include { get => mInclude; set => SetField(ref mInclude, value); }
        private ObservableCollection<SkillRestrictor> mInclude;

        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public ObservableCollection<SkillRestrictor> Exclude { get => mExclude; set => SetField(ref mExclude, value); }
        private ObservableCollection<SkillRestrictor> mExclude;

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

    public class SkillRestrictor : INotifyPropertyChanged
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get => mName; set => SetField(ref mName, value); }
        private string mName;

        [JsonProperty("colorType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ColorType? ColorType { get => mColorType; set => SetField(ref mColorType, value); }
        private ColorType? mColorType;

        [JsonProperty("weaponType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public WeaponType? WeaponType { get => mWeaponType; set => SetField(ref mWeaponType, value); }
        private WeaponType? mWeaponType;

        [JsonProperty("moveType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public MoveType? MoveType { get => mMoveType; set => SetField(ref mMoveType, value); }
        private MoveType? mMoveType;

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

    public class SkillStats : INotifyPropertyChanged
    {
        [JsonProperty("hp", NullValueHandling = NullValueHandling.Ignore)]
        public int Hp { get => mHp; set => SetField(ref mHp, value); }
        private int mHp;

        [JsonProperty("atk", NullValueHandling = NullValueHandling.Ignore)]
        public int Atk { get => mAtk; set => SetField(ref mAtk, value); }
        private int mAtk;

        [JsonProperty("spd", NullValueHandling = NullValueHandling.Ignore)]
        public int Spd { get => mSpd; set => SetField(ref mSpd, value); }
        private int mSpd;

        [JsonProperty("def", NullValueHandling = NullValueHandling.Ignore)]
        public int Def { get => mDef; set => SetField(ref mDef, value); }
        private int mDef;

        [JsonProperty("res", NullValueHandling = NullValueHandling.Ignore)]
        public int Res { get => mRes; set => SetField(ref mRes, value); }
        private int mRes;

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
