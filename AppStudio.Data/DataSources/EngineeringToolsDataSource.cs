using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class EngineeringToolsDataSource : DataSourceBase<MenuSchema>
    {
        private readonly IEnumerable<MenuSchema> _data = new MenuSchema[]
		{
            new MenuSchema
            {
                Type = "Url",
                Title = "Digital Inspiration",
                Icon = "/Assets/DataImages/globe.png",
                Target = "http://www.labnol.org",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "TechNotification",
                Icon = "/Assets/DataImages/globe-1.png",
                Target = "http://www.technotification.com",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Cool Hacking Tricks",
                Icon = "/Assets/DataImages/globe-2.png",
                Target = "http://www.technotification.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "NilVish",
                Icon = "/Assets/DataImages/globe-3.png",
                Target = "http://nilvish.blogspot.com",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Tips n Tricks",
                Icon = "/Assets/DataImages/globe-4.png",
                Target = "http://www.blogtipsntricks.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Bloggers Tips Tricks",
                Icon = "/Assets/DataImages/globe-5.png",
                Target = "http://www.bloggertipstricks.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Netoops Blog",
                Icon = "/Assets/DataImages/globe-6.png",
                Target = "http://netoopsblog.blogspot.in/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "HubSpot",
                Icon = "/Assets/DataImages/globe-7.png",
                Target = "http://blog.hubspot.com/Hubs",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Help Blogger",
                Icon = "/Assets/DataImages/globe-8.png",
                Target = "http://helplogger.blogspot.in/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Daily Tips nd Tricks",
                Icon = "/Assets/DataImages/globe-9.png",
                Target = "http://dailytipsndtricks.blogspot.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "HackBlog",
                Icon = "/Assets/DataImages/globe-10.png",
                Target = "http://www.haakblog.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "New Blogger Tips",
                Icon = "/Assets/DataImages/globe-11.png",
                Target = "http://newbloggertips.com/",
            },
		};

        protected override string CacheKey
        {
            get { return "EngineeringToolsDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        public async override Task<IEnumerable<MenuSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
