using Exiled.API.Interfaces;
using System.ComponentModel;

namespace AnnoyngPopUps
{
    public class Translations : ITranslation
    {
        [Description("The message that appears when someone blinks.")]
        public string MessageThatAppearsWhenSomeoneBlinks { get; set; } = "YOU HAVE TO BUY OUR VIP ROLE!";
        [Description("The message that appears when someone shoots")]
        public string MessageThatAppearsWhenSomeoneShoots { get; set; } = "AAAAAAAAAAAAAA";
        [Description("The message that appears when someone jumps")]
        public string MessageThatAppearsWhenSomeonJumps { get; set; } = "You got mail";
        [Description("The message that appears when someone toggles the flashlight")]
        public string MessageThatAppearsWhenSomeoneTogglesTheFlashlight { get; set; } = "To use the flashlight you need to recharge the battery with 10$!";
    }
}
