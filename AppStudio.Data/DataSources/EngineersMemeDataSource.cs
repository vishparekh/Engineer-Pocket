using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class EngineersMemeDataSource : DataSourceBase<FacebookSchema>
    {
        private const string _userID = "462024043920858";

        protected override string CacheKey
        {
            get { return "EngineersMemeDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return false; }
        }

        public async override Task<IEnumerable<FacebookSchema>> LoadDataAsync()
        {
            try
            {
                var facebookDataProvider = new FacebookDataProvider(_userID);
                return await facebookDataProvider.Load();
            }
            catch (Exception ex)
            {
                AppLogs.WriteError("EngineersMemeDataSourceDataSource.LoadData", ex.ToString());
                return new FacebookSchema[0];
            }
        }
    }
}
