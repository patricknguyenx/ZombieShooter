using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByMouse : MonoBehaviour
{
    public float anglePerSecond;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float yaw = mouseX * anglePerSecond * Time.deltaTime;
        float yaw2 = mouseY * anglePerSecond * Time.deltaTime;
        transform.Rotate(-yaw2, yaw, 0);
    }
}
