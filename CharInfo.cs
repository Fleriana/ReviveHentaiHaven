using UnityEngine;
using System.Collections;

public class CharInfo : MonoBehaviour 
{
    private RigidBody rb;
    [SerializeField]
    private float movementSpeed;


    // Use this for initialization

        void Start()
         {

            
            
            rb = GetComponent<RigidBody2D>();
            bool alive = true;
            int health = 100;
            float healthFloat = 100.0f;
            int level = 0;
            int xp = 0;
            GameObject player;
                        
        }
            
    // Update is called once per frame

        void Update() {
            float horizontal = input.GetAxis("Horizontal");
            HandleMovement(horizontal);
            
        }

    private void HandleMovement(float horizontal)
    {
        rb.velocity = new Vector2(horizontal*movementSpeed, rb.velocity.y);

    }

}