using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float parallaxEffectMultiplier = 0.5f;
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    public SpriteRenderer sprite;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void Update()
    {
        // Calculate the distance the camera has moved since last frame
        float deltaX = cameraTransform.position.x - lastCameraPosition.x;
        float deltaY = cameraTransform.position.y - lastCameraPosition.y;

        // Update the position of the current object based on the camera movement
        sprite.material.mainTextureOffset += new Vector2(deltaX * parallaxEffectMultiplier, deltaY * parallaxEffectMultiplier);

        // Update the lastCameraPosition
        lastCameraPosition = cameraTransform.position;
    }
}
