using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2enemyMove : MonoBehaviour {

    public Transform tr;
    public float speed;

    void Update()
    {

        tr.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
