using System.Collections;
using UnityEngine;

public class CollectorOP : MyScriptMonoBehaviour
{
    private bool isCollect = true;
    public bool IsCollect => isCollect;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("FishBone"))
        {
            AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.eatFishBone);
            ObserverManager.Instance.CollectorEventOP.CollectCoinFishBoneEvent();
        }
        if (other.gameObject.layer == 10 && isCollect == true)
        {
            AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.powerUpCollection);
        }


        if (other.gameObject.CompareTag("CoinMagnet") && isCollect == true)
        {
            StartMagnetItem();
        }

        if(other.gameObject.CompareTag("Invincibility") && isCollect == true)
        {
            StartInvincibilityItem();
        }

        if (other.gameObject.CompareTag("Multiplyer") && isCollect == true)
        {
            StartMultiplyerItem();
        }
    }


    public void StartMagnetItem()
    {
        ObserverManager.Instance.CollectorEventOP.CollectCoinMagnetEvent();
        AudioManager.Instance.PlaySoundLoop(AudioClipManager.Instance.magnet, 10f);
        StartCoroutine(WaitForSecond());
    }

    public void StartMultiplyerItem()
    {
        AudioManager.Instance.PlaySoundLoop(AudioClipManager.Instance.mutil, 10f);
        ObserverManager.Instance.CollectorEventOP.CollectMultiplyerEvent();
        StartCoroutine(WaitForSecond());
    }

    public void StartInvincibilityItem()
    {
        AudioManager.Instance.PlaySoundLoop(AudioClipManager.Instance.invincible, 10f);
        ObserverManager.Instance.CollectorEventOP.CollectInvincibleEvent();
        StartCoroutine(WaitForSecond());
    }


    IEnumerator WaitForSecond()
    {
        isCollect = false;
        yield return new WaitForSeconds(10f);
        ObserverManager.Instance.CollectorEventOP.StopCoinMagnetEvent();
        ObserverManager.Instance.CollectorEventOP.StopInvincibleEvent();
        ObserverManager.Instance.CollectorEventOP.StopMultiEvent();
        isCollect = true;
    }

}
