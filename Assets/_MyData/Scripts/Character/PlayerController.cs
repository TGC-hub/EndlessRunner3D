using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private  float leftRightSpeed;
    [SerializeField] private  float jumpForce;
    [SerializeField] private  float slideSpeed;

    private Rigidbody rb;
    public Rigidbody Rigidbody { get { return rb; } }

    public bool canSlide = true;

    Vector3 newPosition;
    const float minX = -1.5f;
    const float maxX = 1.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovementHorizontal();
        SetJump();
        SetSlide();
    }
    protected virtual void MovementHorizontal()
    {
        newPosition = transform.position + new Vector3(InputManager.Instance.ValueKeycode * leftRightSpeed * Time.deltaTime, 0, 0);
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        transform.position = newPosition;
    }


    protected virtual void SetJump()
    {
        if (PlayerManager.Instance.Checker.IsGround && InputManager.Instance.ScrollDelta == 1 && canSlide)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    protected virtual void SetSlide()
    {
        if (InputManager.Instance.ScrollDelta == -1 && PlayerManager.Instance.Checker.IsGround && canSlide== true)
        {
            rb.AddForce(Vector3.forward * slideSpeed, ForceMode.Impulse);
            StartCoroutine(EnableSlide());
        }
    }

    private IEnumerator EnableSlide()
    {
        canSlide = false;
        yield return new WaitForSeconds(1.2f);
        canSlide = true;
    }

}
