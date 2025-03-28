using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public Light lightC;
    public Transform lightT;
    public Transform camT;
    public float t;
    public float t2;

    public int counter;


    void Start()
    {
        
    }

    void Update()
    {
        lightT.position = Vector3.Slerp(lightT.position, camT.position, t2);
        lightT.rotation = Quaternion.Slerp(lightT.rotation, camT.rotation, t);

        if (Input.GetKeyDown(KeyCode.F))
        {
            counter += 1;
        }

        if (counter == 2){ 
            counter = 0;
        }

        if (counter == 1) {
            lightC.intensity = 1;
        }
        else
        {
            lightC.intensity = 0;
        }
    }
}
