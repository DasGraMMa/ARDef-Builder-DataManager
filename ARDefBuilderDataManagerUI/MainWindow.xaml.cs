using ARDefBuilderDataManager;
using ARDefBuilderDataManager.DataObjects;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinForms = System.Windows.Forms;

namespace ARDefBuilderDataManagerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataViewModel ViewModelContext { get => DataContext as DataViewModel; }

        public MainWindow()
        {
            InitializeComponent();

            // Load the settings for the window.
            var settings = Properties.Settings.Default;
            (Left, Top) = (settings.AppLocation.X, settings.AppLocation.Y);
            (Width, Height) = (settings.AppSize.Width, settings.AppSize.Height);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // Save the settings.
            Properties.Settings.Default.AppSize = new System.Drawing.Size((int)Width, (int)Height);
            Properties.Settings.Default.AppLocation = new System.Drawing.Point((int)Left, (int)Top);
            Properties.Settings.Default.Save();
        }

        private void CommandOpen_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (var folderDiag = new WinForms.FolderBrowserDialog())
            {
                folderDiag.RootFolder = Environment.SpecialFolder.MyComputer;
                folderDiag.SelectedPath = Properties.Settings.Default.LastFolder;

                var result = folderDiag.ShowDialog();

                if (result == WinForms.DialogResult.OK)
                {
                    ViewModelContext.LoadedDirectory = folderDiag.SelectedPath;

                    // Save the last selection for the user.
                    Properties.Settings.Default.LastFolder = ViewModelContext.LoadedDirectory;

                    // Setup the dataholder for this folder.
                    var dataHolder = DataReader.LoadFolder(ViewModelContext.LoadedDirectory);
                    ViewModelContext.DataHolder = dataHolder;
                }
            }
        }

        private void CommandSave_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void CommandSave_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }

    public class DataViewModel : INotifyPropertyChanged
    {
        public string ApplicationTitle
        {
            get
            {
                var title = "";
                
                if (!string.IsNullOrEmpty(LoadedDirectory)) title += "\"" + LoadedDirectory + "\" - ";
                title += "ARDef-Builder Data Manager";

                return title;
            }
        }

        public string LoadedDirectory
        {
            get => mLoadedDirectory;
            set
            {
                SetField(ref mLoadedDirectory, value);
                OnPropertyChanged(nameof(ApplicationTitle));
            }
        }
        private string mLoadedDirectory;

        public DataHolder DataHolder
        {
            get => mDataHolder;
            set
            {
                SetField(ref mDataHolder, value);
            }
        }
        private DataHolder mDataHolder = new DataHolder();

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
