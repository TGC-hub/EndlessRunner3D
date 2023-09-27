using System.Collections.Generic;
using UnityEngine;

public class DogMovement : AnimalMovement
{
    [SerializeField] protected List<Transform> pointTransform;
    private Transform posA;
    private Transform posB;

    protected override void Awake()
    {
        base.Awake();
        SetPointPos();
    }
    protected virtual void SetPointPos()
    {
            posA = new GameObject("PosA").transform;
            posB = new GameObject("PosB").transform;

            posA.position = new Vector3(-2.5f, transform.parent.position.y, transform.position.z);
            posB.position = new Vector3(2.5f, transform.parent.position.y, transform.parent.position.z);

            posA.SetParent(holderPoint);
            posB.SetParent(holderPoint);

            pointTransform = new List<Transform>();
            this.pointTransform.Add(posA);
            this.pointTransform.Add(posB);
    }

    protected override void CheckPos()
    {
        base.CheckPos();
        if(posA.position.x == -2.5 && posB.position.x != 2.5) 
        {
            posA.position = new Vector3(-2.5f, transform.parent.position.y, transform.position.z);
            posB.position = new Vector3(2.5f, transform.parent.position.y, transform.parent.position.z);
        }else if (posA.position.x == 2.5 && posB.position.x != -2.5)
        {
            posA.position = new Vector3(2.5f, transform.parent.position.y, transform.position.z);
            posB.position = new Vector3(-2.5f, transform.parent.position.y, transform.parent.position.z);
        }else if (posB.position.x == -2.5 && posA.position.x != 2.5)
        {
            posA.position = new Vector3(2.5f, transform.parent.position.y, transform.position.z);
            posB.position = new Vector3(-2.5f, transform.parent.position.y, transform.parent.position.z);
        }
        else
        {
            posA.position = new Vector3(-2.5f, transform.parent.position.y, transform.position.z);
            posB.position = new Vector3(2.5f, transform.parent.position.y, transform.parent.position.z);
        }
    }
    protected override List<Transform> PointMovement => pointTransform;


}
