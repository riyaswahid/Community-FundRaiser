using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace FundRiser.Abstractions
{
    public interface ILoginProvider
    {
        MobileServiceUser RetrieveTokenFromSecureStore();

        void StoreTokenInSecureStore(MobileServiceUser user);

        void RemoveTokenFromSecureStore();

        Task LoginAsync(MobileServiceClient client);
    }
}
