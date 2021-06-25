using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess2
{
    class rpc
    {
        public static DiscordRpcClient client = new DiscordRpcClient("858052568118198282");

        public static string savedDetails = "";
        public static string savedState = "";
        public static string savedLargeImageKey = "";
        public static string savedLargeImageText = "";

        public static void setDetails(string details)
        {
            setRPC(details, savedState, savedLargeImageKey, savedLargeImageText);
        }
        public static void setState(string state)
        {
            setRPC(savedDetails, state, savedLargeImageKey, savedLargeImageText);
        }
        public static void setImage(string image)
        {
            setRPC(savedDetails, savedState, image, savedLargeImageText);
        }
        public static void setImageDetails(string imageDetails)
        {
            setRPC(savedDetails, savedState, savedLargeImageKey, imageDetails);
        }

        public static void setRPC(string details,string state,string largeImageKey, string largeImageText)
        {
            if (!client.IsInitialized)
            {
                client.Initialize();
            }
            client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,
                Assets = new Assets()
                {
                    LargeImageKey = largeImageKey,
                    LargeImageText = largeImageText,
                    // SmallImageKey = "appicon1"
                }
            });
            savedDetails = details;
            savedLargeImageKey = largeImageKey;
            savedLargeImageText = largeImageText;
            savedState = state;
        }


    }
}
