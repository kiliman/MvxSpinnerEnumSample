﻿namespace MvxSpinnerEnumSample.Core.Plugins
{
    public interface IToastPlugin
    {
        void Show(string text);
        void ShowLong(string text);
    }
}
