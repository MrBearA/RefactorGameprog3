using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] private LayerMask wallLayer;

    private AudioHandler audioHandler;
    private ParticleHandler particleHandler;

    private void Awake()
    {
        audioHandler = GetComponent<AudioHandler>();
        particleHandler = GetComponent<ParticleHandler>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Check if the collided object's layer is in the wallLayer layermask
        if ((wallLayer.value & (1 << hit.gameObject.layer)) > 0)
        {
            audioHandler?.PlayAudio();
            particleHandler?.PlayEffect();
        }
    }
}
