using System.Threading.Tasks;
using ABC.ApiGateway.Admin.Client.Models;
using ABC.ApiGateway.Admin.Client.Services;
using Microsoft.AspNetCore.Components;

namespace ABC.ApiGateway.Admin.Client.Pages.Account.Settings
{
    public partial class BaseView
    {
        private CurrentUser _currentUser = new CurrentUser();

        [Inject] protected IUserService UserService { get; set; }

        private void HandleFinish()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _currentUser = await UserService.GetCurrentUserAsync();
        }
    }
}