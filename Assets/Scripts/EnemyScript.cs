using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    public float damage;
    public Rigidbody2D rb;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myPosition = transform.position;
        Vector3 playerPosition = player.transform.position;
        rb.MovePosition(myPosition+playerPosition * speed * Time.deltaTime);
        //print(myPosition + " " + playerPosition + " " + speed + " " + (myPosition+playerPosition*speed));
    }
}
