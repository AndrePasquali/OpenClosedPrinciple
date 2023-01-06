namespace HeartAttackGames.OpenClosed
{
    public sealed class Shotgun: Weapon
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