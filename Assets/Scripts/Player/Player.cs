using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D rb2;

    void Start () {

    }

    void Update () {

    }

    void FixedUpdate () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        rb2.MovePosition (new Vector2 (mousePos.x, gameObject.transform.position.y));
    }

    void OnCollisionEnter2D (Collision2D c) {
        Debug.Log ("COLLISION!");
    }
}