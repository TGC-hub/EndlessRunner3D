using System.Collections;
using UnityEngine;

public class DogChasingAudioo : MyScriptMonoBehaviour
{

    private bool isActiveAudio = true;

    protected override void Start()
    {
        base.Start();
        AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.soundDog2);
    }

    protected virtual void FixedUpdate()
    {
        if (PlayerManager.Instance.SenderState.IsTriggerObstacle)
        {
            if (isActiveAudio == true)
            {
                isActiveAudio = false;
                AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.soundDog2);
                StartCoroutine(MoveAndReturnRoutine());
            }
            
        }
    }

    private IEnumerator MoveAndReturnRoutine()
    {
        yield return new WaitForSeconds(5f);
        isActiveAudio = true;
    }
}
