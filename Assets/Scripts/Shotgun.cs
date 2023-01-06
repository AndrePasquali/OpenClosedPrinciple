namespace HeartAttackGames.OpenClosed
{
    public class Shotgun: Weapon
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