using System;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Net.NetworkInformation;

using Windows.UI.Xaml;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class MainViewModel : BindableBase
    {
       private AboutViewModel _aboutModel;
       private OnlineLecturesViewModel _onlineLecturesModel;
       private FreeBooksViewModel _freeBooksModel;
       private EngineeringToolsViewModel _engineeringToolsModel;
       private EngineeringMythsViewModel _engineeringMythsModel;
       private EngineersMemeViewModel _engineersMemeModel;
        private PrivacyViewModel _privacyModel;

        private ViewModelBase _selectedItem = null;

        public MainViewModel()
        {
            _selectedItem = AboutModel;
            _privacyModel = new PrivacyViewModel();

        }
 
        public AboutViewModel AboutModel
        {
            get { return _aboutModel ?? (_aboutModel = new AboutViewModel()); }
        }
 
        public OnlineLecturesViewModel OnlineLecturesModel
        {
            get { return _onlineLecturesModel ?? (_onlineLecturesModel = new OnlineLecturesViewModel()); }
        }
 
        public FreeBooksViewModel FreeBooksModel
        {
            get { return _freeBooksModel ?? (_freeBooksModel = new FreeBooksViewModel()); }
        }
 
        public EngineeringToolsViewModel EngineeringToolsModel
        {
            get { return _engineeringToolsModel ?? (_engineeringToolsModel = new EngineeringToolsViewModel()); }
        }
 
        public EngineeringMythsViewModel EngineeringMythsModel
        {
            get { return _engineeringMythsModel ?? (_engineeringMythsModel = new EngineeringMythsViewModel()); }
        }
 
        public EngineersMemeViewModel EngineersMemeModel
        {
            get { return _engineersMemeModel ?? (_engineersMemeModel = new EngineersMemeViewModel()); }
        }

        public void SetViewType(ViewTypes viewType)
        {
            AboutModel.ViewType = viewType;
            OnlineLecturesModel.ViewType = viewType;
            FreeBooksModel.ViewType = viewType;
            EngineeringToolsModel.ViewType = viewType;
            EngineeringMythsModel.ViewType = viewType;
            EngineersMemeModel.ViewType = viewType;
        }

        public ViewModelBase SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SetProperty(ref _selectedItem, value);
                UpdateAppBar();
            }
        }

        public Visibility AppBarVisibility
        {
            get
            {
                return SelectedItem == null ? AboutVisibility : SelectedItem.AppBarVisibility;
            }
        }

        public Visibility AboutVisibility
        {

         get { return Visibility.Visible; }
        }

        public void UpdateAppBar()
        {
            OnPropertyChanged("AppBarVisibility");
            OnPropertyChanged("AboutVisibility");
        }

        /// <summary>
        /// Load ViewModel items asynchronous
        /// </summary>
        public async Task LoadDataAsync(bool forceRefresh = false)
        {
            var loadTasks = new Task[]
            { 
                AboutModel.LoadItemsAsync(forceRefresh),
                OnlineLecturesModel.LoadItemsAsync(forceRefresh),
                FreeBooksModel.LoadItemsAsync(forceRefresh),
                EngineeringToolsModel.LoadItemsAsync(forceRefresh),
                EngineeringMythsModel.LoadItemsAsync(forceRefresh),
                EngineersMemeModel.LoadItemsAsync(forceRefresh),
            };
            await Task.WhenAll(loadTasks);
        }

        //
        //  ViewModel command implementation
        //
        public ICommand RefreshCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    await LoadDataAsync(true);
                });
            }
        }

        public ICommand AboutCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    NavigationServices.NavigateToPage("AboutThisAppPage");
                });
            }
        }

        public ICommand PrivacyCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    NavigationServices.NavigateTo(_privacyModel.Url);
                });
            }
        }
    }
}
