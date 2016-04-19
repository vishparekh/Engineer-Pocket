using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class AboutDataSource : DataSourceBase<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{2a35f7a4-2997-455b-abca-8c6f374a18cd}",
                Content = @"<b><i>Are you studying engineering? Then you have come to the right place! Our stuff in this category will help you prepare for your exams thanks to sub-categories in Computer/IT,Electrical, Mechanical, Aeronautical,Chemical,Plastic,Rubber,Electronics,IC,Robotics ,Civil or Environmental engineering .<br>For Engineers App is prepared in keeping mind the requirements of Engineering Student&nbsp;.This App can be said a comlete Package for Engineering Student.&nbsp;What are you waiting for? Just Explore the Engineering World .<br></i></b><i><b>The Content is copyrighted by various websites included inside in this App&nbsp;. Please respect their copyrights.</b></i>"
            }
        };

        protected override string CacheKey
        {
            get { return "AboutDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        public async override Task<IEnumerable<HtmlSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
