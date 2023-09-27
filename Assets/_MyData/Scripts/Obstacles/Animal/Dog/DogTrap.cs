
public class DogTrap : DogMovement
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.moveSpeed = 0;
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        SetPosByMoveSpeed();
    }

    protected virtual void SetPosByMoveSpeed()
    {
        if(this.moveSpeed == 0) 
        {
            transform.position = transform.parent.position;
        }
    }

}
