public class AudioEventByDistance : EventActiveByDistance
{
    protected bool isPlaySound = true;
    protected override void ActivateFeature()
    {
       
    }

    protected override void StopActivateFeature()
    {
        isPlaySound = true;
    }

}
