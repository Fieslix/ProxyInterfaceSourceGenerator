//----------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/ProxyInterfaceSourceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//----------------------------------------------------------------------------------------

#nullable enable
using System;

namespace ProxyInterfaceSourceGeneratorTests.Source.PnP
{
    public partial interface IClientContext
    {
        new Microsoft.SharePoint.Client.ClientContext _Instance { get; }

        ProxyInterfaceSourceGeneratorTests.Source.PnP.IWeb Web { get; }

        Microsoft.SharePoint.Client.Site Site { get; }

        Microsoft.SharePoint.Client.RequestResources RequestResources { get; }

        System.Version ServerVersion { get; }



        Microsoft.SharePoint.Client.FormDigestInfo GetFormDigestDirect();

        void ExecuteQuery();

        System.Threading.Tasks.Task ExecuteQueryAsync();




    }
}
#nullable disable