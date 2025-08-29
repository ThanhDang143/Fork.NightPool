namespace ThanhDV.Pool
{
    public enum BehaviourOnCapacityReached
    {
        ReturnNullableClone,
        Instantiate,
        InstantiateWithCallbacks,
        Recycle,
        ThrowException
    }
}