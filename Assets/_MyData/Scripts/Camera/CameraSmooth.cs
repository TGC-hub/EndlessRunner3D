
using UnityEngine;

public class CameraSmooth : MyScriptMonoBehaviour
{
    private Vector3 _offset;
    [SerializeField] private Vector3 myOffset;
    [SerializeField] private float smoothTime;
    private Vector3 _currentVelocity = Vector3.zero;
    private Vector3 targetPosition;

    protected override void Awake()
    {
        base.Awake();
        _offset = transform.position - LoadCharacter.Instance.Player.position + myOffset;
    }

    private void LateUpdate()
    {
        targetPosition = LoadCharacter.Instance.Player.position + _offset;
        targetPosition.y = transform.position.y;
        targetPosition.z = transform.position.z;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);
    }


}
