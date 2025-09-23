using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BartekNizio.EntitasSystem
{
	[Meta, Event(EventTarget.Self), Event(EventTarget.Any)]
	public class SystemSequenceComponent : IComponent
	{
		public SystemSequence Instance;
	}
}