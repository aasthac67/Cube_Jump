using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayscript : MonoBehaviour {
    Vector3 pos;
    Vector3 temp;
    int count;
	// Use this for initialization
	void Start () {
        pos = transform.position;
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))    //0 is for left click of mouse 1 is for right click
        {
            //Debug.Log("button pressed");
            //Ray refers to a small area of ur game in unity here the red cube
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (shootray(ray) == 1)
            {
                if (count % 2 == 0)
                {
                    pos = transform.position;
                    pos.y += 5;
                    transform.position = pos;
                }
                else
                {
                    pos = transform.position;
                    pos.y -= 5;
                    transform.position = pos;
                }
                count++;
            }
        }
	}
    int shootray(Ray ray)
    {
        RaycastHit rhit;
        if(Physics.Raycast(ray ,out rhit, 1000.0f))
        {
            Debug.Log("cube collided");
            return 1;
        }
        return 0;
    }
}
