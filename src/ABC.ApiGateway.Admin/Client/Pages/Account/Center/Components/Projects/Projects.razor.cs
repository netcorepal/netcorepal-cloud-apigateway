using System.Collections.Generic;
using ABC.ApiGateway.Admin.Client.Models;
using Microsoft.AspNetCore.Components;
using AntDesign;

namespace ABC.ApiGateway.Admin.Client.Pages.Account.Center
{
    public partial class Projects
    {
        private readonly ListGridType _listGridType = new ListGridType
        {
            Gutter = 24,
            Column = 4
        };

        [Parameter]
        public IList<ListItemDataType> List { get; set; }
    }
}