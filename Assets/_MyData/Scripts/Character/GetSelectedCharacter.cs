using System.Collections.Generic;
using UnityEngine;

public class GetSelectedCharacter : MyScriptMonoBehaviour
{
    [SerializeField] public List<Transform> charater;
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
    }

    protected virtual void SelectedCharacter(int index)
    {
        for (int i = 0; i < charater.Count; i++)
        {
            charater[i].gameObject.SetActive(false);
            charater[index].gameObject.SetActive(true);
        }
    }
}
