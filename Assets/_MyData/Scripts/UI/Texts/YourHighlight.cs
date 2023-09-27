
using UnityEngine;

public class YourHighlight : MonoBehaviour
{
    private void Start()
    {
        ObserverManager.Instance.CharacterOP.CharacterDeath += IsDeath;
        if (PlayerPrefs.HasKey("Score") == false)
        {
            PlayerPrefs.SetInt("Score", 0);
            PlayerPrefs.SetFloat("Distance", 0);
        }
    }

    protected virtual void IsDeath()
    {
        int score = ObserverManager.Instance.PointFishBoneOP.PointFish;
        float distance = PlayerManager.Instance.Checker.transform.parent.position.z;
        if (score > PlayerPrefs.GetFloat("Score"))
        {
            PlayerPrefs.SetInt("Score", score);
        }
        if (distance > PlayerPrefs.GetFloat("Distance"))
        {
            PlayerPrefs.SetFloat("Distance", distance);
        }
    }

}
