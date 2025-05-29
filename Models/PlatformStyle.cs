using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Androsova.Models
{
    internal class PlatformStyle
    {
        public static Color BackgroundColor =>
            DeviceInfo.Platform == DevicePlatform.Android ? Colors.Blue :
            DeviceInfo.Platform == DevicePlatform.WinUI ? Colors.Red :
            Colors.White;

        public static Color ButtonColor =>
            DeviceInfo.Platform == DevicePlatform.Android ? Colors.LightBlue :
            DeviceInfo.Platform == DevicePlatform.WinUI ? Colors.Pink :
            Colors.Gray;

        public static Color ButtonTextColor =>
            DeviceInfo.Platform == DevicePlatform.Android ? Colors.White :
            DeviceInfo.Platform == DevicePlatform.WinUI ? Colors.Black :
            Colors.Black;
    }
}
