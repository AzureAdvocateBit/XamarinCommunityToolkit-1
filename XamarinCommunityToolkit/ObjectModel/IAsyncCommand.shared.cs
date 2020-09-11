﻿// Inspired by AsyncAwaitBestPractices.MVVM.IAsyncCommand: https://github.com/brminnick/AsyncAwaitBestPractices
namespace Xamarin.CommunityToolkit.ObjectModel
{
	/// <summary>
    /// An Async implementation of ICommand for Task
    /// </summary>
	public interface IAsyncCommand<in T> : System.Windows.Input.ICommand
	{
		/// <summary>
		/// Executes the Command as a Task
		/// </summary>
		/// <returns>The Task to execute</returns>
		/// <param name="parameter">Data used by the command. If the command does not require data to be passed, this object can be set to null.</param>
		System.Threading.Tasks.Task ExecuteAsync(T parameter);

		/// <summary>
		/// Raises the CanExecuteChanged event.
		/// </summary>
		void RaiseCanExecuteChanged();
	}

	/// <summary>
	/// An Async implementation of ICommand for Task
	/// </summary>
	public interface IAsyncCommand : System.Windows.Input.ICommand
	{
		/// <summary>
		/// Executes the Command as a Task
		/// </summary>
		/// <returns>The Task to execute</returns>
		System.Threading.Tasks.Task ExecuteAsync();

		/// <summary>
		/// Raises the CanExecuteChanged event.
		/// </summary>
		void RaiseCanExecuteChanged();
	}
}
