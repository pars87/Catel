﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISelectDirectoryService.cs" company="Catel development team">
//   Copyright (c) 2008 - 2013 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Catel.MVVM.Services
{
    /// <summary>
    /// Interface for the Select Directory service.
    /// </summary>
    public interface ISelectDirectoryService : IFileSupport
    {
        #region Properties
        /// <summary>
        /// Gets the directory name.
        /// </summary>
        string DirectoryName { get; }

        /// <summary>
        /// Gets or sets a value indicating whether to show the new folder button to be able to create new folders while browsing.
        /// </summary>
        /// <value><c>true</c> if the new folder button should be shown; otherwise, <c>false</c>.</value>
        bool ShowNewFolderButton { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Determines the name of the directory what will be used.
        /// </summary>
        /// <returns>
        /// <c>true</c> if a directory is selected; otherwise <c>false</c>.
        /// </returns>
        /// <remarks>
        /// If this method returns <c>true</c>, the <see cref="DirectoryName"/> property will be filled with the directory name. Otherwise,
        /// no changes will occur to the data of this object.
        /// </remarks>
        bool DetermineDirectory();
        #endregion
    }
}