using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaMain : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosisition;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
    public void ResetBall(){
        transform.position = resetPosisition;
        transform.position = new Vector3(resetPosisition.x, resetPosisition.y, 2);
    }
}
