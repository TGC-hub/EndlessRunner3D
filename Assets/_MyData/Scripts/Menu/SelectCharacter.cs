using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MyScriptMonoBehaviour
{
    [SerializeField] public List<Transform> charater;
    public int curren = 0;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadCharacter();
    }

    protected virtual void LoadCharacter()
    {
        if (this.charater.Count > 0) { return; }
        else
        {
            foreach (Transform prefab in transform)
            {
                this.charater.Add(prefab);
            }
            this.HidePrefabs();
        }

    }

    protected virtual void HidePrefabs()
    {
        foreach (Transform prefab in this.charater)
        {
            prefab.gameObject.SetActive(false);
        }
    }

    protected override void Start()
    {
        if (PlayerPrefs.HasKey("Selected"))
        {
            SelectedCharacter(PlayerPrefs.GetInt("Selected"));
        }
        else
        {
            SelectedCharacter(0);
        }
    }
    protected virtual void SelectedCharacter(int index)
    {
        for(int i = 0; i < charater.Count; i++) 
        {
            charater[i].gameObject.SetActive(false);
            charater[index].gameObject.SetActive(true);
            PlayerPrefs.SetInt("Selected", index);
        }
    }

    public virtual void YourSelection(int yourIndex)
    {
        curren += yourIndex;
        SelectedCharacter(curren);
    }

}
