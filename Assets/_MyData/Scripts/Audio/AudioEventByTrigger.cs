
using UnityEngine;

public class AudioEventByTrigger : EventActiveByCollider
{
    [SerializeField] protected AudioClip m_Clip;

    protected override void OneActive()
    {
        base.OneActive();
        AudioManager.Instance.PlaySoundOneShot(m_Clip);
    }

}
