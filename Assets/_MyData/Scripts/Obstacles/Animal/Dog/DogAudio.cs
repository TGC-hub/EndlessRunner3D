
public class DogAudio : AudioEventByDistance
{
    protected override void ResetValue()
    {
        base.ResetValue();
        disLimit = 4f;
    }

    protected override void ActivateFeature()
    {
        if (isPlaySound) 
        { 
            AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.soundDog1 ); 
            isPlaySound = false;
        }
    }
}
