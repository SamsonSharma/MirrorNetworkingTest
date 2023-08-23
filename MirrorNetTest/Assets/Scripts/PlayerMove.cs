using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : NetworkBehaviour
{   
   
    // Start is called before the first frame update
    void HandleMovement()
    {

        if(isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * 10, moveVertical *10, 0);
            transform.position = transform.position + movement; 
        }
    }

    void update()
    {
        HandleMovement();
    }

}
