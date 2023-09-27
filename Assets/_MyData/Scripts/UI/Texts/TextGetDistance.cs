using UnityEngine;

public class TextGetDistance : BaseText
{
    [SerializeField] protected Transform player;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPlayer();
    }

    protected virtual void LoadPlayer()
    {
        if (this.player != null) { return; }
        this.player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    protected virtual void FixedUpdate()
    {
        float distance = Mathf.Round(player.position.z * 10f) / 100f;

        this.text.SetText(distance.ToString());
    }
}
