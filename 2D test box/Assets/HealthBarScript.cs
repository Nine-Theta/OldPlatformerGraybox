﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour
{
    public int maxHP = 3;
    private int _hp = 3;
    private float maxWidth = 0.4f;

    private void Start()
    {
        _hp = maxHP;
        maxWidth = GetComponent<SpriteRenderer>().size.x;
    }

    private void Update()
    {

    }

    public void TakeDamage()
    {
        _hp--;
        AdjustBar();
    }

    public void TakeDamage(int damage)
    {
        _hp -= damage;
        AdjustBar();
    }

    public void Heal()
    {
        _hp++;
        AdjustBar();
    }

    public void Heal(int healing)
    {
        _hp += healing;
        if (_hp > maxHP)
            _hp = maxHP;
        AdjustBar();
    }

    private void AdjustBar()
    {
        Vector2 size = GetComponent<SpriteRenderer>().size;
        size.x = (maxWidth * (_hp / maxHP));
        GetComponent<SpriteRenderer>().size = size;
    }
}