using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{
    [SerializeField]
    float moveVal;
    [SerializeField]
    float moveSpeed;
    bool moveFront;
    // Start is called before the first frame update
    void Start()
    {
        moveFront = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveFront)
            transform.Translate(0, 0, moveSpeed);
        else
            transform.Translate(0, 0, -moveSpeed);

        if (this.transform.position.z >= moveVal)
        {
            moveFront = false;
        }
        else if (this.transform.position.z <= -moveVal)
        {
            moveFront = true;
        }
    }
}
