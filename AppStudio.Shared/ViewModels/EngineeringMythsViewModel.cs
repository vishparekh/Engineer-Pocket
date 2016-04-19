using System;
using System.Windows;
using System.Windows.Input;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using AppStudio.Services;
using AppStudio.Data;

namespace AppStudio.ViewModels
{
    public class EngineeringMythsViewModel : ViewModelBase<HtmlSchema>
    {
        private RelayCommandEx<HtmlSchema> itemClickCommand;
        public RelayCommandEx<HtmlSchema> ItemClickCommand
        {
            get
            {
                if (itemClickCommand == null)
                {
                    itemClickCommand = new RelayCommandEx<HtmlSchema>(
                        (item) =>
                        {

                            NavigationServices.NavigateToPage("", item);
                        });
                }

                return itemClickCommand;
            }
        }

        override protected DataSourceBase<HtmlSchema> CreateDataSource()
        {
            return new EngineeringMythsDataSource(); // HtmlDataSource
        }


        override public ViewTypes ViewType
        {
            get { return ViewTypes.Detail; }
        }
    }
}
