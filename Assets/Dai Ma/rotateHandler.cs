using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI;

public class rotateHandler : MonoBehaviour
{
    /*
	public Button upBtn;
	public Button downBtn;
	public Button leftBtn;
	public Button rightBtn;
	*/
    int flag = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //修改键盘指令
        if (Input.GetKeyDown(KeyCode.A))
        {
            flag = 1;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            flag = 0;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            flag = 2;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            flag = 0;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            flag = 3;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            flag = 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            flag = 4;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            flag = 0;
        }
        //旋转
        if (flag == 1)
        {
            transform.Rotate(Vector3.up * 100 * Time.deltaTime);//left
        }
        else if (flag == 2)
        {
            transform.Rotate(Vector3.down * 100 * Time.deltaTime);//right
        }
        else if (flag == 3)
        {
            transform.Rotate(Vector3.left * 100 * Time.deltaTime);//up
        }
        else if (flag == 4)
        {
            transform.Rotate(Vector3.right * 100 * Time.deltaTime);//right
        }
        //复位
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
    }
}

