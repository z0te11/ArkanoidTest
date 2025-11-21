using System;

interface ISound
{
    event Action OnRepulsion;
    event Action OnDestroyed;
}
