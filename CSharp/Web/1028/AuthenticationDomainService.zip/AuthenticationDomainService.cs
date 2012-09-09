using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.ServiceModel.DomainServices.Hosting;
using System.ServiceModel.DomainServices.Server;
using System.ServiceModel.DomainServices.Server.ApplicationServices;

namespace $rootnamespace$
{
    [EnableClientAccess]
    public class $safeitemname$ : AuthenticationBase<User>
    {
        // 若要為 Web 應用程式啟用 Forms/Windows 驗證，請編輯 web.config 檔案的適當區段。
    }

    public class User : UserBase
    {
        // 注意: 這裡可以加入設定檔屬性 
        // 若要啟用設定檔，請編輯 web.config 檔案的適當區段。

        // public string MyProfileProperty { get; set; }
    }
}