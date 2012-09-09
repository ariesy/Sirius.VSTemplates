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
        // Um die Forms/Windows-Authentifizierung für die Webanwendung zu aktivieren, bearbeiten Sie den entsprechenden Abschnitt der Datei "web.config".
    }

    public class User : UserBase
    {
        // HINWEIS: Profileigenschaften können hier hinzugefügt werden 
        // Um Profile zu aktivieren, bearbeiten Sie den entsprechenden Abschnitt der Datei "web.config".

        // public string MyProfileProperty { get; set; }
    }
}