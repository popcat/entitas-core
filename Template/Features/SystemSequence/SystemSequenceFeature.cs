namespace BartekNizio.EntitasSystem
{
	public class SystemSequenceFeature : InjectableFeature
	{
		public SystemSequenceFeature(Contexts contexts)
		{
			Add(new UpdateSequenceSystem(contexts));
		}
	}
}