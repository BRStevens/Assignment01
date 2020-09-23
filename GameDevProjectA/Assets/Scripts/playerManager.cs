using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    Rigidbody2D rb2d;
    SpriteRenderer spriteRen;
    Animator tankAnim;

    public GameObject projectilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        // Show text that class is running
        Debug.Log("Test: Player Manager reporting!");

        // Assign/initializing the variables
        rb2d = GetComponent<Rigidbody2D>();
        spriteRen = GetComponent<SpriteRenderer>();
        tankAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        // get user input

        // if user pushes up key, then move gameobject up
        // check for up key pressed
        // change rigid body velocity (0, 2)
        // play animation: PlayerMoveA

        // if user pushes the down key, move gameobject down
        // check for down key pressed
        // change rigid body velocity (0, -2)
        // flip sprite on y
        // play animation: PlayerMoveA

        // if user pushes right, move right
        // check for right arrow pressed
        // change rigid body velocity (2,0)
        // play animation: PlayerMoveB

        // if user pushes left, move left
        // check for left arrow pressed
        // change rigid body velocity (-2,0)
        // flip sprite on x
        // play animation: PlayerMoveB

        // Deal with user input
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rb2d.velocity = new Vector2(0, 2);
            spriteRen.flipY = false;
            tankAnim.Play("PlayerMoveA");
        }
        else if(Input.GetKey("s") || Input.GetKey("down"))
        {
            rb2d.velocity = new Vector2(0, -2);
            spriteRen.flipY = true;
            tankAnim.Play("PlayerMoveA");
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(2, 0);
            spriteRen.flipX = false;
            tankAnim.Play("PlayerMoveB");
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-2, 0);
            spriteRen.flipX = true;
            tankAnim.Play("PlayerMoveB");
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
        }

        // If the user pushes the space bar then fire a projectile
                
        // check if user has pushed space
        if(Input.GetKeyDown("space"))
        {
            // Debug.Log("player tries fire");

            // Instantiate the player from a prefab!
            GameObject thisProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Rigidbody2D projectileRB = thisProjectile.GetComponent<Rigidbody2D>();
            projectileRB.velocity = new Vector2(0, 10);
        }


        // instantiate projectile
        // where? What position does the projectile start in?
        // what direction will the projectile move?
        // How fast will the projectile move?


    }
}
