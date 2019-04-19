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
    /// <summary>
    /// Represents the basic data for any hero.
    /// Is being implemented completely observable for changes in the datastructure.
    /// </summary>
    public class HeroData : INotifyPropertyChanged
    {
        [JsonProperty("name")]
        public string Name { get => mName; set => SetField(ref mName, value); }
        private string mName;

        [JsonProperty("shortName", NullValueHandling = NullValueHandling.Ignore)]
        public string ShortName { get => mShortName; set => SetField(ref mShortName, value); }
        private string mShortName;

        [JsonProperty("title")]
        public string Title { get => mTitle; set => SetField(ref mTitle, value); }
        private string mTitle;

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get => mReleaseDate; set => SetField(ref mReleaseDate, value); }
        private string mReleaseDate;

        [JsonProperty("colorType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ColorType ColorType { get => mColorType; set => SetField(ref mColorType, value); }
        private ColorType mColorType;

        [JsonProperty("weaponType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WeaponType WeaponType { get => mWeaponType; set => SetField(ref mWeaponType, value); }
        private WeaponType mWeaponType;

        [JsonProperty("moveType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MoveType MoveType { get => mMoveType; set => SetField(ref mMoveType, value); }
        private MoveType mMoveType;

        [JsonProperty("skills")]
        public ObservableCollection<HeroDataSkill> Skills { get => mSkills; set => SetField(ref mSkills, value); }
        private ObservableCollection<HeroDataSkill> mSkills = new ObservableCollection<HeroDataSkill>();

        [JsonProperty("stats")]
        public HeroDataStats Stats { get => mStats; set => SetField(ref mStats, value); }
        private HeroDataStats mStats = new HeroDataStats();

        [JsonProperty("limited")]
        public bool Limited { get => mLimited; set => SetField(ref mLimited, value); }
        private bool mLimited;

        [JsonProperty("ttReward")]
        public bool TtReward { get => mTtReward; set => SetField(ref mTtReward, value); }
        private bool mTtReward;

        [JsonProperty("ghb")]
        public bool Ghb { get => mGhb; set => SetField(ref mGhb, value); }
        private bool mGhb;

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

    /// <summary>
    /// Represents a skill for a hero's data.
    /// </summary>
    public class HeroDataSkill : INotifyPropertyChanged
    {
        [JsonProperty("name")]
        public string Name { get => mName; set => SetField(ref mName, value); }
        private string mName;

        [JsonProperty("rarity")]
        public int Rarity { get => mRarity; set => SetField(ref mRarity, value); }
        private int mRarity;

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

    /// <summary>
    /// Represents the different stats available for a hero.
    /// </summary>
    public class HeroDataStats : INotifyPropertyChanged
    {
        [JsonProperty("level1")]
        public HeroDataLvl1Stats Level1 { get => mLevel1; set => SetField(ref mLevel1, value); }
        private HeroDataLvl1Stats mLevel1;

        [JsonProperty("level40")]
        public HeroDataLvl40Stats Level40 { get => mLevel40; set => SetField(ref mLevel40, value); }
        private HeroDataLvl40Stats mLevel40;

        [JsonProperty("level1_4", NullValueHandling = NullValueHandling.Ignore)]
        public HeroDataLvl1Stats Level1_4 { get => mLevel1_4; set => SetField(ref mLevel1_4, value); }
        private HeroDataLvl1Stats mLevel1_4;

        [JsonProperty("level40_4", NullValueHandling = NullValueHandling.Ignore)]
        public HeroDataLvl40Stats Level40_4 { get => mLevel40_4; set => SetField(ref mLevel40_4, value); }
        private HeroDataLvl40Stats mLevel40_4;

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

    public class HeroDataLvl1Stats : INotifyPropertyChanged
    {
        [JsonProperty("hp")]
        public int Hp { get => mHp; set => SetField(ref mHp, value); }
        private int mHp;

        [JsonProperty("atk")]
        public int Atk { get => mAtk; set => SetField(ref mAtk, value); }
        private int mAtk;

        [JsonProperty("spd")]
        public int Spd { get => mSpd; set => SetField(ref mSpd, value); }
        private int mSpd;

        [JsonProperty("def")]
        public int Def { get => mDef; set => SetField(ref mDef, value); }
        private int mDef;

        [JsonProperty("res")]
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

    public class HeroDataLvl40Stats : INotifyPropertyChanged
    {
        [JsonProperty("hp")]
        public int[] Hp { get => mHp; set => SetField(ref mHp, value); }
        private int[] mHp;

        [JsonProperty("atk")]
        public int[] Atk { get => mAtk; set => SetField(ref mAtk, value); }
        private int[] mAtk;

        [JsonProperty("spd")]
        public int[] Spd { get => mSpd; set => SetField(ref mSpd, value); }
        private int[] mSpd;

        [JsonProperty("def")]
        public int[] Def { get => mDef; set => SetField(ref mDef, value); }
        private int[] mDef;

        [JsonProperty("res")]
        public int[] Res { get => mRes; set => SetField(ref mRes, value); }
        private int[] mRes;

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
