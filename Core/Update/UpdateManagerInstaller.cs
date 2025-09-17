using Zenject;

namespace BartekNizio.EntitasSystem
{
	public class UpdateManagerInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<UpdateSystem>().AsSingle();
			Container.Bind<FixedUpdateSystem>().AsSingle();
			var updateManager = FindObjectOfType<UpdateManager>();
			Container.BindInstance( updateManager );
		}
	}
}