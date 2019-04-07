using ARDefBuilderDataManager;
using ARDefBuilderDataManager.DataObjects;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var folderDiag = new WinForms.FolderBrowserDialog())
            {
                folderDiag.RootFolder = Environment.SpecialFolder.MyComputer;

                var result = folderDiag.ShowDialog();

                if(result == WinForms.DialogResult.OK)
                {
                    ViewModelContext.CurrentDirectory = folderDiag.SelectedPath;

                    var dataHolder = DataReader.LoadFolder(ViewModelContext.CurrentDirectory);
                    
                    // TODO: Put the data holder somewhere (preferably in the DataContext).
                }
            }
        }
    }

    public class DataViewModel : INotifyPropertyChanged
    {
        public string CurrentDirectory
        {
            get => mCurrentDirectory;
            set => SetField(ref mCurrentDirectory, value);
        }
        private string mCurrentDirectory;

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
