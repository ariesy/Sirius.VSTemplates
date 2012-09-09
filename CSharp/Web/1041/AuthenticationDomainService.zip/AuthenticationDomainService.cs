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
        // Web アプリケーションに対して Forms 認証および Windows 認証を有効にするには、web.config ファイルの該当する部分を編集してください。
    }

    public class User : UserBase
    {
        // メモ: プロファイル プロパティはここに追加できます 
        // プロファイルを有効にするには、web.config ファイルの該当する部分を編集してください。

        // public string MyProfileProperty { get; set; }
    }
}