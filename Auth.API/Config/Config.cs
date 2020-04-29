using IdentityServer4.Models;
using System.Collections.Generic;

namespace Auth.API.Conf
{
    public class Config
    {

        public static IEnumerable<ApiResource> GetApis()
        {
            return new ApiResource[]
            {
                new ApiResource("Business.API", "Business API")     ,
                new ApiResource("Gateway.API", "Gateway API")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                new Client
                {
                    ClientId = "react-client",
                    ClientName = "SPA Client",
                    ClientUri = "https://localhost:3000",
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,

                    RedirectUris =
                    {
                        "https://localhost:3000/",
                        "https://localhost:3000/"
                    },

                    PostLogoutRedirectUris = { "https://localhost:3000/" },
                    AllowedCorsOrigins = { "https://localhost:3000" },

                    AllowedScopes = {"gateway.api"}
                }
            };
        }


        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };
    }





}
