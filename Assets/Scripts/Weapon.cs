using UnityEngine;

namespace HeartAttackGames.OpenClosed
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponSettings WeaponSettings;
        [SerializeField] private float _nextFireTime;
        private int LoadedAmmo;
        private int ExtraAmmo;

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

        private bool _canReload => ExtraAmmo > 0;

        public abstract void Fire();
        
        protected virtual void Reload()
        {
            if (!_canReload) return;
            
            var ammoCapacity = WeaponSettings.AmmoCapacity;
                
            if (ExtraAmmo >= ammoCapacity)
            {
                ExtraAmmo -= ammoCapacity;
                LoadedAmmo += ammoCapacity;
            }
            else LoadedAmmo += ExtraAmmo;
        }
    }
}
