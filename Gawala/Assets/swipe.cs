using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GG.Infrastructure.Utils.Swipe;


public class swipe : MonoBehaviour
{
    [SerializeField] private SwipeListener swipeListener;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float playerSpeed;
    private Vector2 playerDirection = Vector2.zero;


    private void OnEnable()
    {
        swipeListener.OnSwipe.AddListener(OnSwipe);

    }
    private void OnSwipe(string swipe)
    {
        switch (swipe)
        {
            case "Left":
                playerDirection = Vector2.left;
                break;
            case "Right":
                playerDirection = Vector2.right;
                break;

        }
    }
    private void Update()
    {
        playerTransform.position += (Vector3)playerDirection * playerSpeed * Time.deltaTime;
    }
    private void OnDisable()
    {

        swipeListener.OnSwipe.RemoveListener(OnSwipe);
    }



}
