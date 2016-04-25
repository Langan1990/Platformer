using UnityEngine;
using System.Collections;

public class BossPatrol : MonoBehaviour {


    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatisWall;
    private bool hittingWall;

    private bool atEdge;
    public Transform edgeCheck;

    private float ySize;

    // Use this for initialization
    void Start()
    {
        ySize = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatisWall);

        atEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatisWall);

        if (hittingWall || !atEdge)
        {
            moveRight = !moveRight;
        }

        if (moveRight)
        {
            transform.localScale = new Vector3(-ySize, transform.localScale.y, transform.localScale.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(ySize, transform.localScale.y, transform.localScale.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
    }
}
