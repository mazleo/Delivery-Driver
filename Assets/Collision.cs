using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage = false;

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("I Just bumped into something!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage) {
            Destroy(other.gameObject);
            Debug.Log("Packaged picked up.");
            hasPackage = true;
        }
        else if (other.tag == "Customer") {
            if (hasPackage) {
                Debug.Log("Delivered!");
                hasPackage = false;
            }
        }
    }
}
