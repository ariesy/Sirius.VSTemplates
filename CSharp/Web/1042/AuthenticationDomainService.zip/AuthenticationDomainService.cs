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
        // 웹 응용 프로그램에 대한 Forms/Windows 인증을 사용하려면 web.config 파일에서 해당 섹션을 편집하십시오.
    }

    public class User : UserBase
    {
        // 참고: 여기에 프로필 속성을 추가할 수 있습니다. 
        // 프로필을 사용하려면 web.config 파일에서 해당 섹션을 편집하십시오.

        // public string MyProfileProperty { get; set; }
    }
}