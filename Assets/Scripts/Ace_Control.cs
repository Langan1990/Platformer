using UnityEngine;
using System.Collections;

public class Ace_Control : MonoBehaviour {


	public float maxSpeed = 10f;//caharacters move speed
	private float moveVelocity;
	bool right = true;
	Animator a;

	bool ground = false;
	public Transform groundcheck;
	float groundRadius = 0.2f;
	public float jumpForce = 500f;
	public LayerMask wiGround;

	private bool doubleJump;

    public Transform firepoint;
    public GameObject bullet;

    public float shotDelay;
    private float shotDelayCounter;

    public float knockback;
    public float knockbackcount;
    public float knockbacklength;
    public bool knockfromright;


	// Use this for initialization
	void Start () 
	{
		a = GetComponent<Animator> ();
	}


	void Update ()
	{

		if (ground) 
		{
			doubleJump = false;
		}


		if (ground && Input.GetKeyDown (KeyCode.Space)) //if satatement for jumping
		{
			a.SetBool("Ground", false);
			//GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
			Jump ();
		}

		if (!doubleJump && !ground && Input.GetKeyDown (KeyCode.Space))//if statement for doublejumping
		{
			a.SetBool("Ground", false);
			//GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
			Jump ();
			doubleJump = true;
		}

		moveVelocity = 0f;//stops the player moving after a button is released

		if (Input.GetKey (KeyCode.A))//if statement for moving left
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -maxSpeed;
		}

		if (Input.GetKey (KeyCode.D))//if statement for moving right
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = maxSpeed;
			
		}


        if (Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0)) //if statement for moving right
        {
            
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            shotDelayCounter = shotDelay;
        }

        if (Input.GetKey(KeyCode.F))
        {
            shotDelayCounter -= Time.deltaTime;
        }

        if (shotDelayCounter <= 0)
        {
            shotDelayCounter = shotDelay;
            Instantiate(bullet, firepoint.position, firepoint.rotation);
        }

        if (knockbackcount <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            if(knockfromright)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-knockback, knockback);
            }
            if(!knockfromright)
                {
                GetComponent<Rigidbody2D>().velocity = new Vector2(knockback, knockback);
            }

            knockbackcount -= Time.deltaTime;
        }  

	}

	public void Jump(){
		GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
	
	}


	
	void FixedUpdate () 
	{
		ground = Physics2D.OverlapCircle (groundcheck.position, groundRadius, wiGround);//used for finding out whether the character is on the ground or not
		a.SetBool ("Ground", ground);
		a.SetFloat ("vertSpeed", GetComponent<Rigidbody2D>().velocity.y);


		float move = Input.GetAxis("Horizontal");
		a.SetFloat ("Speed", Mathf.Abs (move));
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (move > 0 && !right)
		{
			Flip ();
		}

		else
		{
			if (move < 0 && right)
				Flip();
		}
	}

	void Flip()
	{
		right = !right;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;

	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = other.transform;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }

}
