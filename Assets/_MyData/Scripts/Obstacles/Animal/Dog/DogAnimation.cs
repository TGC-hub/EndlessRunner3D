using UnityEngine;

public class DogAnimation : MyScriptMonoBehaviour
{
    [SerializeField] protected DogCtrl dogCtrl;

    protected Animator animator;
    protected int moveSpeedHash;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadDogCtrl();
    }

    protected virtual void LoadDogCtrl()
    {
        if (this.dogCtrl != null) { return; }
        else
        {
            this.dogCtrl = transform.parent.parent.GetComponent<DogCtrl>();
        }
    }

    protected override void Start()
    {
        base.Start();
        animator = GetComponent<Animator>();
        moveSpeedHash = Animator.StringToHash("MoveSpeed");
    }

    protected virtual void Update()
    {
        animator.SetFloat(moveSpeedHash, this.dogCtrl.DogTrap.moveSpeed);
    }
}
