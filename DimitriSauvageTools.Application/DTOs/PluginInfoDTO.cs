﻿using System.Collections.Generic;

namespace DimitriSauvageTools.Application.DTOs
{
    public class PluginInfoDTO
    {
        #region Properties
        /// <summary>
        /// Affecte ou obtient le nom du plugin
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Affecte ou obtient le nom court du plugin
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// Affecte ou obtient la liste des vues (pages) du plugin
        /// </summary>
        public List<ViewInfoDTO> Views { get; set; }
        /// <summary>
        /// Affecte ou obtient la liste des composants
        /// </summary>
        public List<ComponentInfoDTO> Components { get; set; }
        #endregion
    }
}
