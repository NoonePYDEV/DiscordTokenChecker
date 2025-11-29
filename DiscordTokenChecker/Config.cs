using System;

namespace DiscordTokenChecker
{
    internal class Config
    {
        public static bool SaveAll = true;
        public static bool SaveEMailVerified = false;
        public static bool SavePhoneVerified = false;
        public static bool SaveNitroBoost = false;
        public static bool SaveNitroBasic = false;
        public static bool SaveMFA = false;

        public Config() 
        { 
        }
    }
}
