using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeCamera : MonoBehaviour
{
    public float x, y;
    public float sens;
    public float xr, yr;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 120;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        y = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        xr -= y;
        yr += x;

        transform.localRotation = Quaternion.Euler(xr, yr, 0);
        xr = Mathf.Clamp(xr, -90, 40f);
        yr = Mathf.Clamp(yr, -90, 90f);

    }
}
