﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : Collidable
{
    public int damage = 1;
    public float pushForce = 5;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player_0" && coll.tag == "Fighter")
        {

            Damage dmg = new Damage()
            {
                damageAmount = damage,
                origin = transform.position,
                pushForce = pushForce
            };
            coll.SendMessage("ReceiveDamage", dmg);
        }
    }
}
