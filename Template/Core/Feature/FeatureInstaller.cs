using Zenject;

namespace BartekNizio.EntitasSystem
{
	public class FeatureInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			InstallFeatures();
		}

		private void InstallFeatures()
		{
			//SceneInstaller.Install(Container);
			//GameObjectInstaller.Install(Container);
			//JobInstaller.Install(Container);
		}
	}
}