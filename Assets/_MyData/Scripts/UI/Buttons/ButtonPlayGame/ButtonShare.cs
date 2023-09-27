using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ButtonShare : BaseButton
{
    /*    private bool isFocus = false;
        private bool isProcessing = false;

        protected override void OnClick()
        {
            ShareText();
        }

        void OnApplicationFocus(bool focus)
        {
            isFocus = focus;
        }

        private void ShareText()
        {

    #if UNITY_ANDROID

            if (!isProcessing)
            {
                StartCoroutine(ShareTextInAnroid());
            }

    #else
            Debug.Log("No sharing set up for this platform.");
    #endif

        }



    #if UNITY_ANDROID

        public IEnumerator ShareTextInAnroid()
        {
            var shareSubject = "Play POP IT on your phone"; //Subject text
            var shareMessage = "Get POP IT game from this link: " + //Message text
                               "https://thaogc.itch.io/"; //Your link

            isProcessing = true;

            if (!Application.isEditor)
            {
                //Create intent for action send
                AndroidJavaClass intentClass =
                    new AndroidJavaClass("android.content.Intent");
                AndroidJavaObject intentObject =
                    new AndroidJavaObject("android.content.Intent");
                intentObject.Call<AndroidJavaObject>
                    ("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
                //put text and subject extra
                intentObject.Call<AndroidJavaObject>("setType", "text/plain");

                intentObject.Call<AndroidJavaObject>
                    ("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), shareSubject);
                intentObject.Call<AndroidJavaObject>
                    ("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), shareMessage);

                //call createChooser method of activity class
                AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

                AndroidJavaObject currentActivity =
                    unity.GetStatic<AndroidJavaObject>("currentActivity");
                AndroidJavaObject chooser =
                    intentClass.CallStatic<AndroidJavaObject>
                    ("createChooser", intentObject, "Share your high score");
                currentActivity.Call("startActivity", chooser);
            }

            yield return new WaitUntil(() => isFocus);
            isProcessing = false;
        }

    #endif*/
    protected override void OnClick()
    {
        SoundClick();
        throw new System.NotImplementedException();
    }
}
