﻿// <auto-generated />
namespace CodeFirstWithExistingDatabase.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.4.4")]
    public sealed partial class DeleteDatePublishedColumnFromCoursesTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(DeleteDatePublishedColumnFromCoursesTable));
        
        string IMigrationMetadata.Id
        {
            get { return "202303310659362_DeleteDatePublishedColumnFromCoursesTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
