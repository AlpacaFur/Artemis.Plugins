﻿using System.Windows.Navigation;
using Artemis.UI.Shared.LayerEffects;

namespace Artemis.Plugins.LayerEffects.Filter.ViewModels
{
    public class ColorMatrixConfigurationViewModel : EffectConfigurationViewModel
    {
        public ColorMatrixConfigurationViewModel(ColorMatrixEffect layerEffect) : base(layerEffect)
        {
            Properties = layerEffect.Properties;
        }

        public ColorMatrixEffectProperties Properties { get; set; }

        public void OpenHyperlink(object sender, RequestNavigateEventArgs e)
        {
            Core.Utilities.OpenUrl(e.Uri.AbsoluteUri);
        }
    }
}