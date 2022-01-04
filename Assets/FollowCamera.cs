using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject driver = GameObject.Find("Driver");
        transform.position = driver.transform.position + new Vector3(0,0,-10);
    }
}
