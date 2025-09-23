using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace BartekNizio.EntitasSystem
{
    [Game, Meta, Input, Ui, Event(EventTarget.Self), Event(EventTarget.Any)]
    public class Collider2DListComponent : IComponent
    {
        public List<Collider2D> Instances;
    }
}