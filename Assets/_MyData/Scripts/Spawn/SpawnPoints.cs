using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MyScriptMonoBehaviour
{
    [SerializeField] protected List<Transform> points;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPoints();
    }

    protected virtual void LoadPoints()
    {
        if (this.points.Count > 0) { return;}
        else
        {
            foreach (Transform point in transform)
            {
                this.points.Add(point);
            }
        }
    }

    public virtual Transform GetRandom()
    {
        int rand = Random.Range(0, this.points.Count);
        return this.points[rand];
    }

}
