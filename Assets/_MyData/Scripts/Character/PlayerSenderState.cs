using System.Collections;
using UnityEngine;

public class PlayerSenderState : MyScriptMonoBehaviour
{
    private bool isTriggerObstacle = false;
    public bool IsTriggerObstacle => isTriggerObstacle;

    private int isDead = 0;
    public int IsDead => isDead;

    protected override void Start()
    {
        ObserverManager.Instance.CharacterOP.CharacterDeath += IsDeath;
    }

    protected virtual void IsDeath()
    {
        isDead = 2;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9 )
        {
            isTriggerObstacle = true;
            isDead++;
            if (isDead == 2) 
            {
                ObserverManager.Instance.CharacterOP.DeathEvent();
                AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.death);
            }
            else 
            { 
                StartCoroutine(ResetIsDead());
            }
            ObserverManager.Instance.ObstacleEventOP.ObstacleEvent();
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            isTriggerObstacle = false;
        }
    }

    private IEnumerator ResetIsDead()
    {
        yield return new WaitForSeconds(5.0f);
        if(isDead != 2) { isDead = 0; }
    }


}
