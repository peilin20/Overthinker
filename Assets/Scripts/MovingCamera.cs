using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    float cX, cY;
    [SerializeField] float moveSpeed;
    [SerializeField] float limitX;
    [SerializeField] float limitY;
    // Start is called before the first frame update
    void Start()
    {
        cX = 0;
        cY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        if (mousePos.x < 600)
        {
            if(cX > -limitX)
            {
                cX -= moveSpeed;
            }
            else
            {
                cX = -limitX;
            }
            
        } else if (mousePos.x > 1380) {
            if (cX < limitX)
            {
                cX += moveSpeed;
            }
            else
            {
                cX = limitX;
            }
        }

        if (mousePos.y < 300)
        {
            if (cY > -limitY)
            {
                cY -= moveSpeed;
            }
            else
            {
                cY = -limitY;
            }

        }
        else if (mousePos.y > 780)
        {
            if (cY < limitY)
            {
                cY += moveSpeed;
            }
            else
            {
                cY = limitY;
            }
        }
        transform.position = new Vector3(cX, cY, 0);
    }
}
