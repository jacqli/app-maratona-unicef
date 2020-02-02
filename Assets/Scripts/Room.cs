using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public float posX;
    public float posY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D (Collider2D colision)
    {
        Debug.Log("foi");
        //se o que colidiu é o jogador
        if (colision.CompareTag("Player"))
        {
            Debug.Log("colidiu " +posY);
            CameraController.instance.setCameraPosition(new Vector2(posX, posY));
            //CameraController.instance.setCameraPosition(new Vector2(transform.position.x, transform.position.y));
        }
        else
        {
            Debug.Log(colision.name);
        }
    }
}
