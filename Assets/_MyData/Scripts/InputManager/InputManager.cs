
using System.Text.RegularExpressions;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }

    [Header("PC")]
    private float valueKeycode = 0;
    public float ValueKeycode => valueKeycode;


    private float scrollDelta;
    public float ScrollDelta => scrollDelta;

    private bool isLocked = false;


    [Header("Mobile")] 
    private float swipeThreshold = 50f;
    private bool isTouchingLeft = false;
    private bool isTouchingRight = false;
    private bool isTouchingUp = false;
    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("Only 1 InputManager allow to exist");
        InputManager.instance = this;
    }

    private void Start()
    {
        ObserverManager.Instance.CharacterOP.CharacterDeath += LockedInput;
        ObserverManager.Instance.ButtonEventOP.ButtonPause += LockedInput;
        ObserverManager.Instance.ButtonEventOP.ButtonPlay += UnlockedInput;
    }

    protected virtual void LockedInput()
    {
        isLocked = true;
    }

    protected virtual void UnlockedInput()
    {
        isLocked = false;
    }
    private void Update()
    {
        if(isLocked == true) { valueKeycode = 0; scrollDelta = 0; }
        else
        {
            SetKeyCodePC();
            MobileInput();
        }
    }
    protected virtual void SetKeyCodePC()
    {
        valueKeycode = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) { scrollDelta = 1; } 
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) { scrollDelta= -1; }
        else { scrollDelta = 0;}
    }

    //---------------------------Mobile-------------------------------
    private void MobileInput()
    {
        // Kiểm tra các cử chỉ chạm trên màn hình
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //Touch touch = Input.GetTouch(0);

            // Kiểm tra khi bắt đầu chạm
            if (touch.phase == TouchPhase.Began)
            {
                // Lấy vị trí chạm ban đầu
                Vector2 touchStartPos = touch.position;

                // Tính toán vị trí trung tâm màn hình
                float screenWidth = Screen.width;
                float screenCenter = screenWidth / 2f;

                // Xác định hành động dựa trên vị trí chạm
                if (touchStartPos.x < screenCenter)
                {
                    // Chạm vào màn hình bên trái, thiết lập trạng thái chạm bên trái
                    isTouchingLeft = true;
                    isTouchingRight = false;
                }
                else
                {
                    // Chạm vào màn hình bên phải, thiết lập trạng thái chạm bên phải
                    isTouchingLeft = false;
                    isTouchingRight = true;
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                // Khi kết thúc chạm, đặt lại trạng thái chạm
                isTouchingLeft = false;
                isTouchingRight = false;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                // Khi vuốt màn hình
                Vector2 touchDelta = touch.deltaPosition;

                // Kiểm tra hướng vuốt (lên hoặc xuống)
                if (Mathf.Abs(touchDelta.y) > Mathf.Abs(touchDelta.x) && Mathf.Abs(touchDelta.y) > swipeThreshold)
                {
                    if (touchDelta.y < 0)
                    {
                        if (!isTouchingUp)
                        {
                            Jump();
                        }
                    }
                    else
                    {
                        // Vuốt xuống, thực hiện hành động Slide
                        Slide();
                    }
                }
            }
        }

        if (isTouchingLeft)
        {
            // Giữ chạm màn hình bên trái, thực hiện hành động TurnLeft
            TurnLeft();
        }
        else if (isTouchingRight)
        {
            // Giữ chạm màn hình bên phải, thực hiện hành động TurnRight
            TurnRight();
        }
    }

    private void TurnLeft()
    {
        valueKeycode = -1;
    }

    private void TurnRight()
    {
        valueKeycode = 1;
    }

    private void Jump()
    {
        scrollDelta = 1;
        isTouchingUp = true;
        Invoke("ResetJump", 0.5f);
    }
    private void ResetJump()
    {
        isTouchingUp = false;
    }

    private void Slide()
    {
        scrollDelta = -1;
    }

}
