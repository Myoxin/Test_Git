using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour {
    public float Speed;

    private void Mouvement ()
    {
        float factor = Speed * Time.fixedDeltaTime;

        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        Vector3 horizontalMouvement =  Vector3.right * horizontalAxis * factor;

        Vector3 verticalMovement = Vector3.forward * verticalAxis * factor;

        Vector3 finalMovement = horizontalMouvement + verticalMovement;
        finalMovement.Normalize();

        transform.position = transform.position + finalMovement * factor;
    }
    

    private void Awake()
    {
    
    }

    void Start ()
    {

	}
	

	void FixedUpdate ()
    {
        Mouvement();
	}
}
