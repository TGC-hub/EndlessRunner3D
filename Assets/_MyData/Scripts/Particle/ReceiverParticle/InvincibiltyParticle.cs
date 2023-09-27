
public class InvincibiltyParticle : ReceiverParticle
{
    protected override void SpawningParticle()
    {
        ParticleManager.Instance.Spawning("Invincibility");
    }


}
