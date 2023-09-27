using System;
using UnityEngine;

public class CharacterOP : MonoBehaviour
{
    public event Action CharacterDeath;

    public void DeathEvent()
    {
        CharacterDeath?.Invoke();
    }
}
