using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCams : MonoBehaviour
{

    public GameObject currentCam;
    public bool inCams;
    public GameObject OfficeCamera;
    public GameObject Cam01;
    public GameObject Crosshair;
    public GameObject[] MapUIco;

    // Start is called before the first frame update
    void Start()
    {
        currentCam = Cam01;
        inCams = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inCams)
        {
            //Debug.Log("t");
        }
    }

    private void OnMouseDown()
    {
        Cursor.lockState = CursorLockMode.None;
        //Cursor.visible = true;
        inCams = true;
        OfficeCamera.SetActive(false);
        currentCam.SetActive(true);
        Crosshair.SetActive(false);
        ToggleAllMapUI(true);
    }

    private void ToggleAllMapUI(bool jojo)
    {
        foreach (GameObject mapui in MapUIco)
        {
            mapui.SetActive(jojo);
        }
    }

    public void ChangeCam(GameObject nextCam)
    {
        Debug.Log("hellop");
        currentCam.SetActive(false);
        nextCam.SetActive(true);
        currentCam = nextCam;
    }
}
