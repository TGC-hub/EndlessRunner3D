using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float disLimit = 70f;
    [SerializeField] protected float distance = 0f;

    protected override bool CanDespawn()
    {
        distance = Vector3.Distance(this.transform.position, LoadCharacter.Instance.Player.position);
        if (distance > disLimit && this.transform.position.z < LoadCharacter.Instance.Player.position.z) { return true; }
        else
        {
            return false;
        }
    }
}

