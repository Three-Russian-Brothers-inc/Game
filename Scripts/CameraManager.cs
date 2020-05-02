using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("CameraManager")]
public class CameraManager : MonoBehaviour
{
    private Transform camera_Transform; //camera tranform

    public float movementSpeed = 50f; //camera speed movement

    public float limitX = 50f; 
    public float limitY = 50f; 

    private void Start()
    {
        camera_Transform = transform;
    }

    private void Update()
    {
        Vector2 keyTransform = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector3 wantToPos = new Vector3(keyTransform.x, 0, keyTransform.y) * movementSpeed * Time.deltaTime;
        wantToPos = Quaternion.Euler(new Vector3(0f, transform.eulerAngles.y, 0f)) * wantToPos;
        wantToPos = camera_Transform.InverseTransformDirection(wantToPos);
        camera_Transform.Translate(wantToPos, Space.Self);
        camera_Transform.position = new Vector3(
            Mathf.Clamp(camera_Transform.position.x, -limitX, limitX),
            camera_Transform.position.y,
            Mathf.Clamp(camera_Transform.position.z, -limitY, limitY));
    }
}
