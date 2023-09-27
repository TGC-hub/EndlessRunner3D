using System;
using UnityEngine;

public class ButtonEventOP : MonoBehaviour
{
    public event Action OnclickActiveItem;
    public event Action ButtonPause;
    public event Action ButtonPlay;
    public void OnclickActiveItemEvent()
    {
        OnclickActiveItem?.Invoke();
    }

    public void PauseEvent()
    {
        ButtonPause?.Invoke();
    }

    public void PlayEvent()
    {
        ButtonPlay?.Invoke();
    }
}
