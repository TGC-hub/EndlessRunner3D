using System.Collections;
using UnityEngine;

public class UIEvent : ApearBase
{
    protected virtual void Start()
    {
        SetStartPos();
        StartCoroutine(WaitForSecond());
    }

    IEnumerator WaitForSecond()
    {
        yield return new WaitForSeconds(1.5f);
        Appear();
    }

    public override void Appear()
    {
        this.show = true;
    }

}
