
public class CrashParticle : ReceiverParticle
{
    protected override void SpawningParticle()
    {
        ParticleManager.Instance.Spawning("Crash");
    }
}
