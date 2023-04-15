using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType { Bullet, Piercing }

[CreateAssetMenu(menuName = "Scriptable Objects/Weapon Data")]
public class WeaponData : ScriptableObject
{
    [Header("Weapon")]
    public WeaponType type;
    public bool automatic = true;
    public int maxAmmo = 4;
    public float fireRate = 0.5f;
    public int attackDamage = 1;
    public float reloadTime = 0.5f;
    public float headshotMultiplier = 1.5f;
    public float weaponRange = 20f;

    [Header("Muzzle")]
    public GameObject fireEffect;
    public AudioClip fireSound;

    [Header("Raycast")]
    public GameObject hitEffect;

    [Header("Prefab")]
    public WeaponController weaponPrefab;
}
