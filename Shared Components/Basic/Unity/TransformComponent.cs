using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace BartekNizio.EntitasSystem
{
    [Game, Meta, Input, Ui, Event(EventTarget.Self), Event(EventTarget.Any)]
    public class TransformComponent : IComponent
    {
        public Transform Instance;
    }
}