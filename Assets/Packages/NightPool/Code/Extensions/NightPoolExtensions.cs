using UnityEngine;

namespace ThanhDV.Pool
{
    public static class NightPoolExtensions
    {
        /// <summary>
        /// Despawns a particle system when it finishes playing.
        /// </summary>
        /// <param name="particleSystem">A particle system to despawn on complete.</param>
        /// <returns>A particle system to despawn on complete.</returns>
        public static ParticleSystem DespawnOnComplete(this ParticleSystem particleSystem)
        {
            NightPool.Despawn(particleSystem.gameObject, particleSystem.main.duration);
            return particleSystem;
        }

        public static NightGameObjectPool CreatePool(GameObject _prefab)
        {
            GameObject poolObject = new GameObject($"[NightPool] {_prefab.name}");
            NightGameObjectPool goPool = poolObject.AddComponent<NightGameObjectPool>();

            goPool.Init(_prefab);

            return goPool;
        }
    }
}