using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public float posX;
    public float posY;
    public Vector2 teleportPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D colision)
    {
       // Debug.Log("foi");
        //se o que colidiu é o jogador
        if (colision.CompareTag("Player"))
        {
            Debug.Log("colidiu " +posY);
            Debug.Log(teleportPlayer);
            if (teleportPlayer != new Vector2(0,0))
            {
                FindObjectOfType<PlayerMov>().movePlayer(teleportPlayer);
            }
                CameraController.instance.setCameraPosition(new Vector2(posX, posY));
        }
        else
        {
            Debug.Log(colision.name);
        }
    }
}
