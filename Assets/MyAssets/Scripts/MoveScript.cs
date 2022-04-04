using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : SampleScript
{
    public Vector3 target;
    public float speed;

    private Transform transform;

    public void Start()
    {
        transform = this.gameObject.transform;
    }

    public override void Use()
    {
        if (transform.position != target)
        {
            transform.position = target * speed * Time.deltaTime;
        }
    }
}
