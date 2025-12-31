namespace PortiForce.AssetsAssistant.Core.Assets;

public static class Constraints
{
    public static class CommonSettings
    {
        public const int ExtraShortStringLength = 10;
        public const int ShortStringLength = 50;
        public const int MediumStringLength = 100;
        public const int LongStringLength = 255;
        public const int ExtraLongStringLength = 1000;

        public const int EmailAddressLength = 100;
    }

    public static class Domain
    {
        public static class Actor
        {
            public static class UserSettings
            {
                public const int LoginLength = 75;
                public const int PasswordHash = 128;
                public const int PasswordSalt = 64;

                public const int MinAllowedAge = 16;
            }
        }

        public static class Portfolio
        {
        }
    }
}
