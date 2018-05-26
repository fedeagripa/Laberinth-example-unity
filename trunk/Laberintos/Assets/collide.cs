using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {
	public float speed = 15f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				//NOTES: En el evento del if se asocia al Event system del hierachy para saber si hay que hacerlo caminar o no 
				if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown(1)) {
						//TODO: ACA EN LUGAR DE LOGGEAR HAY QUE HACER CAMINAR AL MUCHACHO
						CharacterController controller = GetComponent<CharacterController>();
						Vector3 moveDirection = new Vector3();
						if (controller.isGrounded)
						{
								moveDirection = Camera.main.transform.forward;
								moveDirection *= speed;     
						}
						controller.Move(moveDirection * Time.deltaTime);
		}
	}
}
