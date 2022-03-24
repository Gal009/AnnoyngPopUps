using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace AnnoyngPopUps
{
    public sealed class Config : IConfig
    {
        [Description("If the plugin should be enabled")]
        public bool IsEnabled { get; set; } = true;
        [Description("If it should send 2 popups when the event happens")]
        public bool TwoPopups { get; set; } = true;
        [Description("If the ShootingEvent popup should appear")]
        public bool ShootingEventPopup { get; set; } = true;
        [Description("If the JumpingEvent popup should appear")]
        public bool JumpingEventPopup { get; set; } = true;
        [Description("If the TooglingFlashLightEvent popup should appear")]
        public bool TooglingFlashLighteventPopup { get; set; } = true;
    }
}