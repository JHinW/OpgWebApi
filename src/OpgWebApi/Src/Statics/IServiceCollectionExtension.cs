using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpgWebApi.Src.Services.FaceCognitive;
using OpgWebApi.Src.Services.FaceCognitiveGroups;
using OpgWebApi.Src.Services.LuisCognitive;
using OpgWebApi.Src.Services.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpgWebApi.Src.Statics
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddOpgLuisCognitiveServer(this IServiceCollection services, IConfigurationSection configs)
        {
            services.AddSingleton<LuisService>( provider => {
                var config = configs.GetSection("OpgLuisExt"); ;
                return new LuisService(config["AppId"], config["SubKey"]); ;
            });

            services.AddSingleton<BingSpeakerService>(provider => {
                var config = configs.GetSection("OpgBingSpeaker"); ;
                return new BingSpeakerService(config["SpeakerKey"]); ;
            });

            return services;
        }

        public static IServiceCollection AddAzureStorageServer(this IServiceCollection services, string storageConn)
        {
            services.AddSingleton<AzureStorageClient>(new AzureStorageClient(storageConn));
            services.AddSingleton<BlobClient>();
            services.AddSingleton<TableClient>();
            return services;
        }

        public static IServiceCollection AddFaceIdentityServer(this IServiceCollection services, IEnumerable<IConfigurationSection> configs)
        {
            foreach(var config in configs)
            {
                services.AddSingleton<FaceApiServiceGroup>(new FaceApiServiceGroup(config["ApiKey"], config["ApiRoot"]));
            }

            services.AddSingleton<NameIdentityFromServiceGroup>();

            services.AddSingleton<NameRegisterFromServiceGroup>();

            services.AddSingleton<PersonGroupCreateFromServiceGroup>();

            services.AddSingleton<PersonGroupTrainFromServiceGroup>();

            services.AddSingleton<NameIdentity>();
            return services;
        }


    }
}
