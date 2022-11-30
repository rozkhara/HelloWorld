using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class VaseBehavior : MonoBehaviour
{
    private void Update()
    {
        transform.localEulerAngles = new Vector3(0f, transform.localEulerAngles.y + 30f * Time.deltaTime, 0f);
    }
}
