using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using ExEvents = Exiled.Events.Handlers;

namespace AnnoyngPopUps
{
    public class Plugin : Plugin<Config, Translations>
    {
        public override Version RequiredExiledVersion { get; } = new Version(4, 2, 2);
        public override string Name { get; } = "AnnoyngPopUps";
        public override Version Version { get; } = new Version(1, 0, 5);

        public static Plugin Singleton;
        public Handlers.EventHandlers EventHandlers;

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandlers = new Handlers.EventHandlers();

            ExEvents.Scp173.Blinking += EventHandlers.OnBlinking;
            Player.Shooting += EventHandlers.OnShooting;
            Player.Jumping += EventHandlers.OnJumping;
            Player.TogglingFlashlight += EventHandlers.OnTogglingFlashLight;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            ExEvents.Scp173.Blinking -= EventHandlers.OnBlinking;
            Player.Shooting -= EventHandlers.OnShooting;
            Player.Jumping -= EventHandlers.OnJumping;
            Player.TogglingFlashlight -= EventHandlers.OnTogglingFlashLight;

            Singleton = null;
            EventHandlers = null;
            base.OnDisabled();
        }
    }
}