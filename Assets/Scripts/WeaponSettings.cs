using UnityEngine;

namespace HeartAttackGames.OpenClosed
{
    [CreateAssetMenu(menuName = "Weapon/Settings", fileName = "WeaponData")]
    public sealed class WeaponSettings: ScriptableObject
    {
        public string WeaponName = "WeaponName";
        public float FireRate = 1.0F;
        public int AmmoCapacity = 10;
        public float Damage = 10F;
        public GameObject BulletPrefab;
    }
}