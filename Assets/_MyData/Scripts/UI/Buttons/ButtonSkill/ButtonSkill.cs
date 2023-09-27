using System.Collections.Generic;
using UnityEngine;

public class ButtonSkill : MyScriptMonoBehaviour
{
    [SerializeField] protected CountPointFishBone countPointFishBone;
    [SerializeField] protected List<Transform> prefabs;
    [SerializeField] protected Transform noItem;
    public bool isButtonSkill = false;
    public bool isButtonClicked = false;
    Transform obj;

    protected override void Start()
    {
        base.Start();
        ObserverManager.Instance.ButtonEventOP.OnclickActiveItem += ButtonItemClicked;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadCountPoint();
        LoadPrefabs();
        LoadNoItem();
    }

    protected virtual void LoadNoItem()
    {
        if (noItem != null) { return; }
        this.noItem = transform.parent.Find("NoItem");
    }

    protected virtual void ButtonItemClicked()
    {
        isButtonClicked = true;
    }

    protected virtual void LoadPrefabs()
    {
        if (this.prefabs.Count > 0) { return; }
        else
        {
            Transform prefabObj = transform;
            foreach (Transform prefab in prefabObj)
            {
                this.prefabs.Add(prefab);
            }
            this.HidePrefabs();
        }

    }

    protected virtual void HidePrefabs()
    {
        foreach (Transform prefab in this.prefabs)
        {
            prefab.gameObject.SetActive(false);
        }
    }

    protected virtual void LoadCountPoint()
    {
        if (countPointFishBone != null) { return ; }
        this.countPointFishBone = transform.parent.GetComponent<CountPointFishBone>();
    }

    protected virtual void FixedUpdate()
    {
        RandomButtonSkill();
    }

    protected virtual void RandomButtonSkill()
    {
        
        if (countPointFishBone.currenPointFish >= 100 && isButtonSkill == false)
        {
            obj = RandomPrefab();
            obj.gameObject.SetActive(true);
            noItem.gameObject.SetActive(false);
            isButtonSkill = true;
        }
        if(isButtonSkill == true && isButtonClicked == true) 
        { 
            obj.gameObject.SetActive(false);
            noItem.gameObject.SetActive(true);
            isButtonSkill = false; 
            isButtonClicked = false; 
        }
    }


    public virtual Transform RandomPrefab()
    {
        int rand = Random.Range(0, this.prefabs.Count);
        return this.prefabs[rand];
    }

}
