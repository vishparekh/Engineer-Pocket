using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class OnlineLecturesDataSource : DataSourceBase<MenuSchema>
    {
        private readonly IEnumerable<MenuSchema> _data = new MenuSchema[]
		{
            new MenuSchema
            {
                Type = "Url",
                Title = "COURSERA",
                Icon = "/Assets/DataImages/slideshow.png",
                Target = "https://www.coursera.org/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "LEARNERStv",
                Icon = "/Assets/DataImages/slideshow-1.png",
                Target = "http://www.learnerstv.com/Free-engineering-video-l",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "OCW-MIT",
                Icon = "/Assets/DataImages/slideshow-2.png",
                Target = "http://ocw.mit.edu/courses/audio-video-courses/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "FREE VIDEO LECTURES",
                Icon = "/Assets/DataImages/slideshow-3.png",
                Target = "http://freevideolectures.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "ONLINE VIDEO LECTURE",
                Icon = "/Assets/DataImages/slideshow-4.png",
                Target = "http://www.onlinevideolecture.com/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "NPTELhrd",
                Icon = "/Assets/DataImages/slideshow-5.png",
                Target = "https://www.youtube.com/user/nptelhrd",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "VIDEO LECTURES",
                Icon = "/Assets/DataImages/slideshow-6.png",
                Target = "http://videolectures.net/",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "OPEN CULTURE",
                Icon = "/Assets/DataImages/slideshow-7.png",
                Target = "http://www.openculture.com/engineering_free_course",
            },
            new MenuSchema
            {
                Type = "Url",
                Title = "STANDFORD SCHOOL OF ENGG.",
                Icon = "/Assets/DataImages/slideshow-8.png",
                Target = "http://see.stanford.edu/see/courses.aspx",
            },
		};

        protected override string CacheKey
        {
            get { return "OnlineLecturesDataSource"; }
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
