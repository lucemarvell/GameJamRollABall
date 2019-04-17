using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Player;

   SerializeField private Vector3 offset;
    SerializeField private Space offsetSpace = Space.Self;
    private bool lookAt = true;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;

        if ( offset = Space.self)
        {
            transform.position = Player.transform(offset);
        }
        else
        {
            transform.position = Player.position + offset;
        }

        if (lookAt)
        {
            transform.LookAt(Player);
        }
        else
        {
            transform.rotation = Player.rotation;
        }
    } 
}
