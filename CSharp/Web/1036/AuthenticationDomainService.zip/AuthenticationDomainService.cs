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
        // Pour activer l'authentification Forms/Windows pour l'application Web, modifiez la section appropriée du fichier web.config.
    }

    public class User : UserBase
    {
        // REMARQUE : les propriétés de profil peuvent être ajoutées ici 
        // Pour activer des profils, modifiez la section appropriée du ficher web.config.

        // public string MyProfileProperty { get; set; }
    }
}