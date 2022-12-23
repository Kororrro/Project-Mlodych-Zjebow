using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Spawner))]
public class Enemy : MonoBehaviour {
    public int damage = 3;
    public float speed = 5f;
    public Rigidbody2D rb;
    public Collider2D coll;
    public Spawner spawner;

    void Start() {
        
    }

    void Update() {
        Vector3 position = spawner.target.transform.position;
        rb = GetComponent<Rigidbody2D>();
        //print(position); //Starting position of the player, not the updated one
        rb.MovePosition(transform.position + position * speed * Time.deltaTime);
        print(position);
        
    }
    void OnTriggerEnter2D(Collider2D collider) {
        if (gameObject.CompareTag("Player")) {
            //print("bump");
        }
    }
}