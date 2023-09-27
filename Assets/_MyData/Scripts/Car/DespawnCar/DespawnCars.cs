
using UnityEngine;

public class DespawnCars : DespawnByDistance
{
    public override void DespawnObject()
    {
        SpawnCar.Instance.Despawn(this.transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 10f;
    }

}
