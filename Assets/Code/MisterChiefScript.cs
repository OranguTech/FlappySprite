using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisterChiefScript : MonoBehaviour
{
    [SerializeField] private float _upwardForceMultiplier = 100f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive!");
        
    }

    // Update is called once per frame

    void FixedUpdate()
    {

        Rigidbody2D ChiefBody = GetComponent<Rigidbody2D>();
        Debug.Log(ChiefBody.velocity.GetType());
        bool ActionButtonPressed = Input.GetButtonDown("Fire1");
        if (ActionButtonPressed.Equals(true))
        {
            ChiefBody.velocity = Vector3.zero;
            ChiefBody.AddForce(Vector3.up * _upwardForceMultiplier);
        }
    }
}
