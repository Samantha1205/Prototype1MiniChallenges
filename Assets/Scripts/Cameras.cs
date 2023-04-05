using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject camera2;
    public int buttonCount = 0;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H) && buttonCount == 0)
        {
        buttonCount += 1;
         mainCamera.SetActive(!false);
         camera2.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.J) && buttonCount == 1)
        {
         mainCamera.SetActive(true);
         camera2.SetActive(false);
         buttonCount -= 1;
        }
    }
}
