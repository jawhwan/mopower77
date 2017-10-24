using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Transform tf_target;
    private float f_moveSpeed;

    public void SetMove(Transform tf,float fSpeed)
    {
        tf_target = tf;
        f_moveSpeed = fSpeed;
    }




}
