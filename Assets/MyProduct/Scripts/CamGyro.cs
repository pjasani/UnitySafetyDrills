using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamGyro : MonoBehaviour
{
    GameObject camParent;
    public Transform playerBody;
    // Start is called before the first frame update
    void Start()
    {
        camParent = new GameObject("CamParent");
        camParent.transform.position = this.transform.position;
        this.transform.parent = camParent.transform;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        camParent.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);     //Xroation from the gyroscope
        this.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, 0, 0); //Yroation for from the gyroscope
        //Debug.Log(-Input.gyro.rotationRateUnbiased.x);
        //playerBody.Rotate(-Input.gyro.rotationRateUnbiased.x, 0, 0);
    }
}
