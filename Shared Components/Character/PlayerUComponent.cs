using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BartekNizio.EntitasSystem
{
    [Unique, Game, Meta, Input, Ui, Event(EventTarget.Self), Event(EventTarget.Any)]
    public class PlayerUComponent : IComponent
    {
    }
}