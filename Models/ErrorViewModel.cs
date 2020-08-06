using Microsoft.AspNetCore.Mvc;

namespace Topics.Models
{
    [ResponseCache(VaryByHeader = "User-Agent", Duration = 300)]
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
