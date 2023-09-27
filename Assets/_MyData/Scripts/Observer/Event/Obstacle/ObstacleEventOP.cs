using System;
using UnityEngine;

public class ObstacleEventOP : MonoBehaviour
{
    public event Action ObstacleTrigger;

    public void ObstacleEvent()
    {
        ObstacleTrigger?.Invoke();
    }
}
