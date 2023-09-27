

public class MultiplyerParticle : ReceiverParticle
{
    protected override void SpawningParticle()
    {
        base.SpawningParticle();
        ParticleManager.Instance.Spawning("Multiplyer");
    }
}
