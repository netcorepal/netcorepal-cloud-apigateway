using System.Collections.Generic;
using ABC.ApiGateway.Admin.Client.Models;
using Microsoft.AspNetCore.Components;

namespace ABC.ApiGateway.Admin.Client.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}