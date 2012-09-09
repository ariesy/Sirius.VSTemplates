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
        // Per abilitare l'Autenticazione basata su form/di Windows per l'applicazione Web modificare la sezione appropriata del file web.config.
    }

    public class User : UserBase
    {
        // NOTA: è possibile aggiungere qui le proprietà del profilo 
        // Per abilitare i profili modificare la sezione appropriata del file web.config.

        // public string MyProfileProperty { get; set; }
    }
}