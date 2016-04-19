using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class FreeBooksDataSource : DataSourceBase<MenuSchema>
    {
        private readonly IEnumerable<MenuSchema> _data = new MenuSchema[]
		{
            new MenuSchema
            {
                Type = "Url",
                Title = "BookBoon",
                Icon = "/Assets/DataImages/library.png",
                Target = "http://bookboon.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Careers360",
                Icon = "/Assets/DataImages/library-1.png",
                Target = "http://www.engineering.careers360.com/taxonomy/ter",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Free Engineering Books",
                Icon = "/Assets/DataImages/library-2.png",
                Target = "http://www.freeengineeringbooks.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "eBook3000",
                Icon = "/Assets/DataImages/library-3.png",
                Target = "http://ebook3000.com/Engineering-Technology/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Free e-Books",
                Icon = "/Assets/DataImages/library-4.png",
                Target = "http://www.free-ebooks.net/ebook/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Free Book Centre",
                Icon = "/Assets/DataImages/library-5.png",
                Target = "http://www.freebookcentre.net",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Online Programming Books",
                Icon = "/Assets/DataImages/library-6.png",
                Target = "http://www.onlineprogrammingbooks.com",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "e-Books Directory",
                Icon = "/Assets/DataImages/library-7.png",
                Target = "http://www.e-booksdirectory.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "Free TechBooks",
                Icon = "/Assets/DataImages/library-8.png",
                Target = "http://www.freetechbooks.com",
            },
		};

        protected override string CacheKey
        {
            get { return "FreeBooksDataSource"; }
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
