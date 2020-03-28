using UnityEngine;
using Valve.VR;

public class Kenny_fadeControl : MonoBehaviour
{
    public static void FadeToWhite(float Duration)
    {
        //start color
        SteamVR_Fade.Start(Color.clear, 0);
        //end color
        SteamVR_Fade.Start(Color.white, Duration);
    }
    public static void FadeFromWhite(float Duration)
    {
        //start color
        SteamVR_Fade.Start(Color.white, 0);
        //end color
        SteamVR_Fade.Start(Color.clear, Duration);
    }
    public static void FadeToBlack(float Duration)
    {
        //start color
        SteamVR_Fade.Start(Color.clear, 0);
        //end color
        SteamVR_Fade.Start(Color.black, Duration);
    }
    public static void FadeFromBlack(float Duration)
    {
        //start color
        SteamVR_Fade.Start(Color.black, 0);
        //end color
        SteamVR_Fade.Start(Color.clear, Duration);
    }

    public static void FadeToAnyColor(Color color,float Duration)
    {
        //start color
        SteamVR_Fade.Start(Color.clear, 0);
        //end color
        SteamVR_Fade.Start(color, Duration);
    }
    public static void FadeFromAnyColor(Color color, float Duration)
    {
        //start color
        SteamVR_Fade.Start(color, 0);
        //end color
        SteamVR_Fade.Start(Color.clear, Duration);
    }
}
