using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomHandler : MonoBehaviour
{

    float n;
    public Button btn;

    // Use this for initialization
    void Start()
    {
        n = Camera.main.fieldOfView;
        btn.onClick.AddListener(ResetHandler);
    }

    // Update is called once per frame
    void Update()
    {
        //Zoom out
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (Camera.main.fieldOfView <= 100)
                Camera.main.fieldOfView += 2;
        }
        //Zoom in
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (Camera.main.fieldOfView > 40)
                Camera.main.fieldOfView -= 2;
        }
        //reset,按键复位
        if (Input.GetKey(KeyCode.R))
        {
            Camera.main.fieldOfView = n;
        }
    }
    //复位函数
    private void ResetHandler()
    {
        Camera.main.fieldOfView = n;
    }
}
