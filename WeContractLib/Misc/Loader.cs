using System;
using System.Collections.Generic;
using System.Diagnostics;
using WeContractLib.Diagnostics;

namespace WeContractLib.Misc
{
	public sealed class Loader
	{
		private readonly Dictionary<string, Delegate> _actions;

		public static Loader Inst { get; } = new Loader();

		public int Count => _actions.Count;

		static Loader()
		{
		}

		private Loader()
		{
			_actions = new Dictionary<string, Delegate>();
		}

		public void AddAction(string name, Action action)
		{
			_actions.Add(name, action);
		}

		public void Initialize()
		{
			if (Count == 0)
			{
				InitializeActions();
			}
		}

		public void Execute()
		{
			if (Count == 0)
			{
				Log.Warning("No actions have been added to the loader!");
			}
			var sw = new Stopwatch();
			var swAction = new Stopwatch();
			sw.Start();

			foreach (var action in _actions)
			{
				swAction.Restart();

				action.Value.DynamicInvoke();
				GlobalEventHandler.LoaderActionInvoked?.Invoke(this, new GlobalEventHandler.EventArgs<string>(action.Key));

				Log.Info($"{action.Key} loaded in: {swAction.Elapsed.TotalMilliseconds}ms");
			}
			sw.Stop();
			Log.Info($"Time loading: {sw.Elapsed.TotalMilliseconds}ms");
		}

		private static void InitializeActions()
		{
			Log.Debug("Starting");
			Inst.AddAction("Initializing Controller", Controller.Initialize);
			Inst.AddAction("Initializing ContractManager", Controller.ContractManager.Initialize);
			Inst.AddAction("Initializing CustomerManager", Controller.CustomerManager.Initialize);
		}
	}
}
