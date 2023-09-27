
public class CoinMagnetParticle : ReceiverParticle
{

    protected override void SpawningParticle()
    {
        base.SpawningParticle();
        ParticleManager.Instance.Spawning("CoinMagnet");
    }
}
