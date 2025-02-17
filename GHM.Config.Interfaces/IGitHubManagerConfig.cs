﻿using System.Collections.Generic;
using System.Diagnostics;

namespace GHM.Config.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object, the
    /// values of whose properties define the behaviors of the application.
    /// </summary>
    public interface IGitHubManagerConfig
    {
        /// <summary>
        /// Gets or sets a string containing the ID of the particular GitHub app
        /// we want to utilize with this application.
        /// </summary>
        string ClientId
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a string containing the Client Secret of the OAuth App
        /// to bind to this application.
        /// </summary>
        string ClientSecret
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that determines whether the application logs in
        /// to GitHub on startup.
        /// </summary>
        bool LoginOnStartup
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Get or sets a collection of strings that defines the scopes to be
        /// used with this application.
        /// </summary>
        IList<string> Scopes
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Sets the value(s) of the property(ies) of this object to their default(s).
        /// </summary>
        void Reset();
    }
}