using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public static class VibrationMng
{
    public static bool vibrationFlag = false;

 

    // �U��
    public static void ShortVibration()
    {
        Debug.Log("shortVibration() ���Ăяo����܂���");
        if (SystemInfo.supportsVibration)
        {
            PlaySystemSound(1519);
            Vibrate(10);
        }
    }

    // iOS�ݒ�
#if UNITY_IOS && !UNITY_EDITOR
        [DllImport ("__Internal")]
        static extern void _playSystemSound(int n);
#endif

    private static void PlaySystemSound(int n) //������ID��n��
    {
#if UNITY_IOS && !UNITY_EDITOR
            _playSystemSound(n);
#endif
    }

    // Android�ݒ�
#if UNITY_ANDROID && !UNITY_EDITOR
    public static AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    public static AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
    public static AndroidJavaObject vibrator = currentActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
#endif

    private static void Vibrate(long milliseconds)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
            vibrator.Call("vibrate", milliseconds);
#endif
        if (milliseconds >= 1000)
        {
            Handheld.Vibrate();
        }
    }
}