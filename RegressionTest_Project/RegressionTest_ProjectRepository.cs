﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RegressionTest_Project
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RegressionTest_ProjectRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("709341ba-1eb8-4b33-993b-95ac57749535")]
    public partial class RegressionTest_ProjectRepository : RepoGenBaseFolder
    {
        static RegressionTest_ProjectRepository instance = new RegressionTest_ProjectRepository();

        /// <summary>
        /// Gets the singleton class instance representing the RegressionTest_ProjectRepository element repository.
        /// </summary>
        [RepositoryFolder("709341ba-1eb8-4b33-993b-95ac57749535")]
        public static RegressionTest_ProjectRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RegressionTest_ProjectRepository() 
            : base("RegressionTest_ProjectRepository", "/", null, 0, false, "709341ba-1eb8-4b33-993b-95ac57749535", ".\\RepositoryImages\\RegressionTest_ProjectRepository709341ba.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("709341ba-1eb8-4b33-993b-95ac57749535")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    public partial class RegressionTest_ProjectRepositoryFolders
    {
    }
#pragma warning restore 0436
}