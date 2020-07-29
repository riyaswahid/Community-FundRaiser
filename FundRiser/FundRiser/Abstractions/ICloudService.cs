﻿using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using FundRiser.Models;

namespace FundRiser.Abstractions
{
   public interface ICloudService
    {
        ICloudTable<T> GetTable<T>() where T : TableData;

        Task<MobileServiceUser> LoginAsync();

        Task LogoutAsync();

        Task LoginAsync(User user);

        Task<AppServiceIdentity> GetIdentityAsync();
    }
}
