﻿
using System.Configuration;

namespace DimitriSauvageTools.Infrastructure.FluentConfig
{
    public class FluentConfigurationSectionHandler : ConfigurationSection
    {
        /// <summary>
        /// Retourne la configuration base de données par base de données
        /// </summary>
        [ConfigurationProperty("fluentConfigurationDatabaseDispatchers")]
        [ConfigurationCollection(typeof(FluentConfigurationDatabaseDispatcherElement), AddItemName = "fluentConfigurationDatabaseDispatcher")]
        public FluentConfigurationDatabaseDispatcherCollection FluentConfigurationDispatchers
        {
            get { return this["fluentConfigurationDatabaseDispatchers"] as FluentConfigurationDatabaseDispatcherCollection; }
        }

        /// <summary>
        /// Retourne la configuration pour nHibernate
        /// </summary>
        /// <returns></returns>
        public static FluentConfigurationSectionHandler GetConfig()
        {
            return ConfigurationManager.GetSection("fluentConfiguration") as FluentConfigurationSectionHandler;
        }
    }
}
