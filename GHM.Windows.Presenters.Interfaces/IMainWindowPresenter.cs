﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace GHM.Windows.Presenters.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the
    /// <c>Presenter</c> object for the main application window.
    /// </summary>
    public interface IMainWindowPresenter
    {
        /// <summary>
        /// Shows the user a dialog that allows the user to set the options that
        /// change the program's behavior.
        /// </summary>
        /// <remarks>The options are persisted to and from the config.</remarks>
        void ConfigureOptions();

        /// <summary>
        /// Gets all the user's repositories.
        /// <para />
        /// </summary>
        /// <returns>
        /// Collection of instances of <see cref="T:GitHubManager.Repo" />
        /// objects that contain the data for all the repositories for the current user.
        /// </returns>
        Task<IList<IRepo>> GetRepos();
    }
}