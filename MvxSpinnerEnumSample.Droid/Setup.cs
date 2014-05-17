using Android.Content;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using MvxSpinnerEnumSample.Core.Plugins;
using MvxSpinnerEnumSample.Droid.Plugins;

namespace MvxSpinnerEnumSample.Droid
{
    public class Setup : MvxAndroidSetup
    {
        private readonly Context _applicationContext;

        public Setup(Context applicationContext) : base(applicationContext)
        {
            _applicationContext = applicationContext;
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            Mvx.RegisterSingleton<IToastPlugin>(new ToastPlugin(_applicationContext));
        }
    }
}