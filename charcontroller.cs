using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charcontroller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public ParticleSystem ps;
    private ParticleSystem.EmissionModule em;
    private bool engineIsOn;
    void Start()
    {
        em = ps.emission;
        engineIsOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            engineIsOn = true;
            em.enabled = true;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            engineIsOn = false;
            em.enabled = false;
        }
    }
    private void FixedUpdate()
    {
        switch (engineIsOn)
        {
            case true:
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Force);
                break;
            case false:
                rb.AddForce(new Vector2(0f, 0f), ForceMode2D.Force);
                break;
        }
    }
}
