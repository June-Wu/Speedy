using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private PlatformManager _platformManager;
    private void OnEnable() 
    {
        _platformManager = GameObject.FindObjectOfType<PlatformManager>();
    }
    
    private void OnBecameInvisible() 
    {
        Destroy(gameObject);
        _platformManager.GenerateNewPlatform();
    }
}
