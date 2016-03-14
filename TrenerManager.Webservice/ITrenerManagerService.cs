using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TrenerManager.Common.Constants;

namespace TrenerManager.Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITrenerManagerService" in both code and config file together.
    [ServiceContract]
    public interface ITrenerManagerService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", 
            ResponseFormat = WebMessageFormat.Json, 
            UriTemplate = WebserviceUriTemplates.DoWorkUri)]
        void DoWork();
    }
}
