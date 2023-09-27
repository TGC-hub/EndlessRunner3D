
using UnityEngine;

public class ShowScoreHighlight : BaseText
{
    protected override void Start()
    {
        base.Start();
        int score = PlayerPrefs.GetInt("Score");
        text.SetText(score.ToString());
    }
}
