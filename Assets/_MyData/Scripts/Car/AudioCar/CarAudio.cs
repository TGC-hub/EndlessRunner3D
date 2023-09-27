
public class CarAudio : AudioEventByDistance
{
    protected override void ResetValue()
    {
        base.ResetValue();
        disLimit = 10f;
    }

    protected override void ActivateFeature()
    {
        if (isPlaySound) { AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.carDriving); isPlaySound = false; }
    }

}
