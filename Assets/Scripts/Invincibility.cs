using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : PowerUpBase
{
    [SerializeField] Material _playerMaterial;
    [SerializeField] Material _InvincibleMaterial;
    Material _temporaryMaterial;

    protected override void PowerUp(Player player)
    {
        //make player invincible
        player.invincible = true;
        //change player color to Cyan
        _temporaryMaterial = _playerMaterial;
        _playerMaterial = _InvincibleMaterial;
    }

    protected override void PowerDown(Player player)
    {
        //return player to normal
        player.invincible = false;
        //change player color to normal
        _playerMaterial = _temporaryMaterial;
    }
}
