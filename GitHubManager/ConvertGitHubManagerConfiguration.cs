﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Globalization;

namespace GitHubManager
{
    /// <summary>
    /// Methods to serialize and deserialize the application's config
    /// to and/or from JSON content.
    /// </summary>
    [ExplicitlySynchronized]
    public static class ConvertGitHubManagerConfiguration
    {
        /// <summary>
        /// Reference to an instance of
        /// <see cref="T:Newtonsoft.Json.JsonSerializerSettings" /> that specifies JSON
        /// config settings.
        /// </summary>
        public static readonly JsonSerializerSettings Settings;

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the
        /// <see cref="T:GitHubManager.ConvertGitHubManagerConfiguration" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static ConvertGitHubManagerConfiguration()
            => Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Formatting = Formatting.Indented,
                Converters =
                {
                    new IsoDateTimeConverter
                    {
                        DateTimeStyles =
                            DateTimeStyles.AssumeUniversal
                    }
                }
            };

        /// <summary>
        /// Parses the specified <paramref name="json" /> content and, if
        /// successful, initializes an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfig" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        /// <param name="json">(Required.) String containing the JSON content to be parsed.</param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfig" />
        /// interface whose
        /// properties are initialized from the JSON provided..
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="json" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        [return: NotLogged]
        public static IGitHubManagerConfig FromJson(
            [NotLogged] string json
        )
        {
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(json)
                );
            return JsonConvert.DeserializeObject<GitHubManagerConfig>(
                json, Settings
            );
        }

        /// <summary>
        /// Serializes an instance of an object that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfig" />
        /// interface to JSON
        /// and returns this data in the form of a <see cref="T:System.String" />.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object
        /// that implements the
        /// <see cref="T:GitHubManager.IGitHubManagerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the JSON content
        /// equivalent to the object passed.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="config" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        [return: NotLogged]
        public static string ToJson(
            [NotLogged] this IGitHubManagerConfig config
        )
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            return JsonConvert.SerializeObject(config, Settings);
        }
    }
}