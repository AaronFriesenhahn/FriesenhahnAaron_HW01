using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] float _PowerUpDuration = 2;
    protected abstract void PowerUp(Player player);
    protected abstract void PowerDown(Player player);


    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        if (player != null)
        {
            PowerUp(player);
            //disable collider and visuals
            
            //call PowerDown funtion after PowerUp duration is over and disable game object
            _PowerUpDuration -= Time.deltaTime;
            if (_PowerUpDuration < 0)
            {
                
                PowerDown(player);
            }
            gameObject.SetActive(false);
        }
    }
}
