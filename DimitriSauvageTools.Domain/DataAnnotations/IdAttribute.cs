﻿using System;

namespace DimitriSauvageTools.Domain.DataAnnotations
{
    /// <summary>
    /// Attribute qui placé sur une propriété d'un objet modèle, indique que celle-ci sera mappée comme identifiant
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class IdAttribute : Attribute
    {
    }
}
