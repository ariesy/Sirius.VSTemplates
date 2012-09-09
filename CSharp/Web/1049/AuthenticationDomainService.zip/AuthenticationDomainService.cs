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
        // Чтобы включить проверку подлинности Forms/Windows для веб-приложения, измените соответствующий раздел файла web.config.
    }

    public class User : UserBase
    {
        // ПРИМЕЧАНИЕ. Свойства профиля можно добавить сюда 
        // Чтобы включить профили, измените соответствующий раздел файла web.config.

        // public string MyProfileProperty { get; set; }
    }
}