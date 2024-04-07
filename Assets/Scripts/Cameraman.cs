using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraman : MonoBehaviour
{
    public float CameraSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(CameraSpeed * Time.deltaTime, 0, 0);
    }
    public void Add5Points()
    {
        CameraSpeed += 5;
        
    }
    public void Stopped()
    {
        CameraSpeed = 0;
    }
    public void SetSpeed(float newSpeed)
    {
        CameraSpeed = newSpeed;
    }
    public float GetSpeed()
    {
        return CameraSpeed;
    }
}
