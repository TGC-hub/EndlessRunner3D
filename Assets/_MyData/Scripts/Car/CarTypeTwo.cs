
using UnityEngine;

public class CarTypeTwo : CarMovement
{
    [SerializeField] protected Transform posPointA;
    [SerializeField] protected Transform posPointB;
    
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPointA();
        LoadPointB();
    }

    protected virtual void LoadPointA()
    {
        if(this.posPointA != null) { return; }
        this.posPointA = this.transform.parent.Find("PointA");
    }

    protected virtual void LoadPointB()
    {
        if (this.posPointB != null) { return; }
        this.posPointB = this.transform.parent.Find("PointB");
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        ChangeRos();
        SetPos();
    }

    protected virtual void SetPos()
    {
        float posZCar = this.transform.position.z;
        if (this.posPointA.position.x == -1 && this.posPointB.position.x == 1) { return; }
        this.posPointA.position = new Vector3(-1f, this.transform.position.y, posZCar);
        this.posPointB.position = new Vector3(1f, this.transform.position.y, posZCar);
    }

    protected virtual void ChangeRos()
    {
        float distanceA = Vector3.Distance(this.transform.position, this.posPointA.position);
        float distanceB = Vector3.Distance(this.transform.position, this.posPointB.position);
        if(this.transform.rotation.y == 180) { return; }
        if (distanceA < 0.1f || distanceB < 0.1f) { this.transform.rotation = Quaternion.Euler(0, 180, 0); }
    }

}
