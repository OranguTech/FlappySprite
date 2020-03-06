using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _upwardForceMultiplier = 100f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive!");
        
    }

    // Update is called once per frame

    void Update()
    {

        Rigidbody2D PlayerBody = GetComponent<Rigidbody2D>();
        //Debug.Log(PlayerBody.velocity.GetType());
        bool ActionButtonPressed = Input.GetButtonDown("Fire1");
        if (ActionButtonPressed.Equals(true))
        {
            PlayerBody.velocity = Vector3.zero;
            //Backflip!
            PlayerBody.MoveRotation(PlayerBody.rotation + 10);

            //Face one direction only
            //PlayerBody.MoveRotation(10);
            PlayerBody.AddForce(Vector3.up * _upwardForceMultiplier);

            //PlayerBody.transform.Rotate(0, 0, 0);
            //PlayerBody.MoveRotation(0);
        }
    }
}
