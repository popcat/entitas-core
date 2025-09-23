using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BartekNizio.EntitasSystem
{
    [Game, Meta, Input, Ui, Event(EventTarget.Self), Event(EventTarget.Any)]
    public class AccelerationComponent : IComponent
    {
        public float Value;
    }
}