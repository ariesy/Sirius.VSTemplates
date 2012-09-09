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
        // 若要对 Web 应用程序启用 Forms/Windows 身份验证，请编辑 web.config 文件的相应部分。
    }

    public class User : UserBase
    {
        // 注意: 此处可以添加配置文件属性
        // 若要启用配置文件，请编辑 web.config 文件的相应部分。

        // public string MyProfileProperty { get; set; }
    }
}