using System.Threading.Tasks;
using NetCorePal.ApiGateway.Admin.Models;
using NetCorePal.ApiGateway.Admin.Services;
using Microsoft.AspNetCore.Components;
using AntDesign;

namespace NetCorePal.ApiGateway.Admin.Pages.User {
  public partial class Login {
    private readonly LoginParamsType _model = new LoginParamsType();

    [Inject] public NavigationManager NavigationManager { get; set; }

    [Inject] public IAccountService AccountService { get; set; }

    [Inject] public MessageService Message { get; set; }

    public void HandleSubmit() {
      if (_model.UserName == "admin" && _model.Password == "ant.design") {
        NavigationManager.NavigateTo("/");
        return;
      }

      if (_model.UserName == "user" && _model.Password == "ant.design") NavigationManager.NavigateTo("/");
    }

    public async Task GetCaptcha() {
      var captcha = await AccountService.GetCaptchaAsync(_model.Mobile);
      await Message.Success($"Verification code validated successfully! The verification code is: {captcha}");
    }
  }
}