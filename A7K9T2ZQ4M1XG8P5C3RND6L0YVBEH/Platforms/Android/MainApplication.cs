using Android.App;
using Android.Runtime;

namespace A7K9T2ZQ4M1XG8P5C3RND6L0YVBEH
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
