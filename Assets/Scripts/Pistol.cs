namespace HeartAttackGames.OpenClosed
{
    public sealed class Pistol: Weapon
    {
        public override void Fire()
        {
            if (CanFire)
            {
                LoadedAmmo--;
                Instantiate(BulletPrefab);
            }
        }
        
    }
}