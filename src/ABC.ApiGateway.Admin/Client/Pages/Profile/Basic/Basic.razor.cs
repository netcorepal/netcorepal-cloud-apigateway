using System.Threading.Tasks;
using ABC.ApiGateway.Admin.Client.Models;
using ABC.ApiGateway.Admin.Client.Services;
using Microsoft.AspNetCore.Components;

namespace ABC.ApiGateway.Admin.Client.Pages.Profile
{
    public partial class Basic
    {
        private BasicProfileDataType _data = new BasicProfileDataType();

        [Inject] protected IProfileService ProfileService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _data = await ProfileService.GetBasicAsync();
        }
    }
}