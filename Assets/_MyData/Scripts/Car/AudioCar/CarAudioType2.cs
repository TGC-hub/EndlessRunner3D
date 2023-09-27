
public class CarAudioType2 : CarAudio
{
    protected override void ActivateFeature()
    {
        if (isPlaySound) { AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.carBipBip); isPlaySound = false; }
    }
}
