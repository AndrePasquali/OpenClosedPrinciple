namespace HeartAttackGames.OpenClosed
{
    public class Pistol: Weapon
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