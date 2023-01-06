using UnityEngine;

namespace HeartAttackGames.OpenClosed
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] protected WeaponSettings WeaponSettings;
        [SerializeField] private float _nextFireTime;
        [SerializeField] protected int LoadedAmmo;
        [SerializeField] protected int ExtraAmmo;

        protected GameObject BulletPrefab => _bulletPrefab ?? (_bulletPrefab = WeaponSettings.BulletPrefab);
        private GameObject _bulletPrefab;
        
        protected bool CanFire
        {
            get
            {
                if (!(Time.time >= _nextFireTime) || LoadedAmmo == 0) return false;
                
                _nextFireTime = Time.time + WeaponSettings.FireRate;
                
                return true;
            }
        }

        protected bool CanReload => LoadedAmmo == 0 && ExtraAmmo > 0;

        public abstract void Fire();

        public abstract void Reload();
    }
}
