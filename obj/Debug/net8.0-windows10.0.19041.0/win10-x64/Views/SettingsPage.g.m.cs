//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vaulinv.Views
{
#nullable disable

	[global::System.CodeDom.Compiler.GeneratedCode("CompiledBindings", null)]
	partial class SettingsPage
	{
		private bool _generatedCodeInitialized;

		private void InitializeAfterConstructor()
		{
			if (_generatedCodeInitialized)
				return;

			_generatedCodeInitialized = true;



			this.BindingContextChanged += this_BindingContextChanged;
			if (this.BindingContext is global::Vaulinv.ViewModels.SettingsViewModel dataRoot0)
			{
				Bindings_this.Initialize(this, dataRoot0);
			}
		}

		private void this_BindingContextChanged(object sender, global::System.EventArgs e)
		{
			Bindings_this.Cleanup();
			if (((global::Microsoft.Maui.Controls.Element)sender).BindingContext is global::Vaulinv.ViewModels.SettingsViewModel dataRoot)
			{
				Bindings_this.Initialize(this, dataRoot);
			}
		}

		SettingsPage_Bindings_this Bindings_this = new SettingsPage_Bindings_this();

		class SettingsPage_Bindings_this
		{
			SettingsPage _targetRoot;
			global::Vaulinv.ViewModels.SettingsViewModel _dataRoot;
			SettingsPage_BindingsTrackings_this _bindingsTrackings;

			public void Initialize(SettingsPage targetRoot, global::Vaulinv.ViewModels.SettingsViewModel dataRoot)
			{
				_targetRoot = targetRoot;
				_dataRoot = dataRoot;
				_bindingsTrackings = new SettingsPage_BindingsTrackings_this(this);

				Update();

				_bindingsTrackings.SetPropertyChangedEventHandler0(dataRoot);
			}

			public void Cleanup()
			{
				if (_targetRoot != null)
				{
					_bindingsTrackings.Cleanup();
					_dataRoot = null;
					_targetRoot = null;
				}
			}

			public void Update()
			{
				var dataRoot = _dataRoot;
				Update0_Title(dataRoot);
			}

			private void Update0_Title(global::Vaulinv.ViewModels.SettingsViewModel value)
			{
#line (10, 5) - (10, 26) 10 "..\..\..\..\..\Views\SettingsPage.xaml"
				_targetRoot.Title = value.Title;
#line default
			}

			class SettingsPage_BindingsTrackings_this
			{
				global::System.WeakReference _bindingsWeakRef;
				global::System.ComponentModel.INotifyPropertyChanged _propertyChangeSource0;

				public SettingsPage_BindingsTrackings_this(SettingsPage_Bindings_this bindings)
				{
					_bindingsWeakRef = new global::System.WeakReference(bindings);
				}

				public void Cleanup()
				{
					SetPropertyChangedEventHandler0(null);
				}

				public void SetPropertyChangedEventHandler0(global::Vaulinv.ViewModels.SettingsViewModel value)
				{
					global::CompiledBindings.MAUI.CompiledBindingsHelper.SetPropertyChangedEventHandler(ref _propertyChangeSource0, value, OnPropertyChanged0);
				}

				private void OnPropertyChanged0(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
				{
					var bindings = global::CompiledBindings.MAUI.CompiledBindingsHelper.TryGetBindings<SettingsPage_Bindings_this>(ref _bindingsWeakRef, Cleanup);
					if (bindings == null)
					{
						return;
					}

					var typedSender = (global::Vaulinv.ViewModels.SettingsViewModel)sender;
					if (string.IsNullOrEmpty(e.PropertyName) || e.PropertyName == "Title")
					{
						bindings.Update0_Title(typedSender);
					}
				}
			}
		}
	}
}