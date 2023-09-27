using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAppear : ApearBase
{
    private void OnEnable()
    {
        Appear();
    }

    private void OnDisable()
    {
        Hide();
    }
}
