﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace GHM.Config
{
    /// <summary>
    /// Settings that are user-configurable and that alter the behavior of
    /// the application
    /// </summary>
    public class GitHubManagerConfig : IGitHubManagerConfig
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:GHM.Config.GitHubManagerConfig" /> and returns a
        /// reference to it.
        /// </summary>
        [JsonConstructor]
        public GitHubManagerConfig()
        {
            LoginOnStartup = false;

            Scopes = new List<string>();
        }

        /// <summary>
        /// Gets or sets a string containing the ID of the particular GitHub app
        /// we want to utilize with this application.
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a string containing the Client Secret of the OAuth App
        /// to bind to this application.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets or sets a value that determines whether the application logs in
        /// to GitHub on startup.
        /// </summary>
        [JsonProperty("login_on_startup")]
        public bool LoginOnStartup
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Get or sets a collection of strings that defines the scopes to be
        /// used with this application.
        /// </summary>
        [JsonProperty("scopes")]
        public IList<string> Scopes
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }
    }
}