using System;
//worked with kel on this file
namespace AspNetCoreCar.Models
{
    public class CarErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
