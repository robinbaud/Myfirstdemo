using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public float lookingsensitiv = 100f;
    public float xrotation = 0f;
    public Transform playerbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lookingX = Input.GetAxis("Mouse X") * lookingsensitiv * Time.deltaTime;
        float lookingY = Input.GetAxis("Mouse Y") * lookingsensitiv * Time.deltaTime;
        xrotation -= lookingY;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * lookingX);
    }
}
