using System.Collections.Generic;
using NetCorePal.ApiGateway.Admin.Models;
using Microsoft.AspNetCore.Components;

namespace NetCorePal.ApiGateway.Admin.Pages.Account.Center
{
    public partial class Articles
    {
        [Parameter] public IList<ListItemDataType> List { get; set; }
    }
}