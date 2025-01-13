using System.Runtime.InteropServices;

namespace MacCatalystTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TestLabel.Text = $"OS: "+ OperatingSystem;
        }

        public static SdkPlatform OperatingSystem
        {
            get
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    return SdkPlatform.Windows;
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    return SdkPlatform.MacOS;
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("MACCATALYST")))
                {
                    return SdkPlatform.MacCatalyst;
                }

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    return SdkPlatform.Linux;
                }

                return SdkPlatform.Unknown;
            }
        }

        public enum SdkPlatform
        {
            Unknown,
            Windows,
            MacOS,
            MacCatalyst,
            Linux
        }
    }
}
