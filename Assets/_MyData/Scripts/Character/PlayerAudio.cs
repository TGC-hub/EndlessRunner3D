
using System.Collections;
using UnityEngine;

public class PlayerAudio : MyScriptMonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    private bool onSoundJump = true;
    private bool onSoundSlide = true;
    private float randomTimer = 0;
    private float randomDelay = 0.25f;
    public void Slide()
    {
        if (InputManager.Instance.ScrollDelta == -1 && PlayerManager.Instance.Checker.IsGround && onSoundSlide == true)
        {
            AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.slide2);
            AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.slide);
            StartCoroutine(EnableSlide());
        }
    }

    private IEnumerator EnableSlide()
    {
        onSoundSlide = false;   
        yield return new WaitForSeconds(1.2f);
        onSoundSlide = true;
    }
    public void Jump()
    {
        if(playerController.Rigidbody.velocity.y > 1 && onSoundJump == true )
        {
            AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.jump);
            onSoundJump = false;
        }

        if(playerController.Rigidbody.velocity.y == 0 && onSoundJump == false)
        {
            onSoundJump = true;
        }
        
    }

    protected virtual void Update()
    {
        Jump(); 
        Slide();
    }

    protected virtual void FixedUpdate()
    {
        SoundRun();
    }

    protected virtual void SoundRun()
    {
        if(onSoundSlide == true && PlayerManager.Instance.Checker.IsGround && PlayerManager.Instance.PlayerMovement.logicGameSpeed == 1)
        {
            if (PlayerManager.Instance.SenderState.IsDead == 1)
            {
                randomDelay = 0.4f;
            }
            else
            {
                randomDelay = 0.25f;
            }
            this.randomTimer += Time.fixedDeltaTime;
            if (this.randomTimer < this.randomDelay) return;
            this.randomTimer = 0;
            AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.footsteps);
        }
    }

}
