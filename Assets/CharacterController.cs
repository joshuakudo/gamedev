using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public ParticleSystem ps;
    private ParticleSystem.EmissionModule em;
    void Start()
    {
        em = ps.emission;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            em.enabled = true;
        }
       if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            em.enabled = false;
        }
    }
}
