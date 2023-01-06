using BusinessData.ofPresentationLayer.ofDTOServices;
using System;

namespace BusinessData.ofPresendationLayer.ofDTOServices.ofJournal
{
    public class JournalServiceOptions : DTOServiceOptions
    {

    }
    public class JournalService : DTOService
    {
        protected JournalServiceOptions _JournalServiceOptions;
        public JournalService(JournalServiceOptions options)
            :base(options)
        {
            _JournalServiceOptions = options;
            if (_JournalServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.JournalWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class JournalDTOService : JournalService
    {
        public JournalDTOService(JournalServiceOptions options)
            : base(options)
        {

        }  
    }
    public class JournalCenterDTOService : JournalService
    {
        public JournalCenterDTOService(JournalServiceOptions options)
            : base(options)
        {

        }  
    }
    public class JCommodityDTOService : JournalService
    {
        public JCommodityDTOService(JournalServiceOptions options)
            : base(options)
        {

        }  
    }
}
