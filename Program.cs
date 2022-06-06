using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace az204
{
    class program
    {
        private const string _clientId = "243cdb91-e2e9-4406-9b8a-189dc9d73418";

        private const string _tenantId = "fd848591-edf0-4c7d-983b-9f5d9b2a337c";

        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
            .Create(_clientId)
            .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
            .WithRedirectUri ("http://localhost")
            .Build();
            string[] scopes = {"user.read"};
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();
            Console.WriteLine($"Token:\t{result.AccessToken}");
    
            
        }
    

    }
}


