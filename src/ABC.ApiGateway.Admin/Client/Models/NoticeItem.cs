using AntDesign.ProLayout;

namespace ABC.ApiGateway.Admin.Client.Models
{
    public class NoticeItem : NoticeIconData
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}