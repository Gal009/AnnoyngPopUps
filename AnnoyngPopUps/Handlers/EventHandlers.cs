using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System.Collections.Generic;
using System.Linq;

namespace AnnoyngPopUps.Handlers
{
    public class EventHandlers
    {

        private readonly Config config = Plugin.Singleton.Config;
        private readonly Translations translations = Plugin.Singleton.Translation;

        public void OnBlinking(BlinkingEventArgs ev)
        {
            ev.Player.OpenReportWindow(translations.MessageThatAppearsWhenSomeoneBlinks);
        }

        public void OnShooting(ShootingEventArgs ev)
        {
            if (config.ShootingEventPopup)
            {
                ev.Shooter.OpenReportWindow(translations.MessageThatAppearsWhenSomeoneShoots);
            }
        }

        public void OnJumping(JumpingEventArgs ev)
        {
            if (config.JumpingEventPopup)
            {
                ev.Player.OpenReportWindow(translations.MessageThatAppearsWhenSomeonJumps);
            }
        }

        public void OnTogglingFlashLight(TogglingFlashlightEventArgs ev)
        {
            if (config.TooglingFlashLighteventPopup)
            {
                ev.Player.OpenReportWindow(translations.MessageThatAppearsWhenSomeoneTogglesTheFlashlight);
            }
        }
    }
}
