using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1enemyMove : MonoBehaviour {

    public Transform tr;
    public float speed;

    void Update()
    {

        tr.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
