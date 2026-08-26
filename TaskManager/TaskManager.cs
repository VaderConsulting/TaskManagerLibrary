using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Threading;

namespace TaskManager
{

	public partial class TaskManager : UserControl
	{
		#region Constants

		#endregion

		#region Delegates

		#endregion

		#region Events

		#endregion

		#region Enums

		#endregion

		#region DLL Imports

		#endregion

		#region Fields

		private ObservableCollection<Task> _Tasks = new ObservableCollection<Task>();
		private int _TaskCounter = -1;

		#endregion

		#region Properties

		#endregion

		#region Constructors and Destructor

		public TaskManager()
		{
			InitializeComponent();

			_Tasks.CollectionChanged += _Tasks_CollectionChanged;
		}

		#endregion

		#region Event Handlers

		private void _Tasks_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
				case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
					break;
				case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
					break;
				case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
					break;
				case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
					break;
				case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
					break;
			}

		}

		#endregion

		#region Private Methods

		#endregion

		#region Public Methods

		public (int, IProgress<string>) Start(Action action)
		{
			int TaskCounter = this.cmbStatus.Items.Add("Task starting");

			Progress<string> progressHandler = new Progress<string>(value =>
			{
				this.cmbStatus.Items[TaskCounter] = value;
			});

			IProgress<string> progress = progressHandler as IProgress<string>;

			Task t = new Task(action, TaskCreationOptions.PreferFairness | TaskCreationOptions.LongRunning);

			_Tasks.Add(t);

			progress.Report("Task starting");
			t.Start();

			return (TaskCounter, progress);
		}

		#endregion

		#region Classes

		// By my own convention all classes should be in their own file, however sometimes it makes sense to include a class within the same file as it's parent Namespace

		#endregion

	}
}
