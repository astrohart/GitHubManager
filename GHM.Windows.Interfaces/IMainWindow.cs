﻿using System;
using System.Diagnostics;
using xyLOGIX.UI.Dark.Forms;

namespace GHM.Windows.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of the main
    /// application window.
    /// </summary>
    public interface IMainWindow : IDarkForm
    {
        /// <summary> Gets or sets a value indicating whether the user is signed in. </summary>
        /// <remarks>
        /// When this property's value is changed, the
        /// <see cref="E:GitHubManager.MainWindow.SignedInChanged" /> event is raised.
        /// </remarks>
        bool IsSignedIn { [DebuggerStepThrough] get; }

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:GHM.Windows.Interfaces.IMainWindow.IsSignedIn" /> property changes.
        /// </summary>
        event EventHandler SignedInChanged;
    }
}