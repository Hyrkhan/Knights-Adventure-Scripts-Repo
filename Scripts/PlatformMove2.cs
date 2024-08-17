using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove2 : MonoBehaviour
{
    public Transform pos1, pos2, pos3, pos4;
    public float speed;
    public Transform startpos;

    Vector3 nextpos;
    void Start()
    {
        nextpos = startpos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos1.position)
        {
            nextpos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextpos = pos3.position;
        }
        if (transform.position == pos3.position)
        {
            nextpos = pos4.position;
        }
        if (transform.position == pos4.position)
        {
            nextpos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
        Gizmos.DrawLine(pos2.position, pos3.position);
        Gizmos.DrawLine(pos3.position, pos4.position);
        Gizmos.DrawLine(pos4.position, pos1.position);
    }
}
