using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerCamera;
    public Transform player;

    public float MouseX;
    public float MouseY;
    public float sens; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseX += Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        MouseY += Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        MouseY = Mathf.Clamp(MouseY,-90f, 90f);

        player.rotation = Quaternion.Euler(0, MouseX,0);
        playerCamera.rotation = Quaternion.Euler(-MouseY, MouseX, 0);


        transform.position = player.position + new Vector3(0,0.55f,0);
    }
}
