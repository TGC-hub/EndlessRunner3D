
using UnityEngine;

public class ShowDistanceHighlight : BaseText
{
    protected override void Start()
    {
        base.Start();
        float distance = PlayerPrefs.GetFloat("Distance");
        distance = Mathf.Round(distance * 10f) / 100f;
        text.SetText(distance.ToString());
    }
}
