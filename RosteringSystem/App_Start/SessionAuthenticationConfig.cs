using System;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(RosteringSystem.App_Start.SessionAuthenticationConfig), "PreAppStart")]

namespace RosteringSystem.App_Start
{
    public static class SessionAuthenticationConfig
    {
        public static void PreAppStart()
        {
            DynamicModuleUtility.RegisterModule(typeof(System.IdentityModel.Services.SessionAuthenticationModule));
        }
    }
}