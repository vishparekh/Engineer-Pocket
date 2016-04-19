using System;

using Windows.ApplicationModel;

namespace AppStudio.ViewModels
{
    public class AboutThisAppViewModel
    {
        public string Publisher
        {
            get
            {
                return "AppStudio";
            }
        }

        public string AppVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build, Package.Current.Id.Version.Revision);
            }
        }

        public string AboutText
        {
            get
            {
                return "FOR ENGINEERS App is Prepared in Keeping mind the requirement of Engineering Stud" +
    "ents.This App contains all the Study Material along with some Myths and Meme abo" +
    "ut Engineering.Get ready to explore the Engineering World with the Help of FOR E" +
    "NGINEERS App!";
            }
        }
    }
}

