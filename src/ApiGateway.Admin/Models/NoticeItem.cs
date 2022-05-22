using AntDesign.ProLayout;

namespace NetCorePal.ApiGateway.Admin.Models
{
    public class NoticeItem : NoticeIconData
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}