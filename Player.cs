﻿
using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour
{
    [System.Serializable]
    public class PlayerStats
    {
        public int Health = 100;
    }
    public PlayerStats playerStats = new PlayerStats();
    public int fallBoundry = -20;
    public void DamagePlayer(int damage)
    {
        playerStats.Health -= damage;
        if (playerStats.Health <= 0)
        {
            GameMaster.KillPlayer(this);
        }
    }


    void Update()
    {
        if (transform.position.y <= fallBoundry)
        {
            DamagePlayer(999);
        }
    }
  
}
