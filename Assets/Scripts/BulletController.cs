using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

  [SerializeField]
  float initialVelocity = 12;

  [SerializeField]
  float lifeTime = 5;

	void Start ()
  {
    Rigidbody rigidbody = GetComponent<Rigidbody>();
    rigidbody.velocity = transform.forward * initialVelocity;

    Destroy(this.gameObject, lifeTime);
	}
}
