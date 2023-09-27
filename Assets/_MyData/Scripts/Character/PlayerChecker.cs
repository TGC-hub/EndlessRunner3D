
using UnityEngine;

public class PlayerChecker : MyScriptMonoBehaviour
{
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private bool isGround;
    public bool IsGround { get { return isGround; } }
    
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadGroundCheck();
    }
    protected virtual void Update()
    {
        CheckIsGround();
    }

    protected virtual void LoadGroundCheck()
    {
        if (this.groundCheck != null) { return; }
        else
        {
            this.groundCheck = transform.Find("PointCheckGround").transform;
        }
    }

    protected void CheckIsGround()
    {
        float raycastDistance = 0.2f;
        isGround = Physics.Raycast(groundCheck.position, Vector3.down, raycastDistance, groundLayer);
    }
}
